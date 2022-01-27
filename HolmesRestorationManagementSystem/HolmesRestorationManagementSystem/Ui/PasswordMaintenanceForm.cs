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
    public partial class PasswordMaintenanceForm : Form
    {
        User usr;
        string title = "Holmes Management System";

        public PasswordMaintenanceForm()
        {
            InitializeComponent();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
        private void ClearForm()
        {
            UsernameTxt.Text = string.Empty;
            NewPwdTxt.Text = string.Empty;
            VerifyPwdTxt.Text = string.Empty;
        }
        private void SetErrorPv(string msg, int widgetIndx)
        {
            switch(widgetIndx)
            {
                case 0:
                    errorPv.SetError(UsernameTxt, msg);
                    break;
                case 1:
                    errorPv.SetError(NewPwdTxt, msg);
                    break;
                case 2:
                    errorPv.SetError(VerifyPwdTxt, msg);
                    break;
            }
        }
        private void ResetErrorPv()
        {
            errorPv.Clear();
        }
        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            bool verifiedUser;
            bool PasswordChanged;
            try
            {
                SetUser();
                verifiedUser = CheckUsername(usr.Username);
                
                if (verifiedUser)
                {
                    PasswordChanged = UserDB.UpdateUserPassword(usr);

                    if (PasswordChanged)
                        DisplaySuccess("Password has been changed", title);
                    if (!PasswordChanged)
                        DisplayError("Error, password was not changed", title);
                }
            }
            catch(Exception ex)
            { DisplayError(ex.Message, title); }
        }
        private (bool,string) CheckForm(ref int Tbx)
        {
            bool valid = true;
            string msg = string.Empty;

            if (string.IsNullOrEmpty(UsernameTxt.Text))
            {
                valid = false;
                msg = "You must enter a username";
                Tbx = 0;
            }
            else if (string.IsNullOrEmpty(NewPwdTxt.Text))
            {
                valid = false;
                msg = "You must enter a password";
                Tbx = 1;
            }
            else if (string.IsNullOrEmpty(VerifyPwdTxt.Text))
            {
                valid = false;
                msg = "You must verify your password";
                Tbx = 2;
            }
            if (VerifyPwdTxt.Text != NewPwdTxt.Text)
            {
                valid = false;
                msg = "Passwords do not match";
                Tbx = 2;
            }

            return (valid, msg);
        }
        private void SetUser()
        {
            usr = new User();
            usr.Username = UsernameTxt.Text.Trim();
            usr.Password = NewPwdTxt.Text;
        }
        private void DisplaySuccess(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void DisplayError(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private bool CheckUsername(string username)
        {
            bool userFound = false;
            
            try
            {
                userFound = UserDB.FindUsername(username);
            }
            catch(Exception ex)
            { throw ex; }

            return userFound;
        }
    }
}
