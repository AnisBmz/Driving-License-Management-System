using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD_Business.clsApplicationType;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_System
{
    public partial class NewInternationalLicenseApplicationForm : Form
    {

        clsLicense _License;

        clsApplicationType _ApplicationType;

        int _InternationalLicenseID = -1;

        public NewInternationalLicenseApplicationForm()
        {
            InitializeComponent();
            userControl_SearchDriverLicense1.ButtonClicked += UserControlSearchDriverLicense_ButtonSearchClicked;

        }

        private void NewInternationalLicenseApplicationForm_Load(object sender, EventArgs e)
        {

            userControl_SearchDriverLicense1.TextBoxSearchFocus();
            AcceptButton = userControl_SearchDriverLicense1.AcceptButton;
            _ApplicationType = clsApplicationType.GetApplicationTypeByID((int)clsApplicationType.enApplicationType.NewInternationalLicense);
            _LoadApplicationInfo();


        }

        private void UserControlSearchDriverLicense_ButtonSearchClicked(object sender, EventArgs e)
        {

            _License = userControl_SearchDriverLicense1.License;

            if (_License == null)
            {
                LabelLocalLicanseID.Text = "????";
                LinkLabelShowLicensesHistory.Enabled = false;
                LinkLabelShowLicenseInfo.Enabled = false;
                ButtonIssue.Enabled = false;
                return;
            }

            LinkLabelShowLicensesHistory.Enabled = true;
            LinkLabelShowLicenseInfo.Enabled = false;

            if (_CanIssueInternationalLicense())
            {
                LabelLocalLicanseID.Text = _License.LicenseID.ToString();
                ButtonIssue.Enabled = true;

            }
            else
            {
                LabelLocalLicanseID.Text = "????";
                ButtonIssue.Enabled = false;
            }

        }

        private void ButtonIssue_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you sure you want issue the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            clsApplication application = _CreateApplication();

            if (application.Save())
            {

                clsInternationalLicense internationalLicense = _CreateInternationalLicense();

                internationalLicense.ApplicationID = application.ApplicationID;


                if (internationalLicense.AddNewInternationalLicense())
                {

                    _InternationalLicenseID = internationalLicense.InternationalLicenseID;
                    LabelInterNationalLicanseApplicationID.Text = application.ApplicationID.ToString();
                    LabelInternationalLicenseID.Text = _InternationalLicenseID.ToString();
                    _UpdateFormAfterIssuedInternationalLicense();
                    MessageBox.Show($"International license issued Successfully with id = {_InternationalLicenseID}.", "License issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    application.Delete();
                }

            }

            MessageBox.Show("Failed to Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void LinkLabelShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ShowPersonLicensesHistoryForm licenseHistoryForm = new ShowPersonLicensesHistoryForm(_License.applicationInfo.ApplicationPersonID);
            licenseHistoryForm.ShowDialog();
            userControl_SearchDriverLicense1.LoadLicenseInfo(_License.LicenseID);


        }

        private void LinkLabelShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            InternationalDriverInfoForm internationalDriverInfo = new InternationalDriverInfoForm(_InternationalLicenseID);
            internationalDriverInfo.ShowDialog();

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadApplicationInfo()
        {

            LabelApplicationDate.Text = DateTime.Now.ToString("d");
            LabelIssueDate.Text = DateTime.Now.ToString("d");
            LabelFees.Text = _ApplicationType.Fees.Value.ToString("G29");
            LabelExpirationDate.Text = DateTime.Now.AddYears(1).ToString("d");
            LabelCreatedByUser.Text = clsGlobalSettings.CurrentUser.Username;
        }

        private clsApplication _CreateApplication()
        {

            clsApplication application = new clsApplication();

            application.ApplicationDate = Convert.ToDateTime(LabelApplicationDate.Text);
            application.ApplicationPersonID = _License.applicationInfo.ApplicationPersonID;
            application.ApplicationTypeID = _ApplicationType.ApplicationTypeID;
            application.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = _ApplicationType.Fees.Value;
            application.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
            return application;

        }

        private clsInternationalLicense _CreateInternationalLicense()
        {

            clsInternationalLicense internationalLicense = new clsInternationalLicense();

            internationalLicense.DriverID = _License.DriverID;
            internationalLicense.LocalLicenseID = _License.LicenseID;
            internationalLicense.IssueDate = DateTime.Now;
            internationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            internationalLicense.IsActive = true;
            internationalLicense.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

            return internationalLicense;

        }

        private void _UpdateFormAfterIssuedInternationalLicense()
        {

            ButtonIssue.Enabled = false;
            userControl_SearchDriverLicense1.GroupBoxSearchEnabled = false;
            LinkLabelShowLicenseInfo.Enabled = true;

        }

        private bool _CanIssueInternationalLicense()
        {

            int interNationalLicenseID = clsInternationalLicense.CheckPersonHaveActiveInternationalLicense(_License.applicationInfo.ApplicationPersonID);

            if (interNationalLicenseID != -1)
            {
                LinkLabelShowLicenseInfo.Enabled = true;
                _InternationalLicenseID = interNationalLicenseID;
                MessageBox.Show($"This person already has an active international license with ID = {interNationalLicenseID}.",
                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_License.LicenseClassID != 3)
            {
                MessageBox.Show("The selected license must be class 3 to Issue an international License.",
                                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!_License.IsActive)
            {
                MessageBox.Show("Selected license is not active",
                                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_License.IsDetained)
            {
                MessageBox.Show("Selected license is detained.",
                                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_License.IsExpiredLicense())
            {
                MessageBox.Show($"Selected license is expired, It expired on: {_License.ExpirationDate:d}",
                                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}
