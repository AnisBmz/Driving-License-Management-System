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
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
        }

        private void FillCredentials()
        {

            string username = ""; string password = ""; bool rememberMe = false;
            clsUtil.LoadRememberMeCredentials(ref username, ref password, ref rememberMe);
            TextBoxUsername.Text = username;
            TextBoxPassword.Text = password;
            CheckBoxRememberMe.Checked = rememberMe;


        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {

            clsUser user = clsUser.FindUserByUsernameAndPassword(TextBoxUsername.Text.Trim(), TextBoxPassword.Text.Trim());

            if (user != null)
            {

                if (user.IsActive)
                {

                    clsGlobalSettings.CurrentUser = clsUser.GetUserInfoByUserID(user.UserID);

                    clsUtil.SaveCredentialsIfRememberMe(TextBoxUsername.Text.Trim(), TextBoxPassword.Text.Trim(),
                        CheckBoxRememberMe.Checked);

                    this.Hide();

                    MainForm main = new MainForm();
                    main.ShowDialog();


                    this.Show();
                    FillCredentials();


                }
                else
                {

                    TextBoxUsername.Select(); 
                    MessageBox.Show("Your account is deactivated please contact your Admin.", "Deactivated Account", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            else
            {

                TextBoxUsername.Select();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void LoginForm_Load(object sender, EventArgs e)  
        {
            string appVersion = Application.ProductVersion;
            LabelVirsion.Text = appVersion;
            FillCredentials();


        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {

            this.Close();

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

        private void LoginForm_Activated(object sender, EventArgs e)
        {

            TextBoxUsername.Focus();
            TextBoxUsername.SelectionStart = TextBoxUsername.TextLength;

        }
    }
}
