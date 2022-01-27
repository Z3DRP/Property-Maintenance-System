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
    public partial class SplashScreen : Form
    {
        int _ticks;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            _ticks++;

            if (_ticks == 15)
            {
                timer.Stop();
                this.Close();
            }
        }
    }
}
