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
    public partial class WorkViewForm : Form
    {
        List<WorkNeeded> PropertyWork = new List<WorkNeeded>();
        List<Property> AllProperties = new List<Property>();
        WorkNeeded SelectedWork = new WorkNeeded();
        string title = "Holmes Management System";
        (bool, string) IsValid;
        int PropertyIndx;

        public WorkViewForm()
        {
            InitializeComponent();
        }

        private void WorkViewForm_Load(object sender, EventArgs e)
        {
            try
            {
                AllProperties = PropertyDB.GetAddressAndId();
                PropertiesCB.DataSource = AllProperties;
                PropertiesCB.DisplayMember = "Address";
                PropertiesCB.ValueMember = "Property_Id";
            }
            catch(Exception ex)
            { throw ex; }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditItem_Click(object sender, EventArgs e)
        {
            ResetErrorPv();

            int Tbx = -1;
            IsValid = CheckSelect(ref Tbx);

            if (IsValid.Item1)
                EnableControls();
            else
                SetErrorPv(Tbx, IsValid.Item2);
        }
        private void EnableControls()
        {
            WorkIdTxt.ReadOnly = false;
            PropertyIdTxt.ReadOnly = false;
            PriorityLevelTxt.ReadOnly = false;
            WorkTxt.ReadOnly = false;
            AcceptBtn.Enabled = true;
            AcceptBtn.Visible = true;
        }
        private void DisplaySuccess(string msg, string title)
        {MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);}
        private void DisplayError(string msg, string title)
        { MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        private void SetWork()
        {
            try
            {
                SelectedWork = new WorkNeeded();
                SelectedWork.Work_Id = Convert.ToInt32(WorkIdTxt.Text);
                SelectedWork.Property_Id = Convert.ToInt32(PropertyIdTxt.Text);
                SelectedWork.Work_Needed = WorkTxt.Text.Trim();
                SelectedWork.Desired_Completion_Date = completionDateDP.Value;
                SelectedWork.Priority_Level = Convert.ToInt32(PriorityLevelTxt.Text);
            }
            catch(Exception ex)
            { throw ex; }

        }
        private void SetErrorPv(int widgetIndx, string msg)
        {
            switch (widgetIndx)
            {
                case 0:
                    errorPv.SetError(PropertiesCB, msg);
                    break;
                case 1:
                    errorPv.SetError(WorkCB, msg);
                    break;
                case 2:
                    errorPv.SetError(WorkIdTxt, msg);
                    break;
                case 3:
                    errorPv.SetError(PropertyIdTxt, msg);
                    break;
                case 4:
                    errorPv.SetError(PriorityLevelTxt, msg);
                    break;
                case 5:
                    errorPv.SetError(completionDateDP, msg);
                    break;
                case 6:
                    errorPv.SetError(WorkTxt, msg);
                    break;
            }

        }
        private void ResetErrorPv()
        {
            errorPv.Clear();
        }
       
        private (bool,string) CheckSelect(ref int tbx)
        {
            bool valid = true;
            string msg = string.Empty;

            if (PropertiesCB.SelectedIndex == -1)
            {
                valid = false;
                msg = "You must select a property address to view work";
                tbx = 0;
            }    
            if (WorkCB.SelectedIndex == -1)
            {
                valid = false;
                msg = "You  must select a work id to view and edit";
                tbx = 1;
            }

            return (valid, msg);
        }
        private (bool,string) CheckForm(ref int tbx)
        {
            bool valid = true;
            string msg = string.Empty;
            DateTime cDate = DateTime.Now;

            if (string.IsNullOrEmpty(WorkIdTxt.Text))
            {
                valid = false;
                msg = "Work Id cannot be blank";
                tbx = 2;
            }
            else if (string.IsNullOrEmpty(PropertyIdTxt.Text))
            {
                valid = false;
                msg = "Proeprty id cannot be blank";
                tbx = 3;
            }
            else if (string.IsNullOrEmpty(WorkTxt.Text))
            {
                valid = false;
                msg = "Work cannot be blank";
                tbx = 6;
            }
            else if (string.IsNullOrEmpty(PriorityLevelTxt.Text))
            {
                valid = false;
                msg = "Priority level cannot be blank";
                tbx = 4;
            }
            if (completionDateDP.Value <= cDate)
            {
                valid = false;
                msg = "Compeltion date must be set";
                tbx = 5;
            }
            if (!int.TryParse(WorkIdTxt.Text, out int wId))
            {
                valid = false;
                msg = "Work id must be numeric";
                tbx = 2;
            }
            else if (!int.TryParse(PropertyIdTxt.Text,out int pId))
            {
                valid = false;
                msg = "Property id must be numeric";
                tbx = 3;
            }
            else if (!int.TryParse(PriorityLevelTxt.Text, out int pLevel))
            {
                valid = false;
                msg = "Priority level must be numeric";
                tbx = 4;
            }

            return (valid, msg);
        }
        private (bool,string) CheckDelete(ref int tbx)
        {
            bool valid = true;
            string msg = string.Empty;

            if (string.IsNullOrEmpty(WorkIdTxt.Text))
            {
                valid = false;
                msg = "You must enter work id to delete";
                tbx = 2;
            }
            if (!int.TryParse(WorkIdTxt.Text, out int wId))
            {
                valid = false;
                msg = "Work id must be numeric";
                tbx = 2;
            }

            return (valid, msg);
        }
        private void SetFormText()
        {
            SelectedWork.Work_Id = Convert.ToInt32(WorkIdTxt.Text);
            SelectedWork.Property_Id = Convert.ToInt32(PropertyIdTxt.Text);
            SelectedWork.Work_Needed = WorkTxt.Text.Trim();
            SelectedWork.Desired_Completion_Date = completionDateDP.Value;
            SelectedWork.Priority_Level = Convert.ToInt32(PriorityLevelTxt.Text);
        }
        private void PropertiesCB_SelectionChangeCommitted(object sender, EventArgs e)
        {           
            try
            {
                PropertyIndx = Convert.ToInt32(PropertiesCB.SelectedValue);
                PropertyWork = WorkNeededDB.GetPropertyWork(PropertyIndx);
                PropertiesCB.DataSource = PropertyWork;
                PropertiesCB.DisplayMember = "Work_Id";
                PropertiesCB.ValueMember = "Work_Id";
            }
            catch (Exception ex)
            { DisplayError(ex.Message, title); }
        }

        private void WorkCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                SelectedWork = PropertyWork[WorkCB.SelectedIndex];
                SetFormText();
            }
            catch (Exception ex)
            { throw ex; }
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            int Tbx = -1;
            IsValid = CheckForm(ref Tbx);
            bool GoodEdit;

            if (IsValid.Item1)
            {
                try
                {
                    SetWork();
                    GoodEdit = WorkNeededDB.UpdateWork(SelectedWork);

                    if (GoodEdit)
                        DisplaySuccess("Work specification has been edited", title);
                    else if (!GoodEdit)
                        DisplayError("Error, work specifications were not edited", title);
                }
                catch (Exception ex)
                { DisplayError(ex.Message, title); }
            }
            else
                SetErrorPv(Tbx, IsValid.Item2);
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int Tbx = -1;
            IsValid = CheckDelete(ref Tbx);
            bool GoodDelete;

            if (IsValid.Item1)
            {
                try
                {
                    SetWork();
                    GoodDelete = WorkNeededDB.UpdateWork(SelectedWork);

                    if (GoodDelete)
                        DisplaySuccess("Work specifications have been deleted", title);
                    else if (!GoodDelete)
                        DisplayError("Error, work specification were not deleted", title);
                }
                catch (Exception ex)
                { DisplayError(ex.Message, title); }
            }
            else
                SetErrorPv(Tbx, IsValid.Item2);
        }
    }
}
