using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HolmesRestorationManagementSystem.Business_Objects;
using HolmesRestorationManagementSystem.Data_Access_Layer;

namespace HolmesRestorationManagementSystem.Ui
{
    public partial class TenantViewForm : Form
    {
        List<Tenant> AllTenants = new List<Tenant>();
        List<TruthValues> Truths = new List<TruthValues>();
        List<Assistance> AssistanceTypes = new List<Assistance>();
        Tenant SelectedTenant = new Tenant();
        Tenant EditedTenant;
        string title = "Holmes Management System";
        bool TextChanged;
        (bool, string) IsValid;

        public TenantViewForm()
        {
            InitializeComponent();
        }
        private void TenantViewForm_Load(object sender, EventArgs e)
        {
            AllTenants = TenantDB.GetTenants();
            TenantCB.DataSource = AllTenants;
            TenantCB.DisplayMember = "First_Name" + "Last_Name";
            TenantCB.ValueMember = "Tenant_Id";

            Truths = TruthValuesDB.GetTruthValues();
            DisabledCB.DataSource = Truths;
            DisabledCB.DisplayMember = "Truth_Value";
            DisabledCB.ValueMember = "Id";

            AssistanceTypes = AssistanceDB.GetAssistanceInfo();
            AssistanceCB.DataSource = AssistanceTypes;
            AssistanceCB.DisplayMember = "Assistance_Type";
            AssistanceCB.ValueMember = "Id";
        }

