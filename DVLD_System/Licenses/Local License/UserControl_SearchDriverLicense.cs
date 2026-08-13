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

namespace DVLD_System.Licenses.Local_License
{
    public partial class UserControl_SearchDriverLicense : UserControl
    {
        int _LicenseID = -1;

        public clsLicense License { get { return userControl_DriverLicenseInfo1.License ; } }

        public event EventHandler ButtonClicked;

        public bool GroupBoxSearchEnabled { 
            get { return GroupBoxFilter.Enabled; }
            set { GroupBoxFilter.Enabled = value; }
        }

        public Button AcceptButton { get { return ButtonSearch; } }

        public UserControl_SearchDriverLicense()
        {
            InitializeComponent();
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(TextBoxSearch.Text.Trim()))
            {
                _LicenseID = int.Parse(TextBoxSearch.Text);
                userControl_DriverLicenseInfo1.LoadDriverLicenseInfo(_LicenseID);
                ButtonClicked?.Invoke(this, EventArgs.Empty);
            }


        }

        private void TextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;

            }

        }

        private void TextBoxSearch_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TextBoxSearch.Text.Trim()))
            {

                errorProvider.SetError(TextBoxSearch, "This field must be entered");

            }
            else
            {

                errorProvider.SetError(TextBoxSearch, string.Empty);

            }

        }

        public void LoadLicenseInfo(int licenseID)
        {
            _LicenseID = licenseID;
            userControl_DriverLicenseInfo1.LoadDriverLicenseInfo(_LicenseID);
            TextBoxSearch.Text = _LicenseID.ToString();

        }

        public void TextBoxSearchFocus()
        {

            TextBoxSearch.Select();

        }

        public void UpdateActiveStatus(bool isActive)
        {

            userControl_DriverLicenseInfo1.UpdateActiveStatus(isActive);

        }

        public void UpdateDetainedStatus(bool isDetained)
        {
            userControl_DriverLicenseInfo1.UpdateDetainedStatus(isDetained);

        }

    }
}
