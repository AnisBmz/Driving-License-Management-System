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
using System.Windows.Forms.VisualStyles;

namespace DVLD_System
{
    public partial class ManageInternationalLicenseApplicationsForm : Form
    {
        public ManageInternationalLicenseApplicationsForm()
        {
            InitializeComponent();
        }

        private void ManageInternationalLicenseApplicationsForm_Load(object sender, EventArgs e)
        {


            _LoadInternationalLicenses();
            _FillComboBoxFilters();

        }

        private void ButtonAddNewInternationalLicenseApplication_Click(object sender, EventArgs e)
        {

            NewInternationalLicenseApplicationForm newInternationalLicenseApplication = new NewInternationalLicenseApplicationForm();
            _OpenFormWithReload(newInternationalLicenseApplication);

        }

        private void DataGridViewInternationalLicenseApplications_SelectionChanged(object sender, EventArgs e)
        {

            if (DataGridViewInternationalLicenseApplications.CurrentRow != null)
            {
                DataGridViewInternationalLicenseApplications.CurrentRow.ContextMenuStrip = contextMenuStripManageInternationalLicenseApplications;
            }

        }

        private void TextBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;

            }

        }

        private void ComboBoxFilterApplications_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxFilter.Text = "";
            ComboBoxIsActive.SelectedIndex = 0;

            if (ComboBoxFilter.Text != "None" && ComboBoxFilter.Text != "Is Active")
            {
                ComboBoxIsActive.Visible = false;
                TextBoxFilter.Visible = true;
                TextBoxFilter.Select();
            }
            else if (ComboBoxFilter.Text == "Is Active")
            {
                ComboBoxIsActive.Visible = true;
                TextBoxFilter.Visible = false;
                ComboBoxIsActive.SelectedIndex = 0;
            }
            else
            {
                TextBoxFilter.Visible = false;
                ComboBoxIsActive.Visible = false;
            }
        }

        private void ComboBoxIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _ReloadInternationalDrivingLicenses();
        }

        private void TextBoxFilter_TextChanged(object sender, EventArgs e)
        {

            _ReloadInternationalDrivingLicenses();

        }

        private void ShowPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int DriverID = Convert.ToInt32(DataGridViewInternationalLicenseApplications.CurrentRow.Cells["Driver ID"].Value);
            int personID = clsDriver.GetDriverInfoByID(DriverID).PersonID;
            ShowPersonInfoForm personDetails = new ShowPersonInfoForm(personID);
            _OpenFormWithReload(personDetails);

        }

        private void ShowLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int internationalLicenseID = Convert.ToInt32(DataGridViewInternationalLicenseApplications.CurrentRow.Cells["Int.License ID"].Value);

            InternationalDriverInfoForm internationalDriverInfo = new InternationalDriverInfoForm(internationalLicenseID);
            _OpenFormWithReload(internationalDriverInfo);


        }

        private void ShowPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int DriverID = Convert.ToInt32(DataGridViewInternationalLicenseApplications.CurrentRow.Cells["Driver ID"].Value);
            int personID = clsDriver.GetDriverInfoByID(DriverID).PersonID;
            ShowPersonLicensesHistoryForm licenseHistory = new ShowPersonLicensesHistoryForm(personID);
            _OpenFormWithReload(licenseHistory);

        }

        private void _LoadInternationalLicenses()
        {

            DataTable dataTable = clsInternationalLicense.GetAllInternationalDrivingLicenses();
            DataGridViewInternationalLicenseApplications.DataSource = dataTable;
            LabelRecordsCount.Text = dataTable.Rows.Count.ToString();

        }

        private void _FillComboBoxFilters()
        {

            DataTable dt = clsInternationalLicense.GetAllInternationalDrivingLicenses();

            ComboBoxFilter.Items.Add("None");

            foreach (DataColumn column in dt.Columns)
            {

                if (column.ColumnName != "Issue Date" && column.ColumnName != "Expiration Date")
                {


                    ComboBoxFilter.Items.Add(column.ColumnName);


                }

            }

            ComboBoxFilter.SelectedIndex = 0;

        }

        private void _ApplyFilter(DataView dataView)
        {

            if (ComboBoxFilter.Text != "None" && ComboBoxFilter.Text != "Is Active")
            {

                if (!string.IsNullOrWhiteSpace(TextBoxFilter.Text))
                {

                    switch (ComboBoxFilter.Text)
                    {

                        case "Int.License ID":
                            dataView.RowFilter = $"[Int.License ID] = {TextBoxFilter.Text}";
                            break;

                        case "Application ID":
                            dataView.RowFilter = $"[Application ID] = {TextBoxFilter.Text}";
                            break;

                        case "Driver ID":
                            dataView.RowFilter = $"[Driver ID] = {TextBoxFilter.Text}";
                            break;


                        case "L.License ID":
                            dataView.RowFilter = $"[L.License ID] = {TextBoxFilter.Text}";
                            break;

                    }

                }

            }
            else if (ComboBoxFilter.Text == "Is Active")
            {

                switch (ComboBoxIsActive.Text)
                {
                    case "All":
                        dataView.RowFilter = $"[Is Active] = 1 OR [Is Active] = 0";
                        break;
                    case "Yes":
                        dataView.RowFilter = $"[Is Active] = 1";
                        break;

                    case "No":
                        dataView.RowFilter = $"[Is Active] = 0";
                        break;

                }
            }

        }

        private void _ReloadInternationalDrivingLicenses()
        {

            DataTable dataTable = clsInternationalLicense.GetAllInternationalDrivingLicenses();

            DataView dataView = new DataView(dataTable);

            _ApplyFilter(dataView);

            DataGridViewInternationalLicenseApplications.DataSource = dataView;
            LabelRecordsCount.Text = dataView.Count.ToString();


        }

        private void _OpenFormWithReload(Form form)
        {

            int rowIndex = -1;

            if (DataGridViewInternationalLicenseApplications.RowCount > 0)
            {

                rowIndex = DataGridViewInternationalLicenseApplications.SelectedRows[0].Index;


            }

            form.ShowDialog();
            _ReloadInternationalDrivingLicenses();

            if (rowIndex >= 0 && DataGridViewInternationalLicenseApplications.RowCount > 0)
            {

                DataGridViewInternationalLicenseApplications.Rows[rowIndex].Selected = true;
                DataGridViewInternationalLicenseApplications.CurrentCell = DataGridViewInternationalLicenseApplications.Rows[rowIndex].Cells[0];


            }

        }

    }
}
