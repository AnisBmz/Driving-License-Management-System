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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_System
{
    public partial class UserControl_DrivingLicenseApplicationInfo : UserControl
    {

        int _LocalDrivingLicenseApplicationID = -1;

        int _PersonID = -1;

        int _LicenseID = -1;

        const int _TotalTests = 3;

        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        public UserControl_DrivingLicenseApplicationInfo()
        {
            InitializeComponent();
        }

        private void LinkLabelViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            ShowPersonInfoForm personDetails = new ShowPersonInfoForm(_PersonID);
            personDetails.ShowDialog();
            LoadApplicationInfoByLocalApplicationID(_LocalDrivingLicenseApplicationID);

        }

        private void LinkLabelShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            DriverLicenseInfoForm driverLicenseInfoForm = new DriverLicenseInfoForm(_LicenseID);
            driverLicenseInfoForm.ShowDialog();
        }

        public void LoadApplicationInfoByLocalApplicationID(int localDrivingLicenseApplicationID)
        {

            _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationByID(localDrivingLicenseApplicationID);

            if (_LocalDrivingLicenseApplication == null)
            {
                _ResetLocalDrivingLicenseApplicationInfo();

                MessageBox.Show("No Application with ApplicationID = " + localDrivingLicenseApplicationID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            _FillLocalDrivingLicenseApplicationInfo();

        }

        public void UpdatePassedTests()
        {
            if (_LocalDrivingLicenseApplication == null)
            {
                LabelPassedTests.Text = "0/3";
                return;
            }

            byte passedTestCount = _LocalDrivingLicenseApplication.GetPassedTestCount();
            LabelPassedTests.Text = $"{passedTestCount}/{_TotalTests}";
        }

        private void _ResetLocalDrivingLicenseApplicationInfo()
        {

            _LocalDrivingLicenseApplicationID = -1;
            LabelLocalDrivingLicenseApplicationID.Text = "????";
            LabelLicenseClass.Text = "????";
            LabelPassedTests.Text = "????";
            LabelApplicationID.Text = "????";
            LabelFees.Text = "????";
            LabelType.Text = "????";
            LabelDate.Text = "????";
            LabelStatusDate.Text = "????";
            LabelCreatedBy.Text = "????";
            LabelApplicant.Text = "????";
            LabelStatus.Text = "????";

        }

        private void _FillLocalDrivingLicenseApplicationInfo()
        {

            _LicenseID = _LocalDrivingLicenseApplication.GetLicenseID();

            LinkLabelShowLicenseInfo.Enabled = (_LicenseID != -1);

            _PersonID = _LocalDrivingLicenseApplication.ApplicationPersonID;

            LabelLocalDrivingLicenseApplicationID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            LabelLicenseClass.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            UpdatePassedTests();
            LabelApplicationID.Text = _LocalDrivingLicenseApplication.ApplicationID.ToString();
            LabelFees.Text = _LocalDrivingLicenseApplication.PaidFees.ToString();
            LabelType.Text = _LocalDrivingLicenseApplication.ApplicationTypeInfo.Title;
            LabelDate.Text = _LocalDrivingLicenseApplication.ApplicationDate.ToString("d");
            LabelStatusDate.Text = _LocalDrivingLicenseApplication.LastStatusDate.ToString("d");
            LabelCreatedBy.Text = clsUser.GetUserInfoByUserID(_LocalDrivingLicenseApplication.CreatedByUserID).Username;
            LabelApplicant.Text = _LocalDrivingLicenseApplication.PersonInfo.FullName;
            LabelStatus.Text = _LocalDrivingLicenseApplication.ApplicationStatusName;

        }
    }
}
