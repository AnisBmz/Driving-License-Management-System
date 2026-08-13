using DVLD_Business;
using DVLD_System.Licenses.Local_License;
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
    public partial class ReleaseDetainedLicenseForm : Form
    {

        enum enFormStatus { SearchBeforeRelease, ReleaseDirectly}

        enFormStatus FormStatus = enFormStatus.SearchBeforeRelease;

        int _LicenseID = -1;

        clsLicense _License;

        clsApplicationType _ApplicationType;

        public ReleaseDetainedLicenseForm(int licenseID)
        {
            InitializeComponent();
            _LicenseID = licenseID;
            if (_LicenseID != -1)
            {
                FormStatus = enFormStatus.ReleaseDirectly;
            }

        }

        public ReleaseDetainedLicenseForm()
        {
            InitializeComponent();
            userControl_SearchDriverLicense1.ButtonClicked += UserControlSearchDriverLicense_ButtonSearchClicked;
            FormStatus = enFormStatus.SearchBeforeRelease;
        }

        private void ReleaseDetainedLicenseForm_Load(object sender, EventArgs e)
        {

            _ApplicationType = GetApplicationTypeByID((int) enApplicationType.ReleaseDetainedDrivingLicense);
            _LoadEmptyReleaseLicenseInfo();

            if (FormStatus == enFormStatus.SearchBeforeRelease)
            {
                AcceptButton = userControl_SearchDriverLicense1.AcceptButton;
                userControl_SearchDriverLicense1.TextBoxSearchFocus();
                return;
            }

            userControl_SearchDriverLicense1.LoadLicenseInfo(_LicenseID);
            _License = userControl_SearchDriverLicense1.License;
            _LoadDetainedLicenseInfo();
            userControl_SearchDriverLicense1.GroupBoxSearchEnabled = false;
            ButtonRelease.Enabled = true;
            LinkLabelShowLicensesHistory.Enabled = true;
            LinkLabelShowLicenseInfo.Enabled = true;
            LabelLicenseID.Text = _LicenseID.ToString();

        }

        private void UserControlSearchDriverLicense_ButtonSearchClicked(object sender, EventArgs e)
        {

            _License = userControl_SearchDriverLicense1.License;

            if (_License == null)
            {
                _LoadEmptyDetainedLicenseInfo();
                _LoadEmptyReleaseLicenseInfo();
                LinkLabelShowLicensesHistory.Enabled = false;
                LinkLabelShowLicenseInfo.Enabled = false;
                ButtonRelease.Enabled = false;
                return;
            }

            _LicenseID = _License.LicenseID;
            LinkLabelShowLicensesHistory.Enabled = true;
            LinkLabelShowLicenseInfo.Enabled = true;

            if (_CanReleasedLicense())
            {
                _LoadDetainedLicenseInfo();
                ButtonRelease.Enabled = true;

            }
            else
            {
                _LoadEmptyDetainedLicenseInfo();
                _LoadEmptyReleaseLicenseInfo();
                ButtonRelease.Enabled = false;

            }

        }

        private void ButtonRelease_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to release this detained license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            clsApplication releaseApplication = _CreateReleaseApplication();

            if (releaseApplication.Save())
            {
                _PrepareReleaseDetainedLicense(releaseApplication.ApplicationID);

                if (_License.DetainedLicenseInfo.ReleaseDetainedLicense())
                {
                    MessageBox.Show($"Detained License Released Successfully.", "License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LabelReleaseApplicationID.Text = releaseApplication.ApplicationID.ToString();
                    _UpdateFormAfterReleasedDetainedLicense();
                    return;
                }
                else
                {
                    releaseApplication.Delete();
                }
            }

            MessageBox.Show("Failed to release the Detained License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void LinkLabelShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPersonLicensesHistoryForm licenseHistory = new ShowPersonLicensesHistoryForm(userControl_SearchDriverLicense1.License.applicationInfo.PersonInfo.PersonID);
            licenseHistory.ShowDialog();
            userControl_SearchDriverLicense1.LoadLicenseInfo(_LicenseID);
        }

        private void LinkLabelShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DriverLicenseInfoForm driverLicenseInfo = new DriverLicenseInfoForm(_LicenseID);
            driverLicenseInfo.ShowDialog();
            userControl_SearchDriverLicense1.LoadLicenseInfo(_LicenseID);


        }

        private void _LoadEmptyDetainedLicenseInfo()
        {

            LabelDetainID.Text = "????";
            LabelCreatedByUser.Text = "????";
            LabelDetainDate.Text = "????";
            LabelLicenseID.Text = "????";
            LabelFineFees.Text = "????"; 

        }

        private void _LoadEmptyReleaseLicenseInfo()
        {

            LabelRealseByUser.Text = clsGlobalSettings.CurrentUser.Username;
            LabelApplicationFees.Text = _ApplicationType.Fees.Value.ToString("G29");
            LabelTotalFees.Text = "????";
            LabelReleaseApplicationID.Text = "????";

        }

        private void _LoadDetainedLicenseInfo()
        {

            //_License.DetainedLicenseInfo = clsDetainedLicense.GetDetainedLicenseByLicenseID(_LicenseID);

            if (_License.DetainedLicenseInfo == null)
            {
                ButtonRelease.Enabled = false;
                return;
            }

            LabelDetainID.Text = _License.DetainedLicenseInfo.DetainID.ToString();
            LabelCreatedByUser.Text = _License.DetainedLicenseInfo.CreatedByUserInfo.Username;
            LabelDetainDate.Text = _License.DetainedLicenseInfo.DetainDate.ToString("d");
            LabelFineFees.Text = _License.DetainedLicenseInfo.FineFees.ToString("G29");
            LabelLicenseID.Text = _License.DetainedLicenseInfo.LicenseID.ToString();
            LabelTotalFees.Text = clsApplication.CalculateTotalFees(_License.DetainedLicenseInfo.FineFees, _ApplicationType.Fees.Value).ToString("G29");

        }

        private clsApplication _CreateReleaseApplication()
        {

            clsApplication releaseApplication = new clsApplication();
            releaseApplication.ApplicationDate = DateTime.Now;
            releaseApplication.ApplicationPersonID = userControl_SearchDriverLicense1.License.applicationInfo.PersonInfo.PersonID ;
            releaseApplication.ApplicationTypeID = _ApplicationType.ApplicationTypeID;
            releaseApplication.ApplicationStatus = clsApplication.enApplicationStatus.Completed;
            releaseApplication.LastStatusDate = DateTime.Now;
            releaseApplication.PaidFees = _ApplicationType.Fees.Value;
            releaseApplication.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

            return releaseApplication;

        }

        private void _PrepareReleaseDetainedLicense(int releasedApplicationID)
        {

            _License.DetainedLicenseInfo.IsReleased = true;
            _License.DetainedLicenseInfo.ReleasedDate = DateTime.Now;
            _License.DetainedLicenseInfo.ReleasedByUserID = clsGlobalSettings.CurrentUser.UserID;
            _License.DetainedLicenseInfo.ReleasedApplicationID = releasedApplicationID;

        }

        private void _UpdateFormAfterReleasedDetainedLicense()
        {

            userControl_SearchDriverLicense1.GroupBoxSearchEnabled = false;
            userControl_SearchDriverLicense1.UpdateDetainedStatus(false);
            ButtonRelease.Enabled = false;

        }

        private bool _CanReleasedLicense()
        {

            if (!_License.IsDetained)
            {
                MessageBox.Show($"Selected License not detained.",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

    }
}