        private void BackItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            EnableControls();
        }
        private void EnableControls()
        {
            IdTxt.ReadOnly = true;
            FnameTxt.ReadOnly = false;
            LnameTxt.ReadOnly = false;
            PhoneTxt.ReadOnly = false;
            AddressTxt.ReadOnly = false;
            OccupationTxt.ReadOnly = false;
            AcceptBtn.Enabled = true;
            AcceptBtn.Visible = true;
        }
        private void SetFormText(Tenant t)
        {
            try
            {
                IdTxt.Text = t.Tenant_Id.ToString();
                FnameTxt.Text = t.First_Name;
                LnameTxt.Text = t.Last_Name;
                PhoneTxt.Text = t.Phone_Number;
                AddressTxt.Text = t.Address;
                OccupationTxt.Text = t.Occupation;
                EmpLengthTxt.Text = t.Employment_Length.ToString();
                DisabledCB.SelectedIndex = DisabledCB.FindString(t.Disabled);
                AssistanceCB.SelectedIndex = AssistanceCB.FindString(t.Government_Assistance);
            }
            catch(Exception ex)
            { throw ex; }
        }
        private void TenantCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedTenant = AllTenants[TenantCB.SelectedIndex];
            SetFormText(SelectedTenant);
        }
        private void SetNewTenant(Tenant t)
        {
            try
            {
                t.Tenant_Id = Convert.ToInt32(IdTxt.Text);
                t.First_Name = FnameTxt.Text.Trim();
                t.Last_Name = LnameTxt.Text.Trim();
                t.Phone_Number = PhoneTxt.Text.Trim();
                t.Address = AddressTxt.Text.Trim();
                t.Occupation = OccupationTxt.Text.Trim();
                t.Employment_Length = Convert.ToInt32(EmpLengthTxt.Text);
                t.Disabled = DisabledCB.SelectedText;
                t.Government_Assistance = AssistanceCB.SelectedText;
            }
            catch(Exception ex)
            { throw ex; }
        }
        private (bool, string) CheckForm(ref int tbx)
        {
            bool valid = true;
            string emsg = string.Empty;

            if (string.IsNullOrEmpty(IdTxt.Text))
            {
                valid = false;
                emsg = "Id cannot be blank";
                tbx = 0;
            }
            else if (string.IsNullOrEmpty(FnameTxt.Text))
            {
                valid = false;
                emsg = "First name cannot be blank";
                tbx = 1;
            }
            else if (string.IsNullOrEmpty(LnameTxt.Text))
            {
                valid = false;
                emsg = "Last name cannot be blank";
                tbx = 2;
            }
            else if (string.IsNullOrEmpty(PhoneTxt.Text))
            {
                valid = false;
                emsg = "Phone number cannot be blank";
                tbx = 3;
            }
            else if (string.IsNullOrEmpty(AddressTxt.Text))
            {
                valid = false;
                emsg = "Address cannot be blank";
                tbx = 4;
            }
            else if (string.IsNullOrEmpty(OccupationTxt.Text))
            {
                valid = false;
                emsg = "Occupation cannot be blank";
                tbx = 5;
            }
            else if (string.IsNullOrEmpty(EmpLengthTxt.Text))
            {
                valid = false;
                emsg = "Employmen length cannot be blank";
                tbx = 6;
            }
            if (DisabledCB.SelectedIndex == -1)
            {
                valid = false;
                emsg = "You must select a value for Disabled";
                tbx = 7;
            }
            else if (AssistanceCB.SelectedIndex == -1)
            {
                valid = false;
                emsg = "You must select a value for Government assistance";
                tbx = 8;
            }
            if (!int.TryParse(IdTxt.Text, out int id))
            {
                valid = false;
                emsg = "Id must be numeric";
                tbx = 0;
            }
            else if (!int.TryParse(EmpLengthTxt.Text, out int emp))
            {
                valid = false;
                emsg = "Employment length must be numeric";
                tbx = 6;
            }

            return (valid, emsg);
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            int Tbx = -1;
            IsValid = CheckForm(ref Tbx);
            bool GoodEdit;

            if(IsValid.Item1)
            {
                try
                {
                    EditedTenant = new Tenant();
                    SetNewTenant(EditedTenant);

                    if (SelectedTenant != EditedTenant)
                    {
                        GoodEdit = TenantDB.UpdateTenant(EditedTenant);

                        if (GoodEdit)
                            DisplaySuccess("Tenant was edited", title);
                        else if (!GoodEdit)
                            DisplayError("Error, tenant was not edited", title);
                    }
                    else
                        DisplayError("Tenant information is already stored in database", title);
                }
                catch(Exception ex)
                { DisplayError(ex.Message, title); }
            }
        }
        private void DeleteItem_Click(object sender, EventArgs e)
        {
            bool GoodDelete;

            if (TenantCB.SelectedIndex != -1)
            {
                DialogResult result =
                    MessageBox.Show("Selected Tenant will be permanently deleted, Do you wish to continue?",
                    title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    GoodDelete = TenantDB.DeleteTenant(SelectedTenant);

                    if (GoodDelete)
                        DisplaySuccess("Tenant has been deleted", title);
                    else if (!GoodDelete)
                        DisplayError("Error, tenant was not deleted", title);
                }
            }
            else
                DisplayError("You must select a tenant to delete", title);
        }
        private void DisplaySuccess(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DisplayError(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void SetErrorPv(string msg, int tbx)
        {
            switch (tbx)
            {
                case 0:
                    errorPv.SetError(IdTxt, msg);
                    break;
                case 1:
                    errorPv.SetError(FnameTxt, msg);
                    break;
                case 2:
                    errorPv.SetError(LnameTxt, msg);
                    break;
                case 3:
                    errorPv.SetError(PhoneTxt, msg);
                    break;
                case 4:
                    errorPv.SetError(AddressTxt, msg);
                    break;
                case 5:
                    errorPv.SetError(OccupationTxt, msg);
                    break;
                case 6:
                    errorPv.SetError(EmpLengthTxt, msg);
                    break;
                case 7:
                    errorPv.SetError(DisabledCB, msg);
                    break;
                case 8:
                    errorPv.SetError(AssistanceCB, msg);
                    break;
            }
        }
        private void ResetErrorPv()
        {
            errorPv.Clear();
        }


    }
}
