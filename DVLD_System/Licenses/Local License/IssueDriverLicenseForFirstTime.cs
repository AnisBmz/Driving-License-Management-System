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

namespace DVLD_System
{
    public partial class IssueDriverLicenseForFirstTimeForm : Form
    {

        int _LocalDrivingLicenseApplicationID = -1;

        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        public IssueDriverLicenseForFirstTimeForm(int localDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
        }

        private void IssueDriverLicenseForFirstTimeForm_Load(object sender, EventArgs e)
        {



            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationByID(_LocalDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show($"No application with ID = {_LocalDrivingLicenseApplicationID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            if (_LocalDrivingLicenseApplication.IsLicenseIssued())
            {

                MessageBox.Show("Person already have a license with the same applied driving class, Choose different driving class.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close (); return;

            }
            userControl_DrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalApplicationID(_LocalDrivingLicenseApplicationID);


        }

        private void ButtonIssue_Click(object sender, EventArgs e)
        {

            clsLicense license = _CreateNewLicense();

            int driverID = clsDriver.CheckDriverIsExists(_LocalDrivingLicenseApplication.ApplicationPersonID);

            if (driverID == -1)
            {

                _AddNewDriverWithIssueLicenseForFirstTime(license);

            }
            else
            {

                license.DriverID = driverID;
                _IssueLicenseForFirstTime(license);

            }


        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private clsDriver _CreateNewDriver()
        {

            clsDriver driver = new clsDriver();
            driver.PersonID = _LocalDrivingLicenseApplication.ApplicationPersonID;
            driver.CreatedDate = DateTime.Now;
            driver.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
            return driver;

        }

        private clsLicense _CreateNewLicense()
        {
            clsLicense license = new clsLicense();
            license.ApplicationID = _LocalDrivingLicenseApplication.ApplicationID;
            license.LicenseClassID = _LocalDrivingLicenseApplication.LicenseClassID;
            license.IssueDate = DateTime.Now;
            license.ExpirationDate = DateTime.Now.AddYears(_LocalDrivingLicenseApplication.LicenseClassInfo.DefaultValidityLength);
            license.Notes = TextBoxNotes.Text.Trim();
            license.IssueReasonID = (byte) clsLicense.enIssueLicenseReason.FirstTime;
            license.IsActive = true;
            license.PaidFees = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassFees;
            license.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
            return license;
        }

        private void _IssueLicenseForFirstTime(clsLicense license)
        {
            if (!license.AddNewLicense())
            {
                MessageBox.Show("License Issued Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsApplication.EditStatusToCompleted(license.ApplicationID);
            MessageBox.Show($"License Issued Successfully with license ID = {license.LicenseID}", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        private void _AddNewDriverWithIssueLicenseForFirstTime(clsLicense license)
        {

            clsDriver driver = _CreateNewDriver();

            if (!driver.AddNewDriver())
            {
                MessageBox.Show("License Issued Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            license.DriverID = driver.DriverID;
            _IssueLicenseForFirstTime(license);

        }

    }
}
