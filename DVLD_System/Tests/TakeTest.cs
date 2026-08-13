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
    public partial class TakeTestForm : Form
    {

        int _LocalDrivingLicenseApplicationID = -1;

        int _TestAppointmentID = -1;

        int _TestTypeID = -1;

        int _RetakeTestApplicationID = -1;

        public TakeTestForm(int testAppointmentID, int localDrivingLicenseApplicationID, int testTypeID)
        {
            InitializeComponent();
            _TestAppointmentID = testAppointmentID;
            _LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            _TestTypeID = testTypeID;

        }

        private void TakeTestForm_Load(object sender, EventArgs e)
        {

            if (_TestTypeID == (int)clsTestType.enTestType.WrittenTest)
            {
                _ShowWrittenTakeTestUI();
            }
            else if (_TestTypeID == (int)clsTestType.enTestType.StreetTest)
            {

                _ShowStreetTakeTestUI();
            }

            _LoadTestAppointmentInfo();

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

            clsTest test = _CreateTestInfo();

            if (MessageBox.Show("Are you sure you want to save? After saving, you cannot change the Pass/Fail result.", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                if (test.AddNewTest())
                {

                    clsTestAppointment.LockTestAppointment(test.TestAppointmentID);
                    LabelTestID.Text = test.TestID.ToString();

                    if (_RetakeTestApplicationID != -1)
                    {
                        clsApplication.EditStatusToCompleted(_RetakeTestApplicationID);
                    }

                    MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ButtonSave.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Data Save Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            this.Close();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _LoadTestAppointmentInfo()
        {

            clsTestAppointment testAppointment = clsTestAppointment.GetTestAppointmentByID(_TestAppointmentID);

            if (testAppointment == null)
            {
                MessageBox.Show($"No test appointment with ID = {_TestAppointmentID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ButtonSave.Enabled = false;
                return;
            }

            LabelLocalDrivingLicenseApplicationID.Text = _LocalDrivingLicenseApplicationID.ToString();

            LabelLicenseClass.Text = testAppointment.LocalDrivingLicenseApplicationInfo.LicenseClassInfo.ClassName;

            LabelName.Text = testAppointment.LocalDrivingLicenseApplicationInfo.PersonInfo.FullName;

            LabelDate.Text = testAppointment.AppointmentDate.ToString("d");

            LabelFees.Text = testAppointment.PaidFees.ToString();

            LabelTrial.Text = clsTest.TotalTrialsPerTest(_LocalDrivingLicenseApplicationID, _TestTypeID).ToString();

            _RetakeTestApplicationID = testAppointment.RetakeTestApplicationID;

        }

        private void _ShowWrittenTakeTestUI()
        {

            pictureBox2.Image = Resources.content;
            GroupBoxTest.Text = "Written Test";

        }

        private void _ShowStreetTakeTestUI()
        {

            pictureBox2.Image = Resources.test__3_;
            GroupBoxTest.Text = "Street Test";

        }

        private clsTest _CreateTestInfo()
        {

            clsTest test = new clsTest();

            test.TestResult = RadioButtonPass.Checked;

            test.TestAppointmentID = _TestAppointmentID;

            test.Notes = TextBoxNotes.Text.Trim();

            test.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

            return test;

        }

    }
}
