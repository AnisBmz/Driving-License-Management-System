using DVLD_Business;
using DVLD_System.Global_Classes;
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
    public partial class ManageUsersForm : Form
    {

        public bool IsSignOut = false;

        public ManageUsersForm()
        {
            InitializeComponent();

        }

        private void ManageUsersForm_Load(object sender, EventArgs e)
        {


            DataView dataView = new DataView(clsUser.GetAllUsers());

            DataGridViewUsers.DataSource = dataView;

            if (dataView.Table.Columns.Count > 0)
            {

                DataGridViewUsers.Columns["Full Name"].Width = 300;

            }

            _FillComboBoxFilters(dataView);

            LabelRecordsCount.Text = dataView.Count.ToString();


        }

        private void DataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {

            if (DataGridViewUsers.CurrentRow != null)
            {
                DataGridViewUsers.CurrentRow.ContextMenuStrip = ContextMenuStrip;
            }

        }

        private void ComboBoxFilterUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

            TextBoxSearch.Text = "";
            ComboBoxIsActive.SelectedIndex = 0;

            if (ComboBoxFilterUsers.Text != "None" && ComboBoxFilterUsers.Text != "Is Active")
            {
                TextBoxSearch.Visible = true;
                ComboBoxIsActive.Visible = false;
                TextBoxSearch.Select();
            }
            else if (ComboBoxFilterUsers.Text == "Is Active")
            {

                TextBoxSearch.Visible = false;
                ComboBoxIsActive.Visible = true;
                ComboBoxIsActive.Select();

            }
            else
            {

                TextBoxSearch.Visible = false;
                ComboBoxIsActive.Visible = false;

            }


        }

        private void TextBoxFilter_TextChanged(object sender, EventArgs e)
        {

            _ReloadUsersTable();

        }

        private void TextBoxFilter_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(ComboBoxFilterUsers.SelectedItem.ToString() == "User ID" || ComboBoxFilterUsers.SelectedItem.ToString() == "Person ID")
            {

                if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {

                    e.Handled = true;

                }

            }

        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {

            AddEditUserForm addNewUser = new AddEditUserForm();
            addNewUser.ShowDialog();
            _ReloadUsersTable();

        }

        private void AddNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AddEditUserForm addNewUser = new AddEditUserForm();
            addNewUser.ShowDialog();
            _ReloadUsersTable();

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int userID = Convert.ToInt32(DataGridViewUsers.CurrentRow.Cells[0].Value);
            AddEditUserForm addNewUser = new AddEditUserForm(userID);
            _OpenFormWithReload(addNewUser);

        }

        private void ShowDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int userID = Convert.ToInt32(DataGridViewUsers.CurrentRow.Cells[0].Value);
            UserDetailsForm userDetailsForm = new UserDetailsForm(userID);
            _OpenFormWithReload(userDetailsForm);

        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int userID = Convert.ToInt32(DataGridViewUsers.SelectedCells[0].Value);


            if (MessageBox.Show($"Are you sure you want to delete user [{userID}]", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                if (userID == clsGlobalSettings.CurrentUser.UserID)
                {
                    if (MessageBox.Show($"This is your own account." +
                        $" Deletion will log you out and permanently remove access. Do you still want to proceed?",
                        "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                    {
                        return;
                    }

                }

                if (clsUser.DeleteUser(userID))
                {

                    _ReloadUsersTable();

                    if (userID == clsGlobalSettings.CurrentUser.UserID)
                    {

                        IsSignOut = true;
                        clsUtil.ClearRememberMeData();
                        this.Close();

                    }

                    MessageBox.Show("User has been deleted Successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else
                {
                    MessageBox.Show("Cannot delete user because linked data exists.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

        private void ComboBoxIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {

            _ReloadUsersTable();

        }

        private void ChangePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int userID = Convert.ToInt32(DataGridViewUsers.SelectedCells[0].Value);
            ChangePasswordForm changePassword = new ChangePasswordForm(userID);
            _OpenFormWithReload(changePassword);

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void _FillComboBoxFilters(DataView dataView)
        {

            ComboBoxFilterUsers.Items.Add("None");
            ComboBoxFilterUsers.SelectedIndex = 0;

            if (dataView.Table.Columns.Count > 0)
            {

                foreach (DataColumn column in dataView.Table.Columns)
                {

                    ComboBoxFilterUsers.Items.Add(column.ColumnName);

                }

            }

        }

        private void _ReloadUsersTable()
        {


            DataTable dataTable = clsUser.GetAllUsers();
            DataView dataView = new DataView(dataTable);

            _ApplyFilter(dataView);

            DataGridViewUsers.DataSource = dataView;
            LabelRecordsCount.Text = dataView.Count.ToString();


        }

        private void _ApplyFilter(DataView dataView)
        {

            if (ComboBoxFilterUsers.Text != "None" && ComboBoxFilterUsers.Text != "Is Active")
            {

                if (!string.IsNullOrWhiteSpace(TextBoxSearch.Text))
                {

                    switch (ComboBoxFilterUsers.Text)
                    {

                        case "User ID":
                            dataView.RowFilter = $"[User ID] = {TextBoxSearch.Text}";
                            break;

                        case "Person ID":
                            dataView.RowFilter = $"[Person ID] = {TextBoxSearch.Text}";
                            break;

                        case "Full Name":
                            dataView.RowFilter = $"[Full Name] LIKE '{TextBoxSearch.Text}%'";
                            break;


                        case "UserName":
                            dataView.RowFilter = $"UserName LIKE '{TextBoxSearch.Text}%'";
                            break;

                    }

                }

            }
            else if (ComboBoxFilterUsers.Text == "Is Active")
            {

                switch (ComboBoxIsActive.Text)
                {

                    case "All":
                        dataView.RowFilter = $"[Is Active] = True OR [Is Active] = False";
                        break;

                    case "Yes":
                        dataView.RowFilter = $"[Is Active] = True";
                        break;

                    case "No":
                        dataView.RowFilter = $"[Is Active] = False";
                        break;

                }

            }

        }

        private void _OpenFormWithReload(Form form)
        {

            int rowIndex = -1;

            if (DataGridViewUsers.RowCount > 0)
            {

                rowIndex = DataGridViewUsers.SelectedRows[0].Index;


            }

            form.ShowDialog(this);
            _ReloadUsersTable();

            if (rowIndex != -1 && DataGridViewUsers.RowCount > 0)
            {

                DataGridViewUsers.Rows[rowIndex].Selected = true;
                DataGridViewUsers.CurrentCell = DataGridViewUsers.Rows[rowIndex].Cells[0];

            }

        }

    }
}
