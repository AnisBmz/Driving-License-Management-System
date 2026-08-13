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
    public partial class AddEditUserForm : Form
    {

        enum enMode { AddNewUser, UpdateUser };

        enMode _Mode = enMode.AddNewUser;

        clsUser _User;

        int _UserID = -1;

        public AddEditUserForm(int userID)
        {

            InitializeComponent();

            _UserID = userID;

            _Mode = enMode.UpdateUser;

        }

        public AddEditUserForm()
        {

            InitializeComponent();
            _Mode = enMode.AddNewUser;


        }

        private void AddNewUserForm_Load(object sender, EventArgs e)
        {

            _ResetDefaultValues();

            if (_Mode == enMode.UpdateUser)
            {

                _LoadUserData();

            }

        }

        private void TextBoxConfirmPassword_Validating(object sender, CancelEventArgs e)
        {

            if (TextBoxPassword.Text != TextBoxConfirmPassword.Text)
            {

                ErrorProviderConfirmPassword.SetError(TextBoxConfirmPassword, "Password confirmation does not match Password!");

            }
            else
            {

                ErrorProviderConfirmPassword.SetError(TextBoxConfirmPassword, string.Empty);


            }

        }

        private void Blank_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {

                errorProviderBlank.SetError(((TextBox)sender), "Field cannot be blank");

            }
            else
            {

                errorProviderBlank.SetError(((TextBox)sender), string.Empty);


            }

        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {

            int personID = userControl_Search_Person1.PersonID;

            if (_Mode == enMode.AddNewUser)
            {

                if (!clsUser.IsPersonUser(personID) && clsPerson.IsPersonExists(personID))
                {


                    ButtonSave.Enabled = true;
                    TabControlAddNewUser.SelectedIndex = 1;
                    TabPageLoginInfo.Enabled = true;
                    TextBoxUserName.Select();

                }
                else if (clsUser.IsPersonUser(personID))
                {

                    MessageBox.Show("Selected Person already has a _User, choose another one", "Select another person", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
                else if (!clsPerson.IsPersonExists(personID))
                {

                    MessageBox.Show("You didn't Select Any person", "Select person", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }

            }
            else
            {

                ButtonSave.Enabled = true;
                TabControlAddNewUser.SelectedIndex = 1;

            }

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

            if (!_ValidateChildrenForSave())
            {

                return;

            }

            if (clsUser.IsUsernameExists(TextBoxUserName.Text.Trim(), _User.Username, _Mode == enMode.UpdateUser))
            {

                MessageBox.Show("This UserName is already taken!", "UserName Exists", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;


            }

            _ReadUserInfo();

            if (_IsCurrentUserDeactivationAttempt())
            {
                MessageBox.Show("The current account cannot be deactivated.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (_User.Save())
            {

                clsUtil.ValidateAndClearRememberMeData(_User, clsGlobalSettings.CurrentUser);
                _SwitchToUpdateUserForm();
                LabelUserID.Text = _User.UserID.ToString();
                _Mode = enMode.UpdateUser;
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("Data Save Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }



        }
         
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ReadUserInfo()
        {
            _User.PersonID = userControl_Search_Person1.PersonID;
            _User.Username = TextBoxUserName.Text;
            _User.Password = TextBoxPassword.Text;
            _User.IsActive = CheckBoxIsActive.Checked;

        }

        private void _SwitchToUpdateUserForm()
        {

            LabelTitle.Text = "Update User";
            this.Text = "Update User";
            userControl_Search_Person1.GroupBoxFilter_Enable = false;

        }

        private void _LoadUserData()
        {
            _User = clsUser.GetUserInfoByUserID(_UserID);

            if (_User == null)
            {

                MessageBox.Show($"No User with ID = {_UserID}", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;

            }

            LabelUserID.Text = _User.UserID.ToString();
            TextBoxUserName.Text = _User.Username;
            TextBoxPassword.Text = _User.Password;
            TextBoxConfirmPassword.Text = _User.Password;
            CheckBoxIsActive.Checked = _User.IsActive;
            userControl_Search_Person1.LoadPersonInfo(_User.PersonID);


        }

        private void _ResetDefaultValues()
        {


            if (_Mode == enMode.AddNewUser)
            {

                _User = new clsUser();
                TabPageLoginInfo.Enabled = false;

            }
            else
            {

                _SwitchToUpdateUserForm();
                TabPageLoginInfo.Enabled = true;
                ButtonSave.Enabled = true;

            }

        }

        private bool _ValidateChildrenForSave()
        {

            this.ValidateChildren();

            if (!string.IsNullOrEmpty(errorProviderBlank.GetError(TextBoxUserName)) ||
                !string.IsNullOrEmpty(errorProviderBlank.GetError(TextBoxPassword)) ||
                !string.IsNullOrEmpty(ErrorProviderConfirmPassword.GetError(TextBoxConfirmPassword)))
            {
                MessageBox.Show("Some fields are not valid!, please check the red icons.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private bool _IsCurrentUserDeactivationAttempt()
        {
            return _User.UserID == clsGlobalSettings.CurrentUser.UserID && !_User.IsActive;


        }

    }
}
