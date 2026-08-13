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
    public partial class AddEditPersonInfoForm : Form
    {
        enum enMode { AddNew, Update }

        enMode _Mode;

        bool _FileDialogImagePersonIsOpen = false;

        bool _RemoveImagePersonIsClick = false;

        public delegate void DataSent_Handler(int PersonID);

        public event DataSent_Handler DataSent;

        int _PersonID = -1;

        clsPerson _Person;

        public AddEditPersonInfoForm()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;

        }

        public AddEditPersonInfoForm(int personID)
        {
            InitializeComponent();
            _PersonID = personID;
            _Mode = enMode.Update;

        }

        private void AddEditPersonInfoForm_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_Mode == enMode.Update)
            { _LoadData(); }
            else { _Person =  new clsPerson();}

            LinkLabelRemove.Visible = (PictureBoxPerson.ImageLocation != null);

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

            if (!_ValidateChildrenForSave())
            {
                return;
            }

            _ReadPersonInfo();

            _HandelPersonImage();

            if (_Person.Save())
            {


                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (_Mode == enMode.AddNew)
                {

                    _PersonID = _Person.PersonID;
                    LabelPersonID.Text = _PersonID.ToString();
                    LabelTitle.Text = "Update Person";
                    _Mode = enMode.Update;

                }

                DataSent?.Invoke(_PersonID);
            }
            else
            {

                MessageBox.Show("Data Save Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

            _FileDialogImagePersonIsOpen = false;
            _RemoveImagePersonIsClick = false;

        }

        private void Blank_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(((TextBox)sender).Text))
            {

                errorProviderBlank.SetError((TextBox)sender, "This field must be entered");

            }
            else
            {

                errorProviderBlank.SetError((TextBox)sender, string.Empty);


            }

        }

        private void TextBoxNationalNo_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TextBoxNationalNo.Text.Trim()))
            {

                errorProviderNationalNo.SetError(TextBoxNationalNo, "This field must be entered");


            }
            else
            {

                errorProviderNationalNo.Clear();

                if (_Mode == enMode.Update ? _Person.NationalNo != TextBoxNationalNo.Text.Trim() : true)
                {

                    if (clsPerson.IsPersonExists(TextBoxNationalNo.Text))
                    {

                        errorProviderNationalNo.SetError((TextBox)sender, "National Number is used for another person!");

                        e.Cancel = true;

                    }
                    else
                        errorProviderNationalNo.Clear();

                }

            }

        }

        private void TextBoxEmail_Validating(object sender, CancelEventArgs e)
        {


            if (!string.IsNullOrWhiteSpace(TextBoxEmail.Text))
            {

                if (!clsValidation.ValidateEmail(TextBoxEmail.Text))
                {
                    errorProviderEmail.SetError(TextBoxEmail, "Invalid Email Address Format!");

                }
                else
                {
                    errorProviderEmail.SetError(TextBoxEmail, string.Empty);

                }

            }
            else
            {
                errorProviderEmail.SetError(TextBoxEmail, string.Empty);

            }

        }
                                                
        private void LinkLabelSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            openFileDialogImagePerson.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialogImagePerson.ShowDialog() == DialogResult.OK)
            {

                _FileDialogImagePersonIsOpen = true;
                PictureBoxPerson.Load(openFileDialogImagePerson.FileName);
                LinkLabelRemove.Visible = true;

            }

        }

        private void LinkLabelRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            _RemoveImagePersonIsClick = true;
            PictureBoxPerson.ImageLocation = null;
            LinkLabelRemove.Visible = false;

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void TextBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {


                e.Handled = true;

            }

        }

        private void _FillCountriesInComboBox()
        {

            DataTable dt = clsCountry.GetAllCountries();

            foreach (DataRow row in dt.Rows)
            {

                ComboBoxCountry.Items.Add(row["CountryName"].ToString());

            }


        }

        private void _ResetDefaultValues()
        {

            _FillCountriesInComboBox();

            if (_Mode == enMode.Update)
            {
                LabelTitle.Text = "Update Person";
            }

            dateTimePickerDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);

            dateTimePickerDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            ComboBoxCountry.SelectedItem = "Algeria";

        }

        private void _LoadData()
        {

            _Person = clsPerson.GetPersonInfoByID(_PersonID);

            if (_Person == null)
            {

                MessageBox.Show($"No person with person ID = {_PersonID}", "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Visible = false;
                this.Close();
                return;

            }

            LabelPersonID.Text = _Person.PersonID.ToString();
            TextBoxFirstName.Text = _Person.FirstName;
            TextBoxLastName.Text = _Person.LastName;
            TextBoxSecondName.Text = _Person.SecondName;
            TextBoxThirdName.Text = _Person.ThirdName;
            TextBoxPhone.Text = _Person.Phone;
            TextBoxEmail.Text = _Person.Email;
            TextBoxAddress.Text = _Person.Address;
            ComboBoxCountry.Text = _Person.countryInfo.CountryName;
            dateTimePickerDateOfBirth.Text = _Person.DateOfBirth.ToString();

            if (_Person.Gender == "Male")
            {
                rbMale.Checked = true;

            }
            else if (_Person.Gender == "Female")
            {
                rbFemale.Checked = true;

            }

            TextBoxNationalNo.Text = _Person.NationalNo;

            if (!string.IsNullOrEmpty(_Person.ImagePath))
            {

                if (File.Exists(_Person.ImagePath))
                {
                    PictureBoxPerson.ImageLocation = _Person.ImagePath;
                }

            }

        }

        private void _ReadPersonInfo()
        {

            _Person.FirstName = TextBoxFirstName.Text.Trim();
            _Person.SecondName = TextBoxSecondName.Text.Trim();
            _Person.ThirdName = TextBoxThirdName.Text.Trim();
            _Person.LastName = TextBoxLastName.Text.Trim();
            _Person.Email = TextBoxEmail.Text.Trim();
            _Person.Phone = TextBoxPhone.Text.Trim();
            _Person.NationalNo = TextBoxNationalNo.Text.Trim();
            _Person.Address = TextBoxAddress.Text.Trim();
            _Person.DateOfBirth = dateTimePickerDateOfBirth.Value.Date;

            _Person.NationalityCountryID = clsCountry.GetCountryIDByName(ComboBoxCountry.Text.ToUpper());

            if (rbMale.Checked)
            {
                _Person.GenderN = 0;
            }
            else if (rbFemale.Checked)
            {
                _Person.GenderN = 1;
            }


        }

        private void _HandelPersonImage()
        {

            if (_FileDialogImagePersonIsOpen || _RemoveImagePersonIsClick)
            {

                try
                {

                    if (!string.IsNullOrEmpty(_Person.ImagePath) && File.Exists(_Person.ImagePath))
                    {

                        File.Delete(_Person.ImagePath);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (PictureBoxPerson.ImageLocation != null)
                {

                    string sourceFile = PictureBoxPerson.ImageLocation;
                    string destinationFile = "";

                    if (clsUtil.CopyImageToPeopleImagesFolder(PictureBoxPerson.ImageLocation, ref destinationFile))
                    {

                        _Person.ImagePath = destinationFile;

                    }
                    else
                    {

                        MessageBox.Show("Error Coping image file", "Error", MessageBoxButtons.OK);

                    }

                }
                else
                {

                    _Person.ImagePath = null;

                }

            }

        }

        private bool _ValidateChildrenForSave()
        {

            this.ValidateChildren();

            if (!string.IsNullOrEmpty(errorProviderBlank.GetError(TextBoxFirstName)) ||
                !string.IsNullOrEmpty(errorProviderBlank.GetError(TextBoxSecondName)) ||
                !string.IsNullOrEmpty(errorProviderBlank.GetError(TextBoxLastName)) ||
                !string.IsNullOrEmpty(errorProviderBlank.GetError(TextBoxPhone)) ||
                !string.IsNullOrEmpty(errorProviderBlank.GetError(TextBoxAddress)) ||
                !string.IsNullOrEmpty(errorProviderEmail.GetError(TextBoxEmail)) ||
                !string.IsNullOrEmpty(errorProviderNationalNo.GetError(TextBoxNationalNo)))
            {
                MessageBox.Show("Some fields are not valid!, please check the red icons.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


    }
}
