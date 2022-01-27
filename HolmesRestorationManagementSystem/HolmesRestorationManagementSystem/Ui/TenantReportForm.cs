using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolmesRestorationManagementSystem.Ui
{
    public partial class TenantReportForm : Form
    {
        public TenantReportForm()
        {
            InitializeComponent();
        }

        private void TenantReportForm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
