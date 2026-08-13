using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_System
{
    public partial class UserControl_Search_Person : UserControl
    {

        public int PersonID
        {
            get { return userControl_Person_Details1.PersonID; }
        }

        public bool GroupBoxFilter_Enable
        {

            set
            {

                GroupBoxFilter.Enabled = value;

            }

        }

        public UserControl_Search_Person()
        {
            InitializeComponent();
          
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(ErrorProviderBlank.GetError(TextBoxSearch)))
            {
                this.ValidateChildren();
                MessageBox.Show("Some field are not valid!, please check the red icons.",
                              "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _SearchPerson();

        }

        private void DataBackEvent(int personID)
        {

            ComboBoxSearch.SelectedIndex = 0;
            TextBoxSearch.Text = personID.ToString();
            TextBoxSearch.SelectionStart = TextBoxSearch.Text.Length;
            userControl_Person_Details1.LoadPersonInfo(personID);
            ErrorProviderBlank.SetError(TextBoxSearch, string.Empty);


        }

        private void ButtonAddNewPerson_Click(object sender, EventArgs e)
        {

            AddEditPersonInfoForm addEditPersonInfo = new AddEditPersonInfoForm();
            addEditPersonInfo.DataSent += DataBackEvent;
            addEditPersonInfo.ShowDialog();
            TextBoxSearch.Focus();
            TextBoxSearch.SelectionStart = TextBoxSearch.TextLength;

        }

        private void ComboBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

            TextBoxSearch.Clear();
            TextBoxSearch.Select();

        }

        private void TextBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)13)
            {
                ButtonSearch.PerformClick();
            }

            if (ComboBoxSearch.Text == "Person ID")
            {

                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {

                    e.Handled = true;

                }

            }

        }

        private void UserControl_Search_Person_Load(object sender, EventArgs e)
        {

            ComboBoxSearch.SelectedItem = "Person ID";


        }

        private void TextBoxSearch_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TextBoxSearch.Text.Trim()))
            {

                ErrorProviderBlank.SetError(TextBoxSearch, "This field is required!");

            }
            else { ErrorProviderBlank.SetError(TextBoxSearch, string.Empty); }

        }

        public void LoadPersonInfo(int personID)
        {

            userControl_Person_Details1.LoadPersonInfo(personID);

            TextBoxSearch.Text = personID.ToString();

        }

        public void FilterFocus()
        {

            TextBoxSearch.Focus();

        }

        private void _SearchPerson()
        {

            if (string.IsNullOrWhiteSpace(TextBoxSearch.Text.Trim())) return;

            switch (ComboBoxSearch.Text)
            {

                case "Person ID":
                    int.TryParse(TextBoxSearch.Text.Trim(), out int personID);
                    userControl_Person_Details1.LoadPersonInfo(personID);
                    break;

                case "National No":
                    userControl_Person_Details1.LoadPersonInfo(TextBoxSearch.Text.Trim());
                    break;

            }

        }


    }
}
