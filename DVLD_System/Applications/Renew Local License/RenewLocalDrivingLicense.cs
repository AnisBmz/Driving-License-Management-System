using DVLD_Business;
using DVLD_System.Licenses.Local_License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_System
{
    public partial class RenewLocalDrivingLicenseForm : Form
    {

        int _NewLicenseID = -1;

        clsLicense _License;

        clsApplicationType _ApplicationType;

        public RenewLocalDrivingLicenseForm()
        {
            InitializeComponent();
            userControl_SearchDriverLicense1.ButtonClicked += UserControlSearchDriverLicense_ButtonSearchClicked;

        }

        private void RenewLocalDrivingLicenseForm_Load(object sender, EventArgs e)
        {
            userControl_SearchDriverLicense1.TextBoxSearchFocus();
            AcceptButton = userControl_SearchDriverLicense1.AcceptButton;
            _ApplicationType = clsApplicationType.GetApplicationTypeByID((int)clsApplicationType.enApplicationType.RenewDrivingLicenseService);
            _LoadEmptyApplicationNewLicenseInfo();
        }

        private void UserControlSearchDriverLicense_ButtonSearchClicked(object sender, EventArgs e)
        {

            _License = userControl_SearchDriverLicense1.License;

            if (_License == null)
            {
                _LoadEmptyApplicationNewLicenseInfo();
                LinkLabelShowLicensesHistory.Enabled = false;
                ButtonRenew.Enabled = false;
                return;
            }

            LinkLabelShowLicensesHistory.Enabled = true;

            if (_CanRenewLicense())
            {
                ButtonRenew.Enabled = true;
                _LoadApplicationNewLicenseInfo();
            }
            else
            {
                ButtonRenew.Enabled = false;
                _LoadEmptyApplicationNewLicenseInfo();
            }


        }

        private void ButtonRenew_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want renew the license", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {

                return;

            }

            clsLicense newLicense = _License.RenewLicense(_ApplicationType, TextBoxNotes.Text.Trim(), clsGlobalSettings.CurrentUser.UserID);

            if (newLicense == null)
            {
                MessageBox.Show($"License Renewed Failed", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            userControl_SearchDriverLicense1.UpdateActiveStatus(_License.IsActive);
            _NewLicenseID = newLicense.LicenseID;
            LabelRenewLicenseApplicationID.Text = newLicense.ApplicationID.ToString();
            LabelRenewedLicenseID.Text = _NewLicenseID.ToString();
            _UpdateFormAfterRenewal();
            MessageBox.Show($"License Renewed Successfully with license ID = {_NewLicenseID}", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void TextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;

            }

        }

        private bool _CanRenewLicense()
        {
            if (!_License.IsActive)
            {
                MessageBox.Show("Selected license is not active",
                                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_License.IsDetained)
            {
                MessageBox.Show("Selected license is detained and cannot be renewed",
                                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!_License.IsExpiredLicense())
            {
                MessageBox.Show($"Selected license is not yet expired, It will expire on: {_License.ExpirationDate:d}",
                                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void _LoadEmptyApplicationNewLicenseInfo()
        {

            LabelApplicationFees.Text = _ApplicationType.Fees.Value.ToString("G29");
            LabelCreatedByUser.Text = clsGlobalSettings.CurrentUser.Username;
            LabelApplicationDate.Text = DateTime.Now.ToString("d");
            LabelIssueDate.Text = DateTime.Now.ToString("d");
            LabelExpirationDate.Text = "????";
            LabelRenewLicenseApplicationID.Text = "????";
            LabelOldLicanseID.Text = "????";
            LabelRenewedLicenseID.Text = "????";
            LabelTotalFees.Text = "????";
            LabelLicenseFees.Text = "????";

        }

        private void _LoadApplicationNewLicenseInfo()
        {

            LabelExpirationDate.Text = DateTime.Now.AddYears(_License.licenseClassInfo.DefaultValidityLength).ToString("d");
            LabelOldLicanseID.Text = _License.LicenseID.ToString();
            LabelLicenseFees.Text = _License.licenseClassInfo.ClassFees.ToString("G29");
            LabelTotalFees.Text = clsApplication.CalculateTotalFees(_License.licenseClassInfo.ClassFees, _ApplicationType.Fees.Value).ToString("G29");

        }

        private void _UpdateFormAfterRenewal()
        {

            LinkLabelShowLicenseInfo.Enabled = true;
            userControl_SearchDriverLicense1.GroupBoxSearchEnabled = false;
            ButtonRenew.Enabled = false;
            TextBoxNotes.Enabled = false;

        }

    }
}
