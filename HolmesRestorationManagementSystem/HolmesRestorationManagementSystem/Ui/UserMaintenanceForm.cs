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
    public partial class UserMaintenanceForm : Form
    {
        (bool, string) IsValid;
        string Title = "Holmes Management System";
        User usr;

        public UserMaintenanceForm()
        {
            InitializeComponent();
        }
        private void SetErrorPV(string error, int tbox)
        {
            switch (tbox)
            {
                case 0:
                    errorPv.SetError(IdTxt, error);
                    break;
                case 1:
                    errorPv.SetError(UsernameTxt, error);
                    break;
                case 2:
                    errorPv.SetError(PwdTxt, error);
                    break;
                case 3:
                    errorPv.SetError(VerifyPwdTxt, error);
                    break;
                case 4:
                    errorPv.SetError(AdminNoCB, error);
                    break;
            }
        }
        private void ClearErrorPV()
        {
            errorPv.Clear();
        }
        private void DisplayError(string errmsg, string title)
        {
            MessageBox.Show(errmsg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void DisplaySuccess(string msg, string title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private (bool, string) CheckDelete(ref int tbx)
        {
            bool valid = true;
            string msg = string.Empty;
            
            if (string.IsNullOrEmpty(IdTxt.Text))
            {
                valid = false;
                msg = "You must enter id to delete user";
                tbx = 0;
            }
            if (!int.TryParse(IdTxt.Text, out int id))
            {
                valid = false;
                msg = "Id must be numeric";
                tbx = 0;
            }

            return (valid, msg);
        }
        private (bool, string) CheckForm(ref int tbox)
        {
            bool valid = true;
            string emsg = string.Empty;

            if(string.IsNullOrEmpty(IdTxt.Text))
            {
                valid = false;
                emsg = "Id cannot be blank";
                tbox = 0;
            }
            if(string.IsNullOrEmpty(UsernameTxt.Text))
            {
                valid = false;
                emsg = "Username cannot be blank";
                tbox = 1;
            }
            if(string.IsNullOrEmpty(PwdTxt.Text))
            {
                valid = false;
                emsg = "Password cannot be blank";
                tbox = 2;
            }
            if(string.IsNullOrEmpty(VerifyPwdTxt.Text))
            {
                valid = false;
                emsg = "You must verify password";
                tbox = 3;
            }
            if(!AdminYesCB.Checked && !AdminNoCB.Checked)
            {
                valid = false;
                emsg = "You must check a value for admin status";
                tbox = 4;
            }
            if(AdminYesCB.Checked && AdminNoCB.Checked)
            {
                valid = false;
                emsg = "You cannot only select one value for admin status";
                tbox = 4;
            }
            if(!VerifyPwdTxt.Text.Equals(PwdTxt.Text))
            {
                valid = false;
                emsg = "Passwords do not match, enter matching passwords";
                tbox = 3;
            }
            if(!int.TryParse(IdTxt.Text,out int id))
            {
                valid = false;
                emsg = "Id must be numeric";
                tbox = 0;
            }

            return (valid, emsg);
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            ClearErrorPV();
            IdTxt.Text = string.Empty;
            UsernameTxt.Text = string.Empty;
            PwdTxt.Text = string.Empty;
            VerifyPwdTxt.Text = string.Empty;
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            int tbx = -1;
            IsValid = CheckForm(ref tbx);
            bool GoodAdd;

            if (IsValid.Item1)
            {
                try
                {
                    SetNewUser();
                    GoodAdd = UserDB.AddUser(usr);

                    if (GoodAdd)
                        DisplaySuccess("User has been added", Title);
                    else if (!GoodAdd)
                        DisplayError("There was a issue adding user", Title);
                }
                catch (Exception ex)
                { throw ex; }
            }
            else
                SetErrorPV(IsValid.Item2, tbx);
        }
        private void SetNewUser()
        {
            try
            {
                usr = new User();
                usr.Id = UserDB.GetNextUserId();
                usr.Username = UsernameTxt.Text.Trim();
                usr.Password = Protector.Encryptor(PwdTxt.Text.Trim());

                if (AdminYesCB.Checked)
                    usr.IsAdmin = "True";
                if (AdminNoCB.Checked)
                    usr.IsAdmin = "False";
            }
            catch(Exception ex)
            { throw ex; }
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
                    SetNewUser();
                    GoodDelete = UserDB.DeleteUser(usr.Id);

                    if (GoodDelete)
                        DisplaySuccess("User has been deleted", Title);

                    else if (!GoodDelete)
                        DisplayError("Error, user has not been deleted", Title);
                }
                catch (Exception ex)
                { DisplayError(ex.Message, Title); }
            }
            else
                SetErrorPV(IsValid.Item2, Tbx);
        }
    }
}
