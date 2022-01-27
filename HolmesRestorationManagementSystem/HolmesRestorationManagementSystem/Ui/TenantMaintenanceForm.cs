using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HolmesRestorationManagementSystem.Data_Access_Layer;
using HolmesRestorationManagementSystem.Business_Objects;

namespace HolmesRestorationManagementSystem.Ui
{
    public partial class TenantMaintenanceForm : Form
    {
        List<TruthValues> Truths1 = new List<TruthValues>();
        List<Assistance> AssistanceTypes = new List<Assistance>();
        List<Tenant> Tenants = new List<Tenant>();
        Tenant CurrentTenant;
        Tenant SelectedTenant = new Tenant();
        string title = "Holmes Management System";
        (bool, string) IsValid;
        bool CellChanged = false;
        int CellsChanged = 0;
        string OldCellValue = null;
        int RowIdx;
        int ColumnIdx;

        public TenantMaintenanceForm()
        {
            InitializeComponent();
        }

        private void TenantMaintenanceForm_Load(object sender, EventArgs e)
        {
            Truths1 = TruthValuesDB.GetTruthValues();
            AssistanceTypes = AssistanceDB.GetAssistanceInfo();

            PhoneTxt.MaskInputRejected += new MaskInputRejectedEventHandler(Phone_InputRejected);
            DisabledCb.DataSource = Truths1;
            DisabledCb.DisplayMember = "Truth_Value";
            DisabledCb.ValueMember = "Id";

            // may need to change values for AssitanceCb to actual assistance types ask Holmes
            AssitanceCb.DataSource = AssistanceTypes;
            AssitanceCb.DataSource = "Assistance_Type";
            AssitanceCb.ValueMember = "Id";
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
                    errorPv.SetError(EmploymentLenTxt, msg);
                    break;
                case 7:
                    errorPv.SetError(DisabledCb, msg);
                    break;
                case 8:
                    errorPv.SetError(AssitanceCb, msg);
                    break;
            }
        }
        private void ResetErrorPv()
        {
            errorPv.Clear();
        }
        private void ClearForm()
        {
            IdTxt.Text = string.Empty;
            FnameTxt.Text = string.Empty;
            LnameTxt.Text = string.Empty;
            PhoneTxt.Text = string.Empty;
            AddressTxt.Text = string.Empty;
            OccupationTxt.Text = string.Empty;
            EmploymentLenTxt.Text = string.Empty;
            DisabledCb.SelectedIndex = -1;
            AssitanceCb.SelectedIndex = -1;
        }
        private (bool,string) CheckForm(ref int tbx)
        {
            bool valid = true;
            string emsg = string.Empty;

            if(string.IsNullOrEmpty(IdTxt.Text))
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
            else if (string.IsNullOrEmpty(EmploymentLenTxt.Text))
            {
                valid = false;
                emsg = "Employmen length cannot be blank";
                tbx = 6;
            }
            if (DisabledCb.SelectedIndex == -1)
            {
                valid = false;
                emsg = "You must select a value for Disabled";
                tbx = 7;
            }
            else if (AssitanceCb.SelectedIndex == -1)
            {
                valid = false;
                emsg = "You must select a value for Government assistance";
                tbx = 8;
            }
            if (!int.TryParse(IdTxt.Text,out int id))
            {
                valid = false;
                emsg = "Id must be numeric";
                tbx = 0;
            }
            else if (!int.TryParse(EmploymentLenTxt.Text, out int emp))
            {
                valid = false;
                emsg = "Employment length must be numeric";
                tbx = 6;
            }

            return (valid, emsg);
        }
        private (bool, string) CheckSearch(ref int tbx, ref string searchType)
        {
            bool valid = true;
            string emsg = string.Empty;

            if (string.IsNullOrEmpty(IdTxt.Text) && string.IsNullOrEmpty(FnameTxt.Text)
                && string.IsNullOrEmpty(LnameTxt.Text))
            {
                valid = false;
                emsg = "You must have Id, first name or last name to search";
                tbx = 2;
            }
            else if (String.IsNullOrEmpty(FnameTxt.Text) && String.IsNullOrEmpty(LnameTxt.Text) 
                && !int.TryParse(IdTxt.Text, out int id))
            {
                valid = false;
                emsg = "Id must be numeric";
                tbx = 0;
            }
            if (!string.IsNullOrEmpty(IdTxt.Text))
                searchType = "id";

            if (string.IsNullOrEmpty(IdTxt.Text) && !string.IsNullOrEmpty(FnameTxt.Text) &&
                !string.IsNullOrEmpty(LnameTxt.Text))
                searchType = "name";
            else if (string.IsNullOrEmpty(IdTxt.Text) && string.IsNullOrEmpty(FnameTxt.Text)
                && !string.IsNullOrEmpty(LnameTxt.Text))
                searchType = "lname";
            else if (string.IsNullOrEmpty(IdTxt.Text) && !string.IsNullOrEmpty(FnameTxt.Text)
                && string.IsNullOrEmpty(LnameTxt.Text))
                searchType = "fname";

            return (valid, emsg);
        }
        private (bool, string) CheckDelete(ref int tbx)
        {
            bool valid = true;
            string emsg = string.Empty;

            if (string.IsNullOrEmpty(IdTxt.Text))
            {
                valid = false;
                emsg = "You must have id number to delete tenant";
                tbx = 0;
            }
            else if (!int.TryParse(IdTxt.Text, out int id))
            {
                valid = false;
                emsg = "Id must be numeric";
                tbx = 0;
            }

            return (valid, emsg);
        }
        private void SetTenant(bool isUpdate)
        {
            int nextId;
            try
            {
                if (!isUpdate)
                {
                    nextId = TenantDB.GetNextTenantId();
                    CurrentTenant.Tenant_Id = nextId;
                }
                if (isUpdate)
                    CurrentTenant.Tenant_Id = Convert.ToInt32(IdTxt.Text);

                CurrentTenant.First_Name = FnameTxt.Text.Trim();
                CurrentTenant.Last_Name = LnameTxt.Text.Trim();
                CurrentTenant.Phone_Number = PhoneTxt.Text;
                CurrentTenant.Address = AddressTxt.Text.Trim();
                CurrentTenant.Occupation = OccupationTxt.Text.Trim();
                CurrentTenant.Employment_Length = Convert.ToInt32(EmploymentLenTxt.Text);
                CurrentTenant.Disabled = DisabledCb.SelectedText;
                CurrentTenant.Government_Assistance = AssitanceCb.SelectedText;
            }
            catch(Exception ex)
            { DisplayError(ex.Message, title); }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            int Tbx = -1;
            IsValid = CheckForm(ref Tbx);
            bool GoodAdd;

            if (IsValid.Item1)
            {
                try
                {
                    CurrentTenant = new Tenant();
                    SetTenant(false);
                    GoodAdd = TenantDB.AddTenant(CurrentTenant);

                    if (GoodAdd)
                        DisplaySuccess("Tenant has been added", title);
                    else if (!GoodAdd)
                        DisplayError("Error, Tenant was not added", title);
                }
                catch(Exception ex)
                { DisplayError(ex.Message, title); }
            }
            else
                SetErrorPv(IsValid.Item2, Tbx);
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Tenants = TenantDB.GetTenants();
                TenantDG.DataSource = Tenants;

                if (Tenants.Count == 0)
                    DisplaySuccess("There are currently no tenatns", title);
            }
            catch(Exception ex)
            { DisplayError(ex.Message, title); }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            int Tbx = -1;
            string searchType = null;

