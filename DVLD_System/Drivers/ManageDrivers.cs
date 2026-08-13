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
    public partial class ManageDriversForm : Form
    {
        public ManageDriversForm()
        {
            InitializeComponent();
        }

        private void ManageDriversForm_Load(object sender, EventArgs e)
        {

            DataView dataView = new DataView(clsDriver.GetAllDrivers());
            DataGridViewDrivers.DataSource = dataView;

            if (dataView.Table.Columns.Count > 0)
            {
                DataGridViewDrivers.Columns["Full Name"].Width = 300;
            }

            _FillComboBoxFilters(dataView);
            LabelRecordsCount.Text = dataView.Count.ToString();

        }

        private void DataGridViewDrivers_SelectionChanged(object sender, EventArgs e)
        {

            if (DataGridViewDrivers.CurrentRow != null)
            {
                DataGridViewDrivers.CurrentRow.ContextMenuStrip = ContextMenuStripManageDriver;
            }

        }

        private void ComboBoxFilterDrivers_SelectedIndexChanged(object sender, EventArgs e)
        {

            TextBoxFilter.Text = "";
            if (ComboBoxFilterDrivers.Text == "None")
            {
                TextBoxFilter.Visible = false;
            }
            else
            {
                TextBoxFilter.Visible = true;
                TextBoxFilter.Select();
            }

        }

        private void TextBoxFilter_TextChanged(object sender, EventArgs e)
        {


            _ReloadDriversTable();


        }

        private void TextBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (ComboBoxFilterDrivers.Text == "Person ID" || ComboBoxFilterDrivers.Text == "Driver ID")
            {

                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {

                    e.Handled = true;

                }

            }

        }

        private void ShowPersonLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int PersonID = Convert.ToInt32(DataGridViewDrivers.CurrentRow.Cells["Person ID"].Value);  
            ShowPersonLicensesHistoryForm licenseHistoryForm = new ShowPersonLicensesHistoryForm(PersonID);
            _OpenFormWithReload(licenseHistoryForm);

        }

        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int PersonID = Convert.ToInt32(DataGridViewDrivers.CurrentRow.Cells["Person ID"].Value);
           
            ShowPersonInfoForm personDetailsForm = new ShowPersonInfoForm(PersonID);
            _OpenFormWithReload(personDetailsForm);

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _ReloadDriversTable()
        {


            DataTable dataTable = clsDriver.GetAllDrivers();

            DataView dataView = new DataView(dataTable);

            _ApplyFilter(dataView);

            DataGridViewDrivers.DataSource = dataView;
            LabelRecordsCount.Text = dataView.Count.ToString();

        }

        private void _ApplyFilter(DataView dataView)
        {

            if (!string.IsNullOrWhiteSpace(TextBoxFilter.Text))
            {

                switch (ComboBoxFilterDrivers.Text)
                {

                    case "Person ID":
                        dataView.RowFilter = $"[Person ID] = {TextBoxFilter.Text.Trim()}";
                        break;

                    case "Driver ID":
                        dataView.RowFilter = $"[Driver ID] = {TextBoxFilter.Text.Trim()}";
                        break;

                    case "National No.":
                        dataView.RowFilter = $"[National No.] LIKE '{TextBoxFilter.Text.Trim()}%'";
                        break;

                    case "Full Name":
                        dataView.RowFilter = $"[Full Name] LIKE '{TextBoxFilter.Text.Trim()}%'";
                        break;

                }


            }

        }

        private void _FillComboBoxFilters(DataView dataView)
        {

            ComboBoxFilterDrivers.Items.Add("None");

            foreach (DataColumn column in dataView.Table.Columns)
            {

                if (column.ColumnName != "Active Licenses" && column.ColumnName != "Date")
                {

                    ComboBoxFilterDrivers.Items.Add(column.ColumnName);

                }

            }

            ComboBoxFilterDrivers.SelectedIndex = 0;

        }

        private void _OpenFormWithReload(Form form)
        {

            int rowIndex = -1;
            if (DataGridViewDrivers.RowCount > 0)
            {
                rowIndex = DataGridViewDrivers.SelectedRows[0].Index;
            }

            form.ShowDialog();
            _ReloadDriversTable();

            if (rowIndex >= 0 && DataGridViewDrivers.RowCount > 0)
            {
                DataGridViewDrivers.Rows[rowIndex].Selected = true;
                DataGridViewDrivers.CurrentCell = DataGridViewDrivers.Rows[rowIndex].Cells[0];
            }

        }

    }
}
