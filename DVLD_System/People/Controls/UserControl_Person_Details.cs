using DVLD_Business;
using DVLD_System.Properties;
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
    public partial class UserControl_Person_Details : UserControl
    {

        private int _PersonID = -1;

        public int PersonID { get { return _PersonID; } }

        private clsPerson _Person;

        public UserControl_Person_Details()
        {
            InitializeComponent();
        }

        private void LinkLabelEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            AddEditPersonInfoForm addEditPersonInfo = new AddEditPersonInfoForm(_PersonID);
            addEditPersonInfo.ShowDialog();
            LoadPersonInfo(_PersonID);

        }

        public void LoadPersonInfo(int personID)
        {

            _Person = clsPerson.GetPersonInfoByID(personID);

            if (_Person == null)
            {

                _ResetPersonInfo();
                MessageBox.Show($"No person with personID = {personID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _FillPersonInfo();
            _PersonID = personID;

        }

        public void LoadPersonInfo(string nationalNo)
        {

            int personID = clsPerson.GetPersonIDByNationalNo(nationalNo);
            _Person = clsPerson.GetPersonInfoByID(personID);

            if (_Person == null)
            {

                _ResetPersonInfo();
                MessageBox.Show($"No person with nationalNo = {nationalNo}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            _FillPersonInfo();
            _PersonID = personID;

        }

        private void _LoadPersonImage()
        {

            if (_Person.ImagePath.ToString() == "")
            {

                if (LabelGender.Text == "Male")
                    PictureBoxPerson.Image = Resources.question__2_;
                else
                    PictureBoxPerson.Image = Resources.question__3_;

            }
            else
            {

                if (File.Exists(_Person.ImagePath))
                {
                    PictureBoxPerson.ImageLocation = _Person.ImagePath;
                }
                else
                {
                    MessageBox.Show($"Could not find this image: {_Person.ImagePath}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        private void _FillPersonInfo()
        {

            LinkLabelEditPersonInfo.Enabled = true;

            LabelPersonID.Text = _Person.PersonID.ToString();
            LabelName.Text = _Person.FullName;
            LabelNationlNo.Text = _Person.NationalNo.ToString();
            LabelGender.Text = _Person.Gender.ToString();
            LabelEmail.Text = _Person.Email.ToString();
            LabelAdderss.Text = _Person.Address.ToString();
            LabelDateOfBirth.Text = _Person.DateOfBirth.ToString("d");
            LabelPhone.Text = _Person.Phone.ToString();
            LabelCountry.Text = _Person.countryInfo.CountryName.ToString();

            if (LabelGender.Text == "Male")
                pbGender.Image = Resources.letter_m;
            else
                pbGender.Image = Resources.letter_f;

            _LoadPersonImage();

        }

        private void _ResetPersonInfo()
        {

            LinkLabelEditPersonInfo.Enabled = false;

            LabelPersonID.Text = "[????]";
            LabelName.Text = "[????]";
            LabelNationlNo.Text = "[????]";
            LabelGender.Text = "[????]";
            LabelEmail.Text = "[????]";
            LabelAdderss.Text = "[????]";
            LabelDateOfBirth.Text = "[????]";
            LabelPhone.Text = "[????]";
            LabelCountry.Text = "[????]";

            PictureBoxPerson.Image = Resources.question__2_;


        }

    }
 

}