            IsValid = CheckSearch(ref Tbx, ref searchType);

            if (IsValid.Item1)
            {
                try
                {
                    CurrentTenant = new Tenant();

                    switch (searchType)
                    {
                        case "id":
                            CurrentTenant.Tenant_Id = Convert.ToInt32(IdTxt.Text);
                            Tenants[0] = TenantDB.GetTenant(CurrentTenant.Tenant_Id);
                            break;
                        case "name":
                            CurrentTenant.First_Name = FnameTxt.Text.Trim();
                            CurrentTenant.Last_Name = LnameTxt.Text.Trim();
                            Tenants = TenantDB.SearchTenant(CurrentTenant);
                            break;
                        case "fname":
                            CurrentTenant.First_Name = FnameTxt.Text.Trim();
                            CurrentTenant.Last_Name = string.Empty;
                            Tenants = TenantDB.SearchTenant(CurrentTenant);
                            break;
                        case "lname":
                            CurrentTenant.First_Name = string.Empty;
                            CurrentTenant.Last_Name = LnameTxt.Text.Trim();
                            Tenants = TenantDB.SearchTenant(CurrentTenant);
                            break;
                    }
                    
                    if (Tenants.Count > 0)
                        TenantDG.DataSource = Tenants;
                    else
                    {
                        DisplayError("Match not found", title);
                        Tenants = TenantDB.GetTenants();
                        TenantDG.DataSource = Tenants;
                    }
                }
                catch (Exception ex)
                { DisplayError(ex.Message, title); }
            }
            else
                SetErrorPv(IsValid.Item2, Tbx);
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int Tbx = -1;
            IsValid = CheckForm(ref Tbx);
            bool GoodUpdate;

