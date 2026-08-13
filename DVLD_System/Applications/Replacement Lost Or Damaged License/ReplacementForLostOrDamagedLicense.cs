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
using static DVLD_Business.clsLicense;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_System
{
    public partial class ReplacementForLostOrDamagedLicenseForm : Form
    {

        int _NewLicenseID = -1;

        clsLicense _License;

        clsApplicationType _ApplicationType;

        public ReplacementForLostOrDamagedLicenseForm()
        {
            InitializeComponent();
            userControl_SearchDriverLicense1.ButtonClicked += UserControlSearchDriverLicense_ButtonSearchClicked;

        }

        private void ReplacementForLostOrDamagedLicenseForm_Load(object sender, EventArgs e)
        {
            userControl_SearchDriverLicense1.TextBoxSearchFocus();
            AcceptButton = userControl_SearchDriverLicense1.AcceptButton;
            _FindApplicationType();
            _LoadEmptyApplicationInfo();
        }

        private void UserControlSearchDriverLicense_ButtonSearchClicked(object sender, EventArgs e)
        {

            _License = userControl_SearchDriverLicense1.License;

            if (_License == null)
            {

                _LoadEmptyApplicationInfo();
                LinkLabelShowLicensesHistory.Enabled = false;
                ButtonIssueReplacement.Enabled = false;
                return;

            }

            LinkLabelShowLicensesHistory.Enabled = true;

            if (_CanReplaceLicense())
            {
                ButtonIssueReplacement.Enabled = true;
                LabelOldLicanseID.Text = _License.LicenseID.ToString();
            }
            else
            {
                ButtonIssueReplacement.Enabled = false;
                LabelOldLicanseID.Text = "????";
            }


        }

        private void RadioButtonLicense_CheckedChanged(object sender, EventArgs e)
        {
            _FindApplicationType();
            LabelApplicationFees.Text = _ApplicationType.Fees.Value.ToString("G29");
        }

        private void ButtonIssueReplacement_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to issue a replacement fot the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                clsLicense newLicense = _License.ReplaceLicense(_ApplicationType, _GetIssueReason(), clsGlobalSettings.CurrentUser.UserID);

                if (newLicense == null)
                {
                    MessageBox.Show($"License Replaced Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _License.DeactivateLicense();
                userControl_SearchDriverLicense1.UpdateActiveStatus(_License.IsActive);
                _NewLicenseID = newLicense.LicenseID;
                LabelReplacementLicanseApplicationID.Text = newLicense.ApplicationID.ToString();
                LabelReplacedLicenseID.Text = _NewLicenseID.ToString();
                _UpdateFormAfterReplaced();
                MessageBox.Show($"License Replaced Successfully with license ID = {_NewLicenseID}", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void LinkLabelShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ShowPersonLicensesHistoryForm licenseHistoryForm = new ShowPersonLicensesHistoryForm(_License.applicationInfo.ApplicationPersonID);
            licenseHistoryForm.ShowDialog();
            userControl_SearchDriverLicense1.LoadLicenseInfo(_License.LicenseID);


        }

        private void LinkLabelShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DriverLicenseInfoForm driverLicenseInfo = new DriverLicenseInfoForm(_NewLicenseID);
            driverLicenseInfo.ShowDialog();

        }

        private bool _CanReplaceLicense()
        {
            if (!_License.IsActive)
            {
                MessageBox.Show("Selected license is not active",
                                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_License.IsDetained)
            {
                MessageBox.Show("Selected license is detained and cannot be replaced",
                                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void _FindApplicationType()
        {

            if (RadioButtonDamagedLicense.Checked)
            {

                _ApplicationType = GetApplicationTypeByID((int) enApplicationType.ReplacementForADamagedDrivingLicense);


            }
            else if (RadioButtonLostLicense.Checked)
            {

                _ApplicationType = GetApplicationTypeByID((int) enApplicationType.ReplacementForLostDrivingLicense);

            }

        }

        private enIssueLicenseReason _GetIssueReason()
        {

            enIssueLicenseReason issueReason = enIssueLicenseReason.ReplacementForLost;

            if (RadioButtonDamagedLicense.Checked)
            {
                issueReason = enIssueLicenseReason.ReplacementForDamaged;
            }

            return issueReason;

        }

        private void _UpdateFormAfterReplaced()
        {

            LinkLabelShowLicenseInfo.Enabled = true;
            userControl_SearchDriverLicense1.GroupBoxSearchEnabled = false;
            ButtonIssueReplacement.Enabled = false;
            GroupBoxReplacmentFor.Enabled = false;


        }

        private void _LoadEmptyApplicationInfo()
        {

            LabelReplacementLicanseApplicationID.Text = "????";
            LabelApplicationDate.Text = DateTime.Now.ToString("d");
            LabelApplicationFees.Text = _ApplicationType.Fees.Value.ToString("G29");
            LabelReplacedLicenseID.Text = "????";
            LabelOldLicanseID.Text = "????";
            LabelCreatedByUser.Text = clsGlobalSettings.CurrentUser.Username;

        }

    }
}
