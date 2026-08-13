using DVLD_Business;
using DVLD_System.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_System
{
    public partial class ChangePasswordForm : Form
    {

        int _UserID = -1;

        clsUser _User;

        public ChangePasswordForm(int userID)
        {
            InitializeComponent();
            _UserID = userID;
        }

        private void ChangePasswordFrom_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            _User = clsUser.GetUserInfoByUserID(_UserID);

            if (_User == null)
            {

                MessageBox.Show($"No User with ID = {_UserID}", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;

            }

            userControl_User_Details.LoadUserInfo(_UserID);

        }

        private void TextBoxCurrentPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TextBoxCurrentPassword.Text.Trim()))
            {

                ErrorProviderCurrentPassword.SetError((TextBoxCurrentPassword), "Field cannot be blank");

            }
            else
            {

                if (TextBoxCurrentPassword.Text.Trim() != _User.Password)
                {


                    ErrorProviderCurrentPassword.SetError((TextBoxCurrentPassword), "Current password is wrong!");


                }
                else
                {

                    ErrorProviderCurrentPassword.SetError((TextBoxCurrentPassword), string.Empty);


                }


            }

        }

        private void TextBoxNewPassword_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TextBoxNewPassword.Text.Trim()))
            {

                ErrorProviderNewPassword.SetError((TextBoxNewPassword), "Field cannot be blank");

            }
            else
            {

                ErrorProviderNewPassword.SetError((TextBoxNewPassword), string.Empty);


            }

        }

        private void TextBoxConfirmPassword_Validating(object sender, CancelEventArgs e)
        {

            if (TextBoxNewPassword.Text.Trim() != TextBoxConfirmPassword.Text.Trim())
            {

                ErrorProviderConfirmPassword.SetError(TextBoxConfirmPassword, "Password confirmation does not match New Password!");

            }
            else
            {

                ErrorProviderConfirmPassword.SetError(TextBoxConfirmPassword, string.Empty);


            }

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

            if (!_ValidateChildrenForSave())
            {
                return;
            }

            _User.Password = TextBoxNewPassword.Text;

            if (_User.Save())
            {

                clsUtil.ValidateAndClearRememberMeData(_User, clsGlobalSettings.CurrentUser);
                MessageBox.Show("Password changed successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();

            }
            else
            {

                MessageBox.Show("Password change failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool _ValidateChildrenForSave()
        {

            this.ValidateChildren();

            if (!string.IsNullOrEmpty(ErrorProviderCurrentPassword.GetError(TextBoxCurrentPassword)) ||
                !string.IsNullOrEmpty(ErrorProviderNewPassword.GetError(TextBoxNewPassword)) ||
                !string.IsNullOrEmpty(ErrorProviderConfirmPassword.GetError(TextBoxConfirmPassword)))
            {
                MessageBox.Show("Some fields are not valid!, please check the red icons.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void _ResetDefaultValues()
        {

            TextBoxCurrentPassword.Text = string.Empty;
            TextBoxConfirmPassword.Text = string.Empty;
            TextBoxNewPassword.Text = string.Empty;
            TextBoxCurrentPassword.Select();

        }

    }
}
