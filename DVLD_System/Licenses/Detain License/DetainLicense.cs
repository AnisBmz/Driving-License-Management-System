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

namespace DVLD_System
{
    public partial class DetainLicenseForm : Form
    {

        clsLicense _License;

        public DetainLicenseForm()
        {
            InitializeComponent();
            userControl_SearchDriverLicense1.ButtonClicked += UserControlSearchDriverLicense_ButtonSearchClicked;

        }

        private void DetainLicenseForm_Load(object sender, EventArgs e)
        {

            userControl_SearchDriverLicense1.TextBoxSearchFocus();
            AcceptButton = userControl_SearchDriverLicense1.AcceptButton;
            _LoadEmptyDetainInfo();

        }

        private void UserControlSearchDriverLicense_ButtonSearchClicked(object sender, EventArgs e)
        {

            _License = userControl_SearchDriverLicense1.License;

            if (_License == null)
            {
                _LoadEmptyDetainInfo();
                LinkLabelShowLicensesHistory.Enabled = false;
                LinkLabelShowLicenseInfo.Enabled = false;
                ButtonDetain.Enabled = false;
                return;
            }

            LinkLabelShowLicensesHistory.Enabled = true;
            LinkLabelShowLicenseInfo.Enabled = true;

            if (_CanDetainLicense())
            {
                ButtonDetain.Enabled = true;
                LabelLicenseID.Text = _License.LicenseID.ToString();
            }
            else
            {
                _LoadEmptyDetainInfo();
                ButtonDetain.Enabled = false;
            }


        }

        private void ButtonDetain_Click(object sender, EventArgs e)
        {

            if (!_ValidateChildrenForSave())
            {
                return;
            }


            if (MessageBox.Show("Are you sure you want to detain this license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            decimal fineFees = Convert.ToDecimal(TextBoxFees.Text.Trim());

            int ?detainedID = _License.DetainLicense(fineFees, clsGlobalSettings.CurrentUser.UserID);

            if (detainedID == null)
            {
                MessageBox.Show($"License Detained Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show($"License Detained Successfully with ID = {detainedID}", "License Detained", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LabelDetainID.Text = detainedID.ToString();
            _UpdateFormAfterLicenseDetained();

        }

        private void TextBoxFees_Validating(object sender, CancelEventArgs e)
        {

            string input = TextBoxFees.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {

                errorProviderFees.SetError(TextBoxFees, "Fees cannot be blank.");

            }
            else if (!decimal.TryParse(input, out decimal fees))
            {

                errorProviderFees.SetError(TextBoxFees, "Fees Value must be numeric.");


            }
            else if (fees <= 0)
            {

                errorProviderFees.SetError(TextBoxFees, "The fees must be greater than zero.");

            }
            else
            {

                errorProviderFees.SetError(TextBoxFees, string.Empty);

            }
        }

        private void LinkLabelShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ShowPersonLicensesHistoryForm licenseHistory = new ShowPersonLicensesHistoryForm(_License.applicationInfo.ApplicationPersonID);
            licenseHistory.ShowDialog();


        }

        private void LinkLabelShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DriverLicenseInfoForm driverLicenseInfo = new DriverLicenseInfoForm(_License.LicenseID);
            driverLicenseInfo.ShowDialog();
            userControl_SearchDriverLicense1.LoadLicenseInfo(_License.LicenseID);
        }

        private void _UpdateFormAfterLicenseDetained()
        {
            userControl_SearchDriverLicense1.GroupBoxSearchEnabled = false;
            ButtonDetain.Enabled = false;
            TextBoxFees.Enabled = false;
            userControl_SearchDriverLicense1.UpdateDetainedStatus(true);    
        }

        private void _LoadEmptyDetainInfo()
        {

            LabelDetainID.Text = "????";
            LabelCreatedByUser.Text = clsGlobalSettings.CurrentUser.Username;
            LabelDetainDate.Text = DateTime.Now.ToString("d");
            LabelLicenseID.Text = "????";

        }

        private bool _CanDetainLicense()
        {
            if (!_License.IsActive)
            {
                MessageBox.Show("Selected license is not active",
                                "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (_License.IsDetained)
            {
                MessageBox.Show($"Selected License already detained.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }

            return true;
        }

        private bool _ValidateChildrenForSave()
        {

            this.ValidateChildren();

            if (!string.IsNullOrEmpty(errorProviderFees.GetError(TextBoxFees)))
            {
                MessageBox.Show("Some fields are not valid!, please check the red icons.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}
