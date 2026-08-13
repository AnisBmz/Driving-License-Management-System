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
    public partial class ManageDetainedLicensesForm : Form
    {
        public ManageDetainedLicensesForm()
        {
            InitializeComponent();
        }

        private void ManageDetainedLicensesForm_Load(object sender, EventArgs e)
        {

            _FillComboBoxFilters();
            _LoadDetainedLicenses();

        }

        private void TextBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (ComboBoxFilter.Text == "Detain ID" || ComboBoxFilter.Text == "Released Application ID")
            {

                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {

                    e.Handled = true;

                }

            }

        }

        private void ComboBoxFilterApplications_SelectedIndexChanged(object sender, EventArgs e)
        {

            TextBoxFilter.Text = "";

            ComboBoxIsReleased.Text = "All";

            if (ComboBoxFilter.Text != "None" && ComboBoxFilter.Text != "Is Released")
            {
                ComboBoxIsReleased.Visible = false;
                TextBoxFilter.Visible = true;
                TextBoxFilter.Select();
            }
            else if (ComboBoxFilter.Text == "Is Released")
            {

                ComboBoxIsReleased.Visible = true;
                TextBoxFilter.Visible = false;
                ComboBoxIsReleased.SelectedIndex = 0;


            }
            else
            {

                ComboBoxIsReleased.Visible = false;

                TextBoxFilter.Visible = false;

            }


        }

        private void ComboBoxIsReleased_SelectedIndexChanged(object sender, EventArgs e)
        {

            _ReloadDetainedLicenses();

        }

        private void TextBoxFilter_TextChanged(object sender, EventArgs e)
        {
            _ReloadDetainedLicenses();
        }

        private void DataGridViewDetainedLicenses_SelectionChanged(object sender, EventArgs e)
        {

            if (DataGridViewDetainedLicenses.CurrentRow != null)
            {
                DataGridViewDetainedLicenses.CurrentRow.ContextMenuStrip = contextMenuStripManageDetainedLicenses;
            }
        }

        private void ContextMenuStripManageDetainedLicenses_Opening(object sender, CancelEventArgs e)
        {

            bool isReleased = Convert.ToBoolean(DataGridViewDetainedLicenses.CurrentRow.Cells["Is Released"].Value);

            ReleaseDetainedLicenseToolStripMenuItem.Enabled = !isReleased;
        }

        private void ButtonAddDetainLicense_Click(object sender, EventArgs e)
        {

            DetainLicenseForm detainLicense = new DetainLicenseForm();
            detainLicense.ShowDialog();
            _LoadDetainedLicenses();

        }

        private void ButtonReleaseLicense_Click(object sender, EventArgs e)
        {

            ReleaseDetainedLicenseForm ReleaseDetainedLicense = new ReleaseDetainedLicenseForm();
            ReleaseDetainedLicense.ShowDialog();
            _LoadDetainedLicenses();

        }

        private void ShowPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string nationalNo = (DataGridViewDetainedLicenses.CurrentRow.Cells["National No"].Value).ToString();
            ShowPersonInfoForm personDetails = new ShowPersonInfoForm(nationalNo);
            _OpenFormWithReload(personDetails, true);

        }

        private void ShowLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int licenseID = Convert.ToInt32(DataGridViewDetainedLicenses.CurrentRow.Cells["License ID"].Value);
            DriverLicenseInfoForm driverLicenseInfo = new DriverLicenseInfoForm(licenseID);
            _OpenFormWithReload(driverLicenseInfo, false);

        }

        private void ShowPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string nationalNo = (DataGridViewDetainedLicenses.CurrentRow.Cells["National No"].Value).ToString();
            int personID = clsPerson.GetPersonIDByNationalNo(nationalNo);
            ShowPersonLicensesHistoryForm licenseHistory = new ShowPersonLicensesHistoryForm(personID);
            _OpenFormWithReload(licenseHistory, true);


        }

        private void ReleaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int licenseID = Convert.ToInt32(DataGridViewDetainedLicenses.CurrentRow.Cells["License ID"].Value);
            ReleaseDetainedLicenseForm ReleaseDetainedLicense = new ReleaseDetainedLicenseForm(licenseID);
            _OpenFormWithReload(ReleaseDetainedLicense, true);


        }

        private void _LoadDetainedLicenses()
        {

            DataTable dataTable = clsDetainedLicense.GetAllDetainedLicenses();
            DataGridViewDetainedLicenses.DataSource = dataTable;

            if (dataTable.Columns.Count > 0)
            {

                DataGridViewDetainedLicenses.Columns["Full Name"].Width = 230;
                DataGridViewDetainedLicenses.Columns["Detain Date"].Width = 120;
                DataGridViewDetainedLicenses.Columns["Release Date"].Width = 120;

            }


            LabelRecordsCount.Text = dataTable.Rows.Count.ToString();

            ComboBoxFilter.SelectedIndex = 0;
            TextBoxFilter.Text = "";
            ComboBoxIsReleased.SelectedIndex = 0;


        }

        private void _FillComboBoxFilters()
        {

            ComboBoxFilter.Items.Add("None");
            ComboBoxFilter.Items.Add("Detain ID");
            ComboBoxFilter.Items.Add("Full Name");
            ComboBoxFilter.Items.Add("National No");
            ComboBoxFilter.Items.Add("Is Released");
            ComboBoxFilter.Items.Add("Released Application ID");

            ComboBoxFilter.SelectedIndex = 0;

        }

        private void _ReloadDetainedLicenses()
        {
            DataTable dataTable = clsDetainedLicense.GetAllDetainedLicenses();

            DataView dataView = new DataView(dataTable);

            _ApplyFilter(dataView);

            DataGridViewDetainedLicenses.DataSource = dataView;
            LabelRecordsCount.Text = dataView.Count.ToString();
        }

        private void _ApplyFilter(DataView dataView)
        {

            if (ComboBoxFilter.Text != "None" && ComboBoxFilter.Text != "Is Released")
            {

                if (!string.IsNullOrWhiteSpace(TextBoxFilter.Text))
                {

                    switch (ComboBoxFilter.Text)
                    {

                        case "Detain ID":
                            dataView.RowFilter = $"[Detain ID] = {TextBoxFilter.Text}";
                            break;

                        case "National No":
                            dataView.RowFilter = $"[National No] LIKE '{TextBoxFilter.Text}%'";
                            break;

                        case "Full Name":
                            dataView.RowFilter = $"[Full Name] LIKE '{TextBoxFilter.Text}%'";
                            break;

                        case "Release A.ID":
                            dataView.RowFilter = $"[Release A.ID] = '{TextBoxFilter.Text}'";
                            break;

                    }
                }
            }
            else if (ComboBoxFilter.Text == "Is Released")
            {

                switch (ComboBoxIsReleased.Text)
                {
                    case "All":
                        dataView.RowFilter = $"[Is Released] = 1 OR [Is Released] = 0";
                        break;
                    case "Yes":
                        dataView.RowFilter = $"[Is Released] = 1";
                        break;

                    case "No":
                        dataView.RowFilter = $"[Is Released] = 0";
                        break;

                }
            }

        }

        private void _OpenFormWithReload(Form form, bool reload)
        {

            int rowIndex = -1;

            if (DataGridViewDetainedLicenses.RowCount > 0)
            {

                rowIndex = DataGridViewDetainedLicenses.SelectedRows[0].Index;


            }

            form.ShowDialog();

            if (reload)
            {
                _ReloadDetainedLicenses();
            }

            if (rowIndex >= 0 && DataGridViewDetainedLicenses.RowCount > 0)
            {

                DataGridViewDetainedLicenses.Rows[rowIndex].Selected = true;
                DataGridViewDetainedLicenses.CurrentCell = DataGridViewDetainedLicenses.Rows[rowIndex].Cells[0];


            }

        }

    }
}
