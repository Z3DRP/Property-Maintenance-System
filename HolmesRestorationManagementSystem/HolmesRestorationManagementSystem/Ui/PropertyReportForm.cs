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
    public partial class PropertyReportForm : Form
    {
        public PropertyReportForm()
        {
            InitializeComponent();
        }

        private void PropertyReportForm_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
