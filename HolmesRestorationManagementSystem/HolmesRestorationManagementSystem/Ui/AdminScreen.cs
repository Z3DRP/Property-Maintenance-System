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
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            UserMaintenanceForm UserF = new UserMaintenanceForm();
            UserF.ShowDialog();
        }

        private void ChangeItem_Click(object sender, EventArgs e)
        {
            PasswordMaintenanceForm passwordF = new PasswordMaintenanceForm();
            passwordF.ShowDialog();
        }
    }
}
