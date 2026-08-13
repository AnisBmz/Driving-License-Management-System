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
    public partial class ManageTestAppointmentsForm : Form
    {

        int _LocalDrivingLicenseApplicationID = -1;

        int _TestTypeID = -1;

        public ManageTestAppointmentsForm(int localDrivingLicenseApplicationID, int testTypeID)
        {

            InitializeComponent();
            _LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            _TestTypeID = testTypeID;

        }

        private void TestAppointmentsForm_Load(object sender, EventArgs e)
        {

            if (_TestTypeID == (int)clsTestType.enTestType.WrittenTest)
            {

                _ShowWrittenTestAppointmentsUI();

            }
            else if (_TestTypeID == (int)clsTestType.enTestType.StreetTest)
            {

                _ShowStreetTestAppointmentsUI();

            }


            userControl_DrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalApplicationID(_LocalDrivingLicenseApplicationID);

            _LoadAllAppointmentsTestToTable();


        }

        private void ButtonAddAppointment_Click(object sender, EventArgs e)
        {

            if (clsTestAppointment.IsPersonHaveActiveAppointment(_LocalDrivingLicenseApplicationID, _TestTypeID))
            {
                MessageBox.Show("Person Already have an active appointment for this test, you cannot add new appointment", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (clsTest.CheckTestResult(_LocalDrivingLicenseApplicationID, _TestTypeID, true))
            {

                MessageBox.Show($"Person Already Passed this test before, you can only retake failed test", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            ScheduleTestForm scheduleTest = new ScheduleTestForm(_LocalDrivingLicenseApplicationID, _TestTypeID);
            scheduleTest.ShowDialog();
            _LoadAllAppointmentsTestToTable();

        }

        private void DataGridViewVisionAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridViewVisionAppointments.CurrentRow != null)
            {
                DataGridViewVisionAppointments.CurrentRow.ContextMenuStrip = ContextMenuStripAppointments;
            }
        }

        private void EditAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int testAppointmentID = Convert.ToInt32(DataGridViewVisionAppointments.CurrentRow.Cells[0].Value);
            ScheduleTestForm scheduleTest = new ScheduleTestForm(testAppointmentID, _LocalDrivingLicenseApplicationID, _TestTypeID);
            _OpenFormWithReload(scheduleTest);
        }

        private void TakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int testAppointmentID = Convert.ToInt32(DataGridViewVisionAppointments.CurrentRow.Cells[0].Value);

            clsTestAppointment testAppointment = clsTestAppointment.GetTestAppointmentByID(testAppointmentID);

            if (testAppointment != null)
            {
                if (testAppointment.IsLocked)
                {
                    MessageBox.Show("This person already took this test before.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

            TakeTestForm takeTest = new TakeTestForm(testAppointmentID, _LocalDrivingLicenseApplicationID, _TestTypeID);
            _OpenFormWithReload(takeTest);
            userControl_DrivingLicenseApplicationInfo1.UpdatePassedTests();

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _LoadAllAppointmentsTestToTable()
        {

            DataTable dataTable = clsTestAppointment.GetAllAppointmentsTestByLocalDrivingLicenseApplicationID(_LocalDrivingLicenseApplicationID, _TestTypeID);

            DataView dataView = new DataView(dataTable);

            if (dataView.Count != 0)
            {
                DataGridViewVisionAppointments.DataSource = dataView;
            }

            LabelRecordsCount.Text = dataView.Count.ToString();

        }

        private void _ShowWrittenTestAppointmentsUI()
        {

            LabelTitle.Text = "Written Test Appointments";
            this.Text = "Written Test Appointments";
            pictureBox1.Image = Resources.content;

        }

        private void _ShowStreetTestAppointmentsUI()
        {

            LabelTitle.Text = "Street Test Appointments";
            this.Text = "Street Test Appointments";
            pictureBox1.Image = Resources.test__3_;

        }

        private void _OpenFormWithReload(Form form)
        {

            int rowIndex = -1;

            if (DataGridViewVisionAppointments.RowCount > 0)
            {

                rowIndex = DataGridViewVisionAppointments.SelectedRows[0].Index;


            }

            form.ShowDialog();
            _LoadAllAppointmentsTestToTable();

            if (rowIndex >= 0 && DataGridViewVisionAppointments.RowCount > 0)
            {

                DataGridViewVisionAppointments.Rows[rowIndex].Selected = true;
                DataGridViewVisionAppointments.CurrentCell = DataGridViewVisionAppointments.Rows[rowIndex].Cells[0];


            }

        }

    }
}
