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
    public partial class EditPropertyWorkForm : Form
    {
        List<WorkNeeded> PropertyWork = new List<WorkNeeded>();
        WorkNeeded Work = new WorkNeeded();
        string title = "Holmes Mamagement System";
        string Address = null;
        bool TextChanged = false;
        int RowIdx;
        int ColumnIdx;

        public EditPropertyWorkForm()
        {
            InitializeComponent();
        }
        public EditPropertyWorkForm(List<WorkNeeded> workList, string address)
        {
            PropertyWork = workList;
            Address = address;
        }
        private void DisplaySuccess(string msg, string title)
        { MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information); }
        private void DisplayError(string msg, string title)
        { MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        // might havve to add a double click event to turn cell editmode on but might not
        private void WorkDG_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            bool GoodUpdate;

            try
            {
                if (TextChanged)
                {
                    GoodUpdate = WorkNeededDB.UpdateWork(Work);

                    if (GoodUpdate)
                        DisplaySuccess("Work has been edited", title);

                    else if (!GoodUpdate)
                        DisplayError("Error, work was not edited", title);
                }
            }
            catch(Exception ex)
            { DisplayError(ex.Message, title); }

            //rest for any edits in next row
            TextChanged = false;
        }

        private void WorkDG_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            RowIdx = WorkDG.CurrentCell.RowIndex;
            ColumnIdx = WorkDG.CurrentCell.ColumnIndex;
            TextChanged = true;
            SetWorkItem();
        }
        private void SetWorkItem()
        {
            string CDate;

            try
            {
                switch (ColumnIdx)
                {
                    case 0:
                        Work.Work_Id = Convert.ToInt32(WorkDG.CurrentCell.Value);
                        break;
                    case 1:
                        Work.Property_Id = Convert.ToInt32(WorkDG.CurrentCell.Value);
                        break;
                    case 2:
                        Work.Work_Needed = WorkDG.CurrentCell.Value.ToString();
                        break;
                    case 3:
                        CDate = WorkDG.CurrentCell.Value.ToString();
                        DateTime.TryParse(CDate, out DateTime cdate);
                        Work.Desired_Completion_Date = cdate;
                        break;
                    case 4:
                        Work.Priority_Level = Convert.ToInt32(WorkDG.CurrentCell.Value);
                        break;
                }
            }
            catch(Exception ex)
            { throw ex; }
        }

        private void EditPropertyWorkForm_Load(object sender, EventArgs e)
        {
            addressLBL.Text = Address;
            WorkDG.DataSource = PropertyWork;
        }
    }
}
