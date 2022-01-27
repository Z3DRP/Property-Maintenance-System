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
    public partial class MainInterface : Form
    {
        User usr = new User();
        List<Property> AllProperties = new List<Property>();
        List<Tenant> AllTenants = new List<Tenant>();
        List<WorkNeeded> AllWork = new List<WorkNeeded>();

        public MainInterface()
        {
            InitializeComponent();
        }
        public MainInterface(User usrname)
        {
            InitializeComponent();
            usr = usrname.CopyUser();
        }

        private void HelpItem_Click(object sender, EventArgs e)
        {
            HelpScreen help = new HelpScreen();
            help.ShowDialog();
        }

        private void PropertyItem_Click(object sender, EventArgs e)
        {
            PropertyMaintenanceForm PropMaint = new PropertyMaintenanceForm();
            PropMaint.ShowDialog();
        }

        private void TenantItem_Click(object sender, EventArgs e)
        {
            TenantMaintenanceForm TenantMaint = new TenantMaintenanceForm();
            TenantMaint.ShowDialog();
        }

        private void WorkItem_Click(object sender, EventArgs e)
        {
            WorkMaintenanceForm WorkMaint = new WorkMaintenanceForm();
            WorkMaint.ShowDialog();
        }
        private void Admin_Click(object sender, EventArgs e)
        {
            AdminScreen AdminSc = new AdminScreen();
            AdminSc.ShowDialog();
        }

        private void PropertyViewItem_Click(object sender, EventArgs e)
        {
            PropertyViewForm PropertyVF = new PropertyViewForm();
            PropertyVF.ShowDialog();
        }

        private void TenantViewItem_Click(object sender, EventArgs e)
        {
            TenantViewForm TenantVF = new TenantViewForm();
            TenantVF.ShowDialog();
        }

        private void WorkViewItem_Click(object sender, EventArgs e)
        {
            WorkViewForm WorkVF = new WorkViewForm();
            WorkVF.ShowDialog();
        }

        private void MainInterface_Load(object sender, EventArgs e)
        {
            usrLbl.Text = usr.Username;
        }

        private void PropertyReportItem_Click(object sender, EventArgs e)
        {
            PropertyReportForm PropertyRF = new PropertyReportForm();
            PropertyRF.ShowDialog();
        }

        private void TenantReportItem_Click(object sender, EventArgs e)
        {
            TenantReportForm TenantRF = new TenantReportForm();
            TenantRF.ShowDialog();
        }

        private void WorkReportItem_Click(object sender, EventArgs e)
        {
            WorkReportForm WorkRF = new WorkReportForm();
            WorkRF.ShowDialog();
        }

        private void SendMessageItem_Click(object sender, EventArgs e)
        {

        }
    }
}
