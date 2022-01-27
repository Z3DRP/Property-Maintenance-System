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
    public partial class LoginForm : Form
    {
        (bool, string) isValid;
        string title = "Holmes Management System";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            SplashScreen Splash = new SplashScreen();
            Splash.ShowDialog();
        }
        private (bool, string) CheckForm(ref int tbox)
        {
            bool valid = true;
            string err = string.Empty;

            if(string.IsNullOrEmpty(usernameTxt.Text))
            {
                valid = false;
                err = "Username cannot be blank";
                tbox = 0;
            }
            if(string.IsNullOrEmpty(passwordTxt.Text))
            {
                valid = false;
                err = "Password cannot be blank";
                tbox = 1;
            }
            return (valid, err);
        }
        private void SetErrorPV(string error, int tbox)
        {
            switch(tbox)
            {
                case 0:
                    errorPv.SetError(usernameTxt, error);
                    break;
                case 1:
                    errorPv.SetError(passwordTxt, error);
                    break;
            }
        }
        private void ClearErrorPV()
        {
            errorPv.Clear();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            int tbx = -1;
            isValid = CheckForm(ref tbx);
            bool foundUsr;
            bool pwdMatch;

            if (isValid.Item1)
            {
                try
                {
                    User usrlogin = new User();
                    User storedUsr = new User();

                    usrlogin.Username = usernameTxt.Text.Trim();
                    usrlogin.Password = passwordTxt.Text.Trim();
                    foundUsr = UserDB.FindUsername(usrlogin.Username);

                    if (foundUsr)
                    {
                        storedUsr = UserDB.GetUserPassword(usrlogin.Username);
                        pwdMatch = Protector.Compare(storedUsr.Password, usrlogin.Password);

                        if (pwdMatch)
                        {
                            MainInterface mInterface = new MainInterface(usrlogin);
                            mInterface.ShowDialog();
                        }
                        else
                            SetErrorPV("Invalid password", 1);
                    }
                    else
                        SetErrorPV("Invalid Username", 0);

                }
                catch(Exception ex)
                { DisplayError(ex.Message, title); }
            }
            else
                SetErrorPV(isValid.Item2, tbx);
        }
        private void DisplayError(string errmsg, string title)
        {
            MessageBox.Show(errmsg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void DisplaySuccess(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