            if (IsValid.Item1)
            {
                try
                {
                    CurrentTenant = new Tenant();
                    SetTenant(true);
                    GoodUpdate = TenantDB.UpdateTenant(CurrentTenant);

                    if (GoodUpdate)
                        DisplaySuccess("Tenant has been updated", title);
                    else if (!GoodUpdate)
                        DisplayError("Error, tenant was not been updated", title);
                }
                catch (Exception ex)
                { DisplayError(ex.Message, title); }
            }
            else
                SetErrorPv(IsValid.Item2, Tbx);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int Tbx = -1;
            bool GoodDelete;
            IsValid = CheckDelete(ref Tbx);

            if (IsValid.Item1)
            {
                try
                {
                    CurrentTenant = new Tenant();
                    CurrentTenant.Tenant_Id = Convert.ToInt32(IdTxt.Text);
                    GoodDelete = TenantDB.DeleteTenant(CurrentTenant);

                    if (GoodDelete)
                        DisplaySuccess("Tenant has been deleted", title);
                    else if (!GoodDelete)
                        DisplayError("Error, tenant was not deleted", title);
                }
                catch (Exception ex)
                { DisplayError(ex.Message, title); }
            }
            else
                SetErrorPv(IsValid.Item2, Tbx);
        }

        private void ClearBtn_Click_1(object sender, EventArgs e)
        {
            ClearForm();
            TenantDG.DataSource = null;
        }
        private void Phone_InputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (PhoneTxt.MaskFull)
            {
                toolTip1.ToolTipTitle = "Max Numbers";
                toolTip1.Show("Maximum number of digits reached", PhoneTxt, 3000);
            }
            else if (e.Position == PhoneTxt.Mask.Length)
            {
                toolTip1.ToolTipTitle = "End of Number";
                toolTip1.Show("You can not add extra digits, 10 digits only", PhoneTxt, 3000);
            }
            else
            {
                toolTip1.ToolTipTitle = "Invalid Input";
                toolTip1.Show("Invalid input, only digits 0-9 allowed", PhoneTxt, 3000);
            }
        }

        private void TenantDG_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (CellsChanged >= 1)
            {
                try
                {
                    switch (ColumnIdx)
                    {
                        case 0:
                            SelectedTenant.Tenant_Id = Convert.ToInt32(OldCellValue);
                            DisplayError("Tenant Id cannot be edited", title);
                            break;
                        case 1:
                            SelectedTenant.First_Name =
                                TenantDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value.ToString();
                            break;
                        case 2:
                            SelectedTenant.Last_Name =
                                TenantDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value.ToString();
                            break;
                        case 3:
                            SelectedTenant.Phone_Number =
                                TenantDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value.ToString();
                            break;
                        case 4:
                            SelectedTenant.Address =
                                TenantDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value.ToString();
                            break;
                        case 5:
                            SelectedTenant.Occupation =
                                TenantDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value.ToString();
                            break;
                        case 6:
                            SelectedTenant.Employment_Length =
                                Convert.ToInt32(TenantDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value);
                            break;
                        case 7:
                            SelectedTenant.Disabled =
                                TenantDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value.ToString();
                            break;
                        case 8:
                            SelectedTenant.Government_Assistance =
                                TenantDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value.ToString();
                            break;
                    }
                }
                catch(Exception ex)
                { DisplayError(ex.Message, title); }
            }
            
        }



        private void TenantDG_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (CellsChanged >= 1)
            {
                try
                {
                    bool GoodEdit = TenantDB.UpdateTenant(SelectedTenant);

                    if (GoodEdit)
                        DisplaySuccess("Tenant has been edited", title);
                    else if (!GoodEdit)
                        DisplayError("Error, tenant was not edited", title);

                }
                catch (Exception ex)
                { DisplayError(ex.Message, title); }
            }
        
        }
        private void TenantDG_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CellsChanged++;
        }

        private void TenantDG_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (TenantDG.CurrentCell.ColumnIndex > 0)
            {
                TenantDG.EditMode = DataGridViewEditMode.EditProgrammatically;
                TenantDG.BeginEdit(true);
            }
            else
                TenantDG.ReadOnly = true;
        }

        private void TenantDG_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            RowIdx = TenantDG.CurrentCell.RowIndex;
            ColumnIdx = TenantDG.CurrentCell.ColumnIndex;
            OldCellValue = TenantDG.CurrentCell.Value.ToString();
        }
    }
}
