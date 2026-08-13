using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_System
{
    public partial class ManagePeopleForm : Form
    {
        public ManagePeopleForm()
        {
            InitializeComponent();
        }

        private void ManagePeopleForm_Load(object sender, EventArgs e)
        {


            DataView dataView = clsPerson.GetAllPeople().DefaultView;

            DataGridViewPeople.DataSource = dataView;

            if (dataView.Table.Columns.Contains("Email"))
            {
                DataGridViewPeople.Columns["Email"].Width = 150;
            }

            _FillComboBoxFilters(dataView);

            lbRecordsCount.Text = dataView.Count.ToString();


        }

        private void ButtonAddNewPerson_Click(object sender, EventArgs e)
        {

            AddEditPersonInfoForm addEditPersonInfo = new AddEditPersonInfoForm();
            addEditPersonInfo.ShowDialog();
            _ReloadPeopleTable();


        }

        private void ComboBoxFilterPeople_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (ComboBoxFilterPeople.Text != "None")
            {
                TextBoxFilter.Text = "";
                TextBoxFilter.Visible = true;
                TextBoxFilter.Select();
            }
            else
                TextBoxFilter.Visible = false;

        }

        private void TextBoxFilter_TextChanged(object sender, EventArgs e)
        {

            _ReloadPeopleTable();

        }

        private void TextBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (ComboBoxFilterPeople.Text == "Person ID")
            {

                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    
                    e.Handled = true;

                }

            }

        }

        private void DataGridViewPeople_SelectionChanged(object sender, EventArgs e)
        {

            if (DataGridViewPeople.CurrentRow != null)
            {
                DataGridViewPeople.CurrentRow.ContextMenuStrip = contextMenuStrip1;
            }

        }

        private void ShowDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int personID = Convert.ToInt32(DataGridViewPeople.CurrentRow.Cells[0].Value);
            ShowPersonInfoForm personDetails = new ShowPersonInfoForm(personID);
            _OpenFormWithReload(personDetails);

        }

        private void AddNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddEditPersonInfoForm addEditPersonInfo = new AddEditPersonInfoForm();
            addEditPersonInfo.ShowDialog();
            _ReloadPeopleTable();

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int personID = Convert.ToInt32(DataGridViewPeople.CurrentRow.Cells[0].Value);
            AddEditPersonInfoForm addEditPersonInfoForm = new AddEditPersonInfoForm(personID);
            _OpenFormWithReload(addEditPersonInfoForm);

        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int personID = Convert.ToInt32(DataGridViewPeople.CurrentRow.Cells[0].Value);
            string imagePath = clsPerson.GetPersonInfoByID(personID).ImagePath;

            if (MessageBox.Show($"Are you sure you want to delete person [{personID}]", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                if (!clsPerson.DeletePerson(personID))
                {

                    MessageBox.Show("Cannot delete person because linked data exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        try
                        {
                            File.Delete(imagePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    _ReloadPeopleTable();
                    MessageBox.Show("Person Deleted Successfully.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void _FillComboBoxFilters(DataView dataView)
        {

            ComboBoxFilterPeople.Items.Add("None");
            ComboBoxFilterPeople.SelectedIndex = 0;

            if (dataView.Table.Columns.Count > 0)
            {
                foreach (DataColumn column in dataView.Table.Columns)
                {
                    if (column.ColumnName != "Date Of Birth" && column.ColumnName != "Address")
                    {

                        ComboBoxFilterPeople.Items.Add(column.ColumnName);

                    }
                }
            }

        }

        private void _ApplyFilter(DataView dataView)
        {

            if (!string.IsNullOrWhiteSpace(TextBoxFilter.Text))
            {

                switch (ComboBoxFilterPeople.Text)
                {

                    case "Person ID":
                        dataView.RowFilter = $"[Person ID] = {TextBoxFilter.Text.Trim()}";
                        break;

                    case "National No":
                        dataView.RowFilter = $"[National No] LIKE '{TextBoxFilter.Text.Trim()}%'";
                        break;

                    case "First Name":
                        dataView.RowFilter = $"[First Name] LIKE '{TextBoxFilter.Text.Trim()}%'";
                        break;

                    case "Second Name":
                        dataView.RowFilter = $"[Second Name] LIKE '{TextBoxFilter.Text.Trim()}%'";
                        break;

                    case "Third Name":
                        dataView.RowFilter = $"[Third Name] LIKE '{TextBoxFilter.Text.Trim()}%'";
                        break;

                    case "Last Name":
                        dataView.RowFilter = $"[Last Name] LIKE '{TextBoxFilter.Text.Trim()}%'";
                        break;

                    case "Gender":
                        dataView.RowFilter = $"[Gender] LIKE '{TextBoxFilter.Text.Trim()}%'";
                        break;

                    case "Nationality":
                        dataView.RowFilter = $"[Nationality] LIKE '{TextBoxFilter.Text.Trim()}%'";
                        break;

                    case "Phone":
                        dataView.RowFilter = $"[Phone] LIKE '{TextBoxFilter.Text.Trim()}%'";
                        break;

                    case "Email":
                        dataView.RowFilter = $"[Email] LIKE '{TextBoxFilter.Text.Trim()}%'";
                        break;

                }
            }

        }

        private void _ReloadPeopleTable()
        {

            DataTable dataTable = clsPerson.GetAllPeople();

            DataView dataView = new DataView(dataTable);

            _ApplyFilter(dataView);

            DataGridViewPeople.DataSource = dataView;
            lbRecordsCount.Text = dataView.Count.ToString();

        }

        private void _OpenFormWithReload(Form form)
        {

            int rowIndex = -1;

            if (DataGridViewPeople.RowCount > 0)
            {
                rowIndex = DataGridViewPeople.SelectedRows[0].Index;
            }

            form.ShowDialog(this);
            _ReloadPeopleTable();

            if (rowIndex != -1 && DataGridViewPeople.RowCount > 0)
            {
                DataGridViewPeople.Rows[rowIndex].Selected = true;
                DataGridViewPeople.CurrentCell = DataGridViewPeople.Rows[rowIndex].Cells[0];
            }

        }

    }
}
