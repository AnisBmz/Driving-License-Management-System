using DVLD_Business;
using DVLD_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_System
{
    public partial class UserControl_User_Details : UserControl
    {

        public UserControl_User_Details()
        {
            InitializeComponent();
        }

        public void LoadUserInfo(int userID)
        {

            clsUser user = clsUser.GetUserInfoByUserID(userID);

            if (user == null)
            {
                _ResetUserInfo();
                MessageBox.Show($"No User with ID = {userID}", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _FillUserInfo(user);

        }

        private void _FillUserInfo(clsUser user)
        {

            userControl_Person_Details.LoadPersonInfo(user.PersonID);

            LabelUserID.Text = user.UserID.ToString();

            LabelUserName.Text = user.Username;

            if (user.IsActive)
            {

                LabelIsActive.Text = "Yes";

            }
            else
            {
                LabelIsActive.Text = "No";

            }

        }

        private void _ResetUserInfo()
        {
            LabelUserID.Text = "[????]";

            LabelUserName.Text = "[????]";

            LabelIsActive.Text = "[????]";

        }
    }

}
