using DVLD_Business;
using DVLD_System.Properties;
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
    public partial class ScheduleTestForm : Form
    {

        private enum enMode { AddNew = 0, Update = 1 }

        enMode _Mode = enMode.AddNew;

        private enum enCreationMode { FirstTimeSchedule , RetakeTestSchedule };

        int _LocalDrivingLicenseApplicationID = -1;

        int _TestAppointmentID = -1;

        int _TestTypeID = -1;

        int _PersonID = -1;

        int _RetakeTestApplicationID = -1;

        clsTestAppointment _TestAppointment;

        public ScheduleTestForm(int testAppointmentID, int localDrivingLicenseApplicationID, int testTypeID)
        {

            InitializeComponent();
            _LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            _TestAppointmentID = testAppointmentID;
            _TestTypeID = testTypeID;
            _Mode = enMode.Update;

        }

        public ScheduleTestForm(int localDrivingLicenseApplicationID, int testTypeID)
        {

            InitializeComponent();
            _LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            _TestTypeID = testTypeID;
            _Mode = enMode.AddNew;

        }

        private void ScheduleTestForm_Load(object sender, EventArgs e)
        {

            _UpdateScheduleTestUI();
            _LoadDefaultValues();

            if (_Mode == enMode.Update)
            {

                _ShowUpdateFormUI();
                _LoadTestAppointmentInfo();

            }
            else if (_Mode == enMode.AddNew) 
            {
                _TestAppointment = new clsTestAppointment();
                _ShowRetakeTestUIIfFailed();
                LabelFees.Text = clsTestType.GetTestTypeInfoByID(_TestTypeID).Fees.ToString();
            }

            DateTimePicker.MinDate = DateTime.Now.AddDays(1);

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

            _HandleRetakeTestApplication();

            _ReadTestAppointmentInfo();

            if (_TestAppointment.Save())
            {

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (_Mode == enMode.AddNew)
                {
                    _Mode = enMode.Update;
                    _ShowUpdateFormUI();

                }

            }
            else
            {

                MessageBox.Show("Data Save Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _UpdateScheduleTestUI()
        {

            if (_TestTypeID == (int)clsTestType.enTestType.WrittenTest)
            {
                _UpdateWrittenTestUI();
            }
            else if (_TestTypeID == (int)clsTestType.enTestType.StreetTest)
            {
                _UpdateStreetTestUI();
            }

        }

        private void _UpdateWrittenTestUI()
        {

            pictureBox2.Image = Resources.content;
            GroupBoxTest.Text = "Written Test";

        }

        private void _UpdateStreetTestUI()
        {

            pictureBox2.Image = Resources.test__3_;
            GroupBoxTest.Text = "Street Test";

        }

        private void _LoadDefaultValues()
        {

            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationByID(_LocalDrivingLicenseApplicationID);

            if (localDrivingLicenseApplication == null)
            {
                MessageBox.Show($"No local driving license application with ID = {_LocalDrivingLicenseApplicationID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ButtonSave.Enabled = false;
                DateTimePicker.Enabled = false;
                return;
            }

            LabelLocalDrivingLicenseApplicationID.Text = _LocalDrivingLicenseApplicationID.ToString();

            LabelLicenseClass.Text = localDrivingLicenseApplication.LicenseClassInfo.ClassName;

            LabelName.Text = localDrivingLicenseApplication.PersonInfo.FullName;

            LabelTrial.Text = clsTest.TotalTrialsPerTest(_LocalDrivingLicenseApplicationID, _TestTypeID).ToString();

            _PersonID = localDrivingLicenseApplication.ApplicationPersonID;


        }

        private void _ShowUpdateFormUI()
        {

            _SetFormTitle("Edit Scheduled Test");
        }

        private void _LoadTestAppointmentInfo()
        {

            _TestAppointment = clsTestAppointment.GetTestAppointmentByID(_TestAppointmentID);

            if (_TestAppointment == null)
            {
                MessageBox.Show($"No Appointment with ID = {_TestAppointmentID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ButtonSave.Enabled = false;
                DateTimePicker.Enabled = false;
                return;
            }

            if (_TestAppointment.IsLocked)
            {
                ButtonSave.Enabled = false;
                DateTimePicker.Enabled = false;
                LabelAppointmentLocked.Visible = true;
            }

            DateTimePicker.MinDate = _TestAppointment.AppointmentDate;
            LabelFees.Text = _TestAppointment.PaidFees.ToString();

            if (_TestAppointment.RetakeTestApplicationID != -1)
            {
                _RetakeTestApplicationID = _TestAppointment.RetakeTestApplicationID;
                _ShowEditScheduledRetakeTestUI();
            }
            else
            {
                GroupBoxRetakeTestInfo.Visible = false;
            }

        }

        private void _ShowEditScheduledRetakeTestUI()
        {
            labelRetakeTestApplicationID.Text = _RetakeTestApplicationID.ToString();
            GroupBoxRetakeTestInfo.Visible = true;
            _SetFormTitle("Edit Scheduled Retake Test");
            clsApplication application = clsApplication.GetApplicationInfoByID(_RetakeTestApplicationID);

            if (application != null)
            {
                LabelRetakeApplicationFees.Text = application.PaidFees.ToString();
                LabelTotalFees.Text = clsTestAppointment.CalculateTotalFeesForRetakeTest(_TestAppointment.PaidFees, application.PaidFees).ToString();

            }

        }

        private void _ShowRetakeTestUIIfFailed()
        {

            if (clsTest.CheckTestResult(_LocalDrivingLicenseApplicationID, _TestTypeID, false))
            {
                GroupBoxRetakeTestInfo.Visible = true;
                _SetFormTitle("Schedule Retake Test");
                _LoadRetakeTestInfo();
            }

        }

        private void _LoadRetakeTestInfo()
        {
            clsApplicationType applicationType = clsApplicationType.GetApplicationTypeByID((int)clsApplicationType.enApplicationType.RetakeTest);
            LabelRetakeApplicationFees.Text = applicationType.Fees.ToString();
            decimal testFees = clsTestType.GetTestTypeInfoByID(_TestTypeID).Fees.Value;
            LabelTotalFees.Text = clsTestAppointment.CalculateTotalFeesForRetakeTest(testFees, applicationType.Fees.Value).ToString();

        }

        private void _SetFormTitle(string title)
        {
            this.Text = title;
            LabelTitle.Text = title;
            LabelTitle.Left = (this.ClientSize.Width - LabelTitle.Width) / 2;
        }

        private void _HandleRetakeTestApplication()
        {

            if (clsTest.CheckTestResult(_LocalDrivingLicenseApplicationID, _TestTypeID, false))
            {

                if (_RetakeTestApplicationID == -1)
                {

                    clsApplication application = _CreateRetakeTestApplication();

                    if (application.Save())
                    {

                        labelRetakeTestApplicationID.Text = application.ApplicationID.ToString();
                        _RetakeTestApplicationID = application.ApplicationID;
                        _TestAppointment.RetakeTestApplicationID = _RetakeTestApplicationID;
                    }
                }

            }

        }

        private void _ReadTestAppointmentInfo()
        {

            _TestAppointment.AppointmentDate = DateTimePicker.Value;
            _TestAppointment.PaidFees = Convert.ToDecimal(LabelFees.Text);
            _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseApplicationID;
            _TestAppointment.IsLocked = false;
            _TestAppointment.TestTypeID = _TestTypeID;
            _TestAppointment.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;


        }

        private clsApplication _CreateRetakeTestApplication()
        {
            clsApplication application = new clsApplication();
            application.ApplicationDate = DateTime.Now;
            application.ApplicationPersonID = _PersonID;
            application.ApplicationTypeID = (int) clsApplicationType.enApplicationType.RetakeTest;
            application.ApplicationStatus = clsApplication.enApplicationStatus.New;
            application.PaidFees = clsApplicationType.GetApplicationTypeByID(application.ApplicationTypeID).Fees.Value;
            application.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;
            application.LastStatusDate = DateTime.Now;
            return application;

        }

    }
}
