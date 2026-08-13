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
    public partial class ManageLocalDrivingLicenseApplicationsForm : Form
    {
         
        public ManageLocalDrivingLicenseApplicationsForm()
        {
            InitializeComponent();
        }

        private void LocalDrivingLicenseApplicationsForm_Load(object sender, EventArgs e)
        {

            _LoadLocalDrivingLicenseApplicationsTable();
            if (DataGridViewLocalDrivingLicenseApplications.Columns.Count > 0)
            {

                DataGridViewLocalDrivingLicenseApplications.Columns["LDLA ID"].Width = 100;
                DataGridViewLocalDrivingLicenseApplications.Columns["National No"].Width = 100;
                DataGridViewLocalDrivingLicenseApplications.Columns["Passed Test"].Width = 70;
                DataGridViewLocalDrivingLicenseApplications.Columns["Application Date"].Width = 120;
                DataGridViewLocalDrivingLicenseApplications.Columns["Status"].Width = 100;
            }
            _FillComboBoxFilters();


        }

        private void ButtonAddNewLocalDrivingLicenseApplication_Click(object sender, EventArgs e)
        {

            AddUpdateLocalDrivingLicenseApplicationForm newLocalDrivingLicenseApplicationForm = new AddUpdateLocalDrivingLicenseApplicationForm();
            newLocalDrivingLicenseApplicationForm.ShowDialog();
            _ReloadLocalDrivingLicenseApplicationsTable();

        }

        private void ShowApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int localDrivingLicenseApplicationID = Convert.ToInt32(DataGridViewLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            LocalDrivingLicenseApplicationInfoForm localDrivingLicenseApplicationInfo = new LocalDrivingLicenseApplicationInfoForm(localDrivingLicenseApplicationID);
            _OpenFormWithReload(localDrivingLicenseApplicationInfo);

        }

        private void EditApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int localDrivingLicenseApplicationID = Convert.ToInt32(DataGridViewLocalDrivingLicenseApplications.SelectedCells[0].Value);
            AddUpdateLocalDrivingLicenseApplicationForm newLocalDrivingLicenseApplicationForm = new AddUpdateLocalDrivingLicenseApplicationForm(localDrivingLicenseApplicationID);
            _OpenFormWithReload(newLocalDrivingLicenseApplicationForm);

        }

        private void DeleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show($"Are you sure you want to delete this Application.", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            int localDrivingLicenseApplicationID = Convert.ToInt32(DataGridViewLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);

            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationByID(localDrivingLicenseApplicationID);

            if (localDrivingLicenseApplication != null)
            {
                if (localDrivingLicenseApplication.Delete())
                {

                    MessageBox.Show("Data Deleted Successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ReloadLocalDrivingLicenseApplicationsTable();

                }
                else
                {

                    MessageBox.Show("Local Driving Application not deleted because it has data to linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


                }
            }

        }

        private void CancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure do want to cancel this application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int rowIndex = -1;

            if (DataGridViewLocalDrivingLicenseApplications.RowCount > 0)
            {

                rowIndex = DataGridViewLocalDrivingLicenseApplications.SelectedRows[0].Index;

            }

            int loadLocalDrivingLicenseApplicationID = Convert.ToInt32(DataGridViewLocalDrivingLicenseApplications.SelectedCells[0].Value);

            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationByID(loadLocalDrivingLicenseApplicationID);

            if (localDrivingLicenseApplication != null)
            {

                if (localDrivingLicenseApplication.ApplicationStatus != clsApplication.enApplicationStatus.New)
                {
                    MessageBox.Show($"This Application is [{localDrivingLicenseApplication.ApplicationStatusName}] Could not cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (localDrivingLicenseApplication.EditStatusToCancelled())
                {

                    MessageBox.Show("Application cancelled Successfully", "cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _ReloadLocalDrivingLicenseApplicationsTable();

                }
                else { MessageBox.Show("Could not cancel this Application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }

            if (rowIndex >= 0 && DataGridViewLocalDrivingLicenseApplications.RowCount > 0)
            {

                DataGridViewLocalDrivingLicenseApplications.Rows[rowIndex].Selected = true;
                DataGridViewLocalDrivingLicenseApplications.CurrentCell = DataGridViewLocalDrivingLicenseApplications.Rows[rowIndex].Cells[0];

            }

        }

        private void ScheduleVisionTestToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            _OpenTestAppointmentsForm((int)clsTestType.enTestType.VisionTest);

        }

        private void ScheduleWrittenToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _OpenTestAppointmentsForm((int)clsTestType.enTestType.WrittenTest);


        }

        private void ScheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            _OpenTestAppointmentsForm((int)clsTestType.enTestType.StreetTest);

        }

        private void IssueToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int localDrivingLicenseApplicationID = Convert.ToInt32(DataGridViewLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            IssueDriverLicenseForFirstTimeForm issueDriverLicenseForFirstTime = new IssueDriverLicenseForFirstTimeForm(localDrivingLicenseApplicationID);
            _OpenFormWithReload(issueDriverLicenseForFirstTime);

        }

        private void ShowLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int localDrivingLicenseApplicationID = Convert.ToInt32(DataGridViewLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationByID(localDrivingLicenseApplicationID);

            DriverLicenseInfoForm licenseInfoFrom = new DriverLicenseInfoForm(localDrivingLicenseApplication.GetLicenseID());
            _OpenFormWithReload(licenseInfoFrom);


        }

        private void ShowPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int localDrivingLicenseApplicationID = Convert.ToInt32(DataGridViewLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationByID(localDrivingLicenseApplicationID);
            int PersonID = localDrivingLicenseApplication.PersonInfo.PersonID;

            ShowPersonLicensesHistoryForm licenseHistoryForm = new ShowPersonLicensesHistoryForm(PersonID);
            _OpenFormWithReload(licenseHistoryForm);

        }

        private void ComboBoxFilterApplications_SelectedIndexChanged(object sender, EventArgs e)
        {

            TextBoxFilter.Text = "";

            ComboBoxStatus.Text = "All";

            if (ComboBoxFilterApplications.Text != "None" && ComboBoxFilterApplications.Text != "Status")
            {
                ComboBoxStatus.Visible = false;
                TextBoxFilter.Visible = true;
                TextBoxFilter.Select();
            }
            else if (ComboBoxFilterApplications.Text == "Status")
            {

                ComboBoxStatus.Visible = true;
                TextBoxFilter.Visible = false;
                ComboBoxStatus.SelectedIndex = 0;


            }
            else
            {

                ComboBoxStatus.Visible = false;

                TextBoxFilter.Visible = false;

            }


        }

        private void TextBoxFilter_TextChanged(object sender, EventArgs e)
        {

            _ReloadLocalDrivingLicenseApplicationsTable();

        }

        private void TextBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (ComboBoxFilterApplications.Text == "LDLA ID")
            {

                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {

                    e.Handled = true;

                }

            }

        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {

            if (DataGridViewLocalDrivingLicenseApplications.CurrentRow != null)
            {
                DataGridViewLocalDrivingLicenseApplications.CurrentRow.ContextMenuStrip = ContextMenuStripManageLocalDrivingLicenseApplications;
            }

        }

        private void ContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {

            int localDrivingLicenseApplicationID = Convert.ToInt32(DataGridViewLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationByID(localDrivingLicenseApplicationID);

            if (localDrivingLicenseApplication == null)
            {
                ContextMenuStripManageLocalDrivingLicenseApplications.Enabled = false;
                return;
            }

            bool licenseExists = localDrivingLicenseApplication.IsLicenseIssued();

            bool passedVisionTest = localDrivingLicenseApplication.DoesPassTestType((int)clsTestType.enTestType.VisionTest);
            bool passedWrittenTest = localDrivingLicenseApplication.DoesPassTestType((int)clsTestType.enTestType.WrittenTest);
            bool passedStreetTest = localDrivingLicenseApplication.DoesPassTestType((int)clsTestType.enTestType.StreetTest);

            CancelApplicationToolStripMenuItem.Enabled = (localDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);

            DeleteApplicationToolStripMenuItem.Enabled = (localDrivingLicenseApplication.ApplicationStatus != clsApplication.enApplicationStatus.Completed);

            EditApplicationToolStripMenuItem.Enabled = (localDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New && !passedVisionTest);

            ScheduleTestsToolStripMenuItem.Enabled = (localDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New && !passedStreetTest);

            if (ScheduleTestsToolStripMenuItem.Enabled)
            {
                ScheduleVisionTestToolStripMenuItem.Enabled = !passedVisionTest;
                ScheduleWrittenToolStripMenuItem.Enabled = passedVisionTest && !passedWrittenTest;
                ScheduleStreetTestToolStripMenuItem.Enabled = passedVisionTest && passedWrittenTest && !passedStreetTest;

            }

            IssueToolStripMenuItem.Enabled = passedVisionTest && passedWrittenTest && passedStreetTest && !licenseExists && localDrivingLicenseApplication.ApplicationStatus != clsApplication.enApplicationStatus.Completed;

            ShowLicenseToolStripMenuItem.Enabled = (localDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.Completed && licenseExists);

        }

        private void ComboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            _ReloadLocalDrivingLicenseApplicationsTable();

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _OpenTestAppointmentsForm(int testTypeID)
        {

            int localDrivingLicenseApplicationID = Convert.ToInt32(DataGridViewLocalDrivingLicenseApplications.CurrentRow.Cells[0].Value);
            ManageTestAppointmentsForm TestAppointments = new ManageTestAppointmentsForm(localDrivingLicenseApplicationID, testTypeID);
            _OpenFormWithReload(TestAppointments);

        }

        private void _ReloadLocalDrivingLicenseApplicationsTable()
        {

            DataTable dataTable = _GetAllLocalDrivingLicenseApplications();

            DataView dataView = new DataView(dataTable);

            _ApplyFilter(dataView);

            DataGridViewLocalDrivingLicenseApplications.DataSource = dataView;
            LabelRecordsCount.Text = dataView.Count.ToString();


        }

        private void _ApplyFilter(DataView dataView)
        {

            if (ComboBoxFilterApplications.Text != "None" && ComboBoxFilterApplications.Text != "Status")
            {

                if (!string.IsNullOrWhiteSpace(TextBoxFilter.Text))
                {

                    switch (ComboBoxFilterApplications.Text)
                    {

                        case "LDLA ID":
                            dataView.RowFilter = $"[LDLA ID] = {TextBoxFilter.Text}";
                            break;

                        case "National No":
                            dataView.RowFilter = $"[National No] LIKE '{TextBoxFilter.Text}%'";
                            break;

                        case "Full Name":
                            dataView.RowFilter = $"[Full Name] LIKE '{TextBoxFilter.Text}%'";
                            break;

                        case "Status":
                            dataView.RowFilter = $"[Status] LIKE '{TextBoxFilter.Text}%'";
                            break;

                    }
                }
            }
            else if (ComboBoxFilterApplications.Text == "Status")
            {

                switch (ComboBoxStatus.Text)
                {

                    case "All":
                        dataView.RowFilter = $"Status LIKE 'New' OR Status LIKE 'Completed' OR Status LIKE 'Cancelled'";
                        break;
                    case "New":
                        dataView.RowFilter = $"Status LIKE 'New'";
                        break;

                    case "Completed":
                        dataView.RowFilter = $"Status LIKE 'Completed'";
                        break;

                    case "Cancelled":
                        dataView.RowFilter = $"Status LIKE 'Cancelled'";
                        break;


                }

            }

        }

        private DataTable _GetAllLocalDrivingLicenseApplications()
        {

            DataTable dataTable = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();

            dataTable.Columns["LocalDrivingLicenseApplicationID"].ColumnName = "LDLA ID";
            dataTable.Columns["ClassName"].ColumnName = "Class Name";
            dataTable.Columns["NationalNo"].ColumnName = "National No";
            dataTable.Columns["FullName"].ColumnName = "Full Name";
            dataTable.Columns["ApplicationDate"].ColumnName = "Application Date";
            dataTable.Columns["PassedTestCount"].ColumnName = "Passed Test";

            return dataTable;

        }

        private void _FillComboBoxFilters()
        {

            DataTable dataTable = _GetAllLocalDrivingLicenseApplications();

            ComboBoxFilterApplications.Items.Add("None");

            foreach (DataColumn column in dataTable.Columns)
            {

                if (column.ColumnName != "Class Name" && column.ColumnName != "Application Date" && column.ColumnName != "Passed Test")
                {


                    ComboBoxFilterApplications.Items.Add(column.ColumnName);


                }

            }

            ComboBoxFilterApplications.SelectedIndex = 0;

        }

        private void _LoadLocalDrivingLicenseApplicationsTable()
        {


            DataTable dataTable = _GetAllLocalDrivingLicenseApplications();

            DataView dataView = dataTable.DefaultView;
            DataGridViewLocalDrivingLicenseApplications.DataSource = dataView;
            LabelRecordsCount.Text = dataView.Count.ToString();

        }

        private void _OpenFormWithReload(Form form)
        {

            int rowIndex = -1;

            if (DataGridViewLocalDrivingLicenseApplications.RowCount > 0)
            {

                rowIndex = DataGridViewLocalDrivingLicenseApplications.SelectedRows[0].Index;


            }

            form.ShowDialog();
            _ReloadLocalDrivingLicenseApplicationsTable();

            if (rowIndex >= 0 && DataGridViewLocalDrivingLicenseApplications.RowCount > 0)
            {

                DataGridViewLocalDrivingLicenseApplications.Rows[rowIndex].Selected = true;
                DataGridViewLocalDrivingLicenseApplications.CurrentCell = DataGridViewLocalDrivingLicenseApplications.Rows[rowIndex].Cells[0];


            }

        }
    }
}
