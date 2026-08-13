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
    public partial class MainForm : Form
    {

        bool _IsSignOut = false;

        public MainForm()
        {
            InitializeComponent();
        }

        private void PeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ManagePeopleForm managePeople = new ManagePeopleForm();
            managePeople.ShowDialog();

        }

        private void SignOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            clsGlobalSettings.CurrentUser = null;
            _IsSignOut = true;
            this.Close();


        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (e.CloseReason == CloseReason.UserClosing && !_IsSignOut)
            {

                Application.Exit();

            }
           

        }

        private void UsersToolStripMenuItem_Click(object sender, EventArgs e)
        {


            ManageUsersForm manageUsers = new ManageUsersForm();
            manageUsers.ShowDialog();
            _IsSignOut = manageUsers.IsSignOut;
            if (_IsSignOut)
            {
                this.Close();
            }


        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ChangePasswordForm changePasswordFrom = new ChangePasswordForm(clsGlobalSettings.CurrentUser.UserID);
            changePasswordFrom.ShowDialog();

        }

        private void CurrentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            UserDetailsForm userDetailsForm = new UserDetailsForm(clsGlobalSettings.CurrentUser.UserID);
            userDetailsForm.ShowDialog();

        }

        private void ApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ManageApplicationTypesForm manageApplicationTypesForm = new ManageApplicationTypesForm();
            manageApplicationTypesForm.ShowDialog();

        }

        private void ManageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ManageTestTypesForm manageTestTypesForm = new ManageTestTypesForm();
            manageTestTypesForm.ShowDialog();

        }

        private void LocalDrivingLToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ManageLocalDrivingLicenseApplicationsForm localDrivingLicenseApplicationsForm = new ManageLocalDrivingLicenseApplicationsForm();
            localDrivingLicenseApplicationsForm.ShowDialog();

        }

        private void LocalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddUpdateLocalDrivingLicenseApplicationForm newLocalDrivingLicenseApplication = new AddUpdateLocalDrivingLicenseApplicationForm();
            newLocalDrivingLicenseApplication.ShowDialog();

        }

        private void DriversToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ManageDriversForm manageDriversForm = new ManageDriversForm();
            manageDriversForm.ShowDialog();

        }

        private void InternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            NewInternationalLicenseApplicationForm newInternationalLicenseApplicationForm = new NewInternationalLicenseApplicationForm();
            newInternationalLicenseApplicationForm.ShowDialog();

        }

        private void ManageInternationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ManageInternationalLicenseApplicationsForm manageInternationalLicenseApplicationsForm = new ManageInternationalLicenseApplicationsForm();
            manageInternationalLicenseApplicationsForm.ShowDialog();

        }

        private void RenewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            RenewLocalDrivingLicenseForm renewLocalDrivingLicenseForm = new RenewLocalDrivingLicenseForm();
            renewLocalDrivingLicenseForm.ShowDialog();

        }

        private void ReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ReplacementForLostOrDamagedLicenseForm replacementForLostOrDamagedLicense = new ReplacementForLostOrDamagedLicenseForm();
            replacementForLostOrDamagedLicense.ShowDialog();

        }

        private void DetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DetainLicenseForm detainLicense = new DetainLicenseForm();
            detainLicense.ShowDialog();


        }

        private void ManageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ManageDetainedLicensesForm manageDetainedLicenses = new ManageDetainedLicensesForm();
            manageDetainedLicenses.ShowDialog();

        }

        private void ReleaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ReleaseDetainedLicenseForm ReleaseDetainedLicense = new ReleaseDetainedLicenseForm();
            ReleaseDetainedLicense.ShowDialog();

        }

        private void ReleaseDetainedToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ReleaseDetainedLicenseForm ReleaseDetainedLicense = new ReleaseDetainedLicenseForm();
            ReleaseDetainedLicense.ShowDialog();

        }

        private void RetakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ManageLocalDrivingLicenseApplicationsForm manageLocalDrivingLicenseApplications = new ManageLocalDrivingLicenseApplicationsForm();
            manageLocalDrivingLicenseApplications.ShowDialog();

        }
    }
}
