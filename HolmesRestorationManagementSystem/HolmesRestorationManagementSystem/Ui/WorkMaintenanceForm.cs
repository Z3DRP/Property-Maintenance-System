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
    public partial class WorkMaintenanceForm : Form
    {
        int CellsChanged = 0;
        int RowIdx;
        int ColumnIdx;
        string OldCellValue = null;
        string title = "Holmes Management System";
        bool CellChanged = false;
        (bool, string) IsValid;
        WorkNeeded CurrentWork;
        WorkNeeded SelectedWork = new WorkNeeded();
        List<Property> PropertiesInfo = new List<Property>();
        List<WorkNeeded> AllWorks = new List<WorkNeeded>();

        public WorkMaintenanceForm()
        {
            InitializeComponent();
        }
        private void DisplaySuccess(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DisplayError(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private (bool,string) CheckForm(ref int tbx)
        {
            bool valid = true;
            string emsg = string.Empty;

            if (string.IsNullOrEmpty(WorkIdTxt.Text))
            {
                valid = false;
                emsg = "Id cannot be blank";
                tbx = 0;
            }
            else if (string.IsNullOrEmpty(AddressTxt.Text))
            {
                valid = false;
                emsg = "Address cannot be blank";
                tbx = 1;
            }
            else if (PriorityLevelCB.SelectedIndex <= 0)
            {
                valid = false;
                emsg = "You must select a priority level";
                tbx = 3;
            }
            else if (String.IsNullOrEmpty(WorkTxt.Text))
            {
                valid = false;
                emsg = "Work needed cannot be blank";
                tbx = 4;
            }

            return (valid, emsg);
        }
        private (bool, string) CheckSearch(ref int tbx, ref string searchType)
        {
            bool valid = true;
            string emsg = string.Empty;

            if (string.IsNullOrEmpty(WorkIdTxt.Text) && string.IsNullOrEmpty(AddressTxt.Text) && string.IsNullOrEmpty(WorkTxt.Text))
            {
                valid = false;
                emsg = "You must have id, Address or work to search";
                tbx = 0;
            }
            if (!string.IsNullOrEmpty(WorkIdTxt.Text) && string.IsNullOrEmpty(AddressTxt.Text) && string.IsNullOrEmpty(WorkTxt.Text))
                searchType = "id";
            else if (string.IsNullOrEmpty(WorkIdTxt.Text) && !string.IsNullOrEmpty(AddressTxt.Text) && string.IsNullOrEmpty(WorkTxt.Text))
                searchType = "add";
            else if (string.IsNullOrEmpty(WorkIdTxt.Text) && string.IsNullOrEmpty(AddressTxt.Text) && !string.IsNullOrEmpty(WorkTxt.Text))
                searchType = "work";

            return (valid, emsg);
        }
        private (bool, string) CheckDelete(ref int tbx)
        {
            bool valid = true;
            string emsg = string.Empty;

            if (string.IsNullOrEmpty(WorkIdTxt.Text))
            {
                valid = false;
                emsg = "You must have id to delete";
                tbx = 0;
            }

            return (valid, emsg);
        }
        private void SetErrorPv(string msg, int tbx)
        {
            switch (tbx)
            {
                case 0:
                    errorPv.SetError(WorkIdTxt, msg);
                    break;
                case 1:
                    errorPv.SetError(AddressTxt, msg);
                    break;
                case 2:
                    errorPv.SetError(CompletionDateDP, msg);
                    break;
                case 3:
                    errorPv.SetError(PriorityLevelCB, msg);
                    break;
                case 4:
                    errorPv.SetError(WorkTxt, msg);
                    break;
            }
        }
        private void ResetErrorPv()
        {
            errorPv.Clear();
        }

        private void WorkMaintenanceForm_Load(object sender, EventArgs e)
        {
            SetPrioerityCB();
            PropertiesInfo = PropertyDB.GetPropertyInfo();
        }
        private void SetPrioerityCB()
        {
            var PriorityStatus = new BindingList<KeyValuePair<int, string>>();

            PriorityStatus.Add(new KeyValuePair<int, string>(0, "Select Priority Level"));
            PriorityStatus.Add(new KeyValuePair<int, string>(1, "1 - Low"));
            PriorityStatus.Add(new KeyValuePair<int, string>(2, "2 - Mid"));
            PriorityStatus.Add(new KeyValuePair<int, string>(3, "3 - High"));
            PriorityStatus.Add(new KeyValuePair<int, string>(4, "4 - Immediate"));

            PriorityLevelCB.DataSource = PriorityStatus;
            PriorityLevelCB.DisplayMember = "Value";
            PriorityLevelCB.ValueMember = "Key";
            PriorityLevelCB.SelectedIndex = 0;
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
                    CurrentWork = new WorkNeeded();
                    SetWork(false);
                    GoodAdd = WorkNeededDB.AddWork(CurrentWork);

                    if (GoodAdd)
                        DisplaySuccess("Work has been added", title);
                    else if (!GoodAdd)
                        DisplayError("Error, work was not added", title);
                }
                catch (Exception ex)
                { DisplayError(ex.Message, title); }
            }
            else
                SetErrorPv(IsValid.Item2, Tbx);
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                AllWorks = WorkNeededDB.GetAllWork();
                WorkDG.DataSource = AllWorks;

                if (AllWorks.Count == 0)
                    DisplaySuccess("There is currently no work", title);
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
                    CurrentWork = new WorkNeeded();

                    switch(searchType)
                    {
                        case "id":
                            CurrentWork.Work_Id = Convert.ToInt32(WorkIdTxt.Text);
                            AllWorks[0] = WorkNeededDB.GetWork(CurrentWork.Work_Id);
                            break;
                        case "add":
                            CurrentWork.Property_Id = FindPropertyId(AddressTxt.Text);
                            AllWorks = WorkNeededDB.GetPropertyWork(CurrentWork.Property_Id);
                            break;
                        case "work":
                            CurrentWork.Work_Needed = WorkTxt.Text.Trim();
                            AllWorks = WorkNeededDB.SearchWork(CurrentWork.Work_Needed);
                            break;
                    }

                    if (AllWorks.Count > 0)
                        WorkDG.DataSource = AllWorks;
                    else
                    {
                        DisplayError("Match not found", title);
                        AllWorks = WorkNeededDB.GetAllWork();
                        WorkDG.DataSource = AllWorks;
                    }
                }
                catch(Exception ex)
                { DisplayError(ex.Message,title); }
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            bool GoodUpdate;
            int Tbx = -1;
            IsValid = CheckForm(ref Tbx);
            if (IsValid.Item1)
            {
                try
                {
                    CurrentWork = new WorkNeeded();
                    SetWork(true);
                    GoodUpdate = WorkNeededDB.UpdateWork(CurrentWork);

                    if (GoodUpdate)
                        DisplaySuccess("Work has been updated", title);
                    else if (!GoodUpdate)
                        DisplayError("Error, work was not updated", title);
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
                    CurrentWork = new WorkNeeded();
                    SetWork(false);
                    GoodDelete = WorkNeededDB.DeleteWork(CurrentWork);

                    if (GoodDelete)
                        DisplaySuccess("Work has been deleted", title);
                    else if (!GoodDelete)
                        DisplayError("Error, work was not deleted", title);
                }
                catch (Exception ex)
                { DisplayError(ex.Message, title); }
            }
            else
                SetErrorPv(IsValid.Item2,Tbx);
        }
        private void SetWork(bool isUpdate)
        {
            int propertyId;
            int nextWorkId;
            try
            {
                if (!isUpdate)
                {
                    nextWorkId = WorkNeededDB.GetNextWorkId();
                    CurrentWork.Work_Id = nextWorkId;
                }
                if (isUpdate)
                    CurrentWork.Work_Id = Convert.ToInt32(WorkIdTxt.Text);

                propertyId = WorkNeededDB.GetPropertyId(CurrentWork.Work_Id);
                CurrentWork.Property_Id = propertyId;
                CurrentWork.Desired_Completion_Date = CompletionDateDP.Value;
                CurrentWork.Priority_Level = Convert.ToInt32(PriorityLevelCB.SelectedValue);
                CurrentWork.Work_Needed = WorkTxt.Text.Trim();
            }
            catch(Exception ex)
            { throw ex; }
        }
        private void ClearForm()
        {
            DateTime Today = DateTime.Today;
            WorkIdTxt.Text = string.Empty;
            AddressTxt.Text = string.Empty;
            CompletionDateDP.Value = Today;
            PriorityLevelCB.SelectedIndex = 0;
            WorkTxt.Text = string.Empty;
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
            WorkDG.DataSource = null;
        }

        private void WorkDG_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (WorkDG.CurrentCell.ColumnIndex > 0)
            {
                WorkDG.EditMode = DataGridViewEditMode.EditProgrammatically;
                WorkDG.BeginEdit(true);
            }
            else
                WorkDG.ReadOnly = true;
        }

        private void WorkDG_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CellsChanged++;
        }

        private void WorkDG_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (CellChanged)
            {
                try
                {
                    bool GoodEdit = WorkNeededDB.UpdateWork(SelectedWork);

                    if (GoodEdit)
                        DisplaySuccess("Work has been edited", title);
                    else if (!GoodEdit)
                        DisplayError("Error, Work was not edited", title);
                }
                catch(Exception ex)
                { DisplayError(ex.Message, title); }

                // reset for next line edits
                CellChanged = false;
            }
            
        }



        private void WorkDG_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (CellsChanged >= 1)
            {
                try
                {
                    DateTime cDate;
                    switch (ColumnIdx)
                    {
                        case 0:
                            SelectedWork.Work_Id = Convert.ToInt32(OldCellValue);
                            DisplayError("Work Id number cannot be edited", title);
                            break;
                        case 1:
                            SelectedWork.Property_Id = 
                                Convert.ToInt32(WorkDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value);
                            break;
                        case 2:
                            cDate = CompletionDateDP.Value;
                            SelectedWork.Desired_Completion_Date = cDate;
                            break;
                        case 3:
                            SelectedWork.Priority_Level = Convert.ToInt32(PriorityLevelCB.SelectedValue);
                            break;
                        case 4:
                            SelectedWork.Work_Needed = WorkDG.SelectedRows[RowIdx].Cells[ColumnIdx].Value.ToString();
                            break;
                    }
                    
                }
                catch(Exception ex)
                { throw ex; }
            }
        }

        private void WorkDG_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            RowIdx = WorkDG.CurrentCell.RowIndex;
            ColumnIdx = WorkDG.CurrentCell.ColumnIndex;
            OldCellValue = WorkDG.CurrentCell.Value.ToString();
        }
        private int GetPropertyId(int workId)
        {
            int propId;
            try
            {
                propId = WorkNeededDB.GetWorkProperty(workId);
            }
            catch(Exception ex)
            { throw ex; }

            return propId;
        }
        private string FindAddress(int propId)
        {
            string address = string.Empty;
            bool found = false;
            int currentId;
            try
            {

                for (int p = 0; p <= PropertiesInfo.Count && !found; p++)
                {
                    currentId = PropertiesInfo[p].Property_Id;
                    if (currentId == propId)
                    {
                        found = true;
                        address = PropertiesInfo[p].Address;
                    }
                }
            }
            catch (Exception ex)
            { throw ex; }

            return address;
        }
        private int FindPropertyId(string address)
        {
            string add = string.Empty;
            bool found = false;
            int id;
            try
            {
                for (int addrs = 0; addrs <= PropertiesInfo.Count && !found; addrs++)
                {
                    add = PropertiesInfo[addrs].Address;
                    if (add == address)
                    {
                        found = true;
                        id = PropertiesInfo[addrs].Property_Id;
                    }
                }
            }
            catch (Exception ex)
            { throw ex; }

            return id;
        }
    }
}
