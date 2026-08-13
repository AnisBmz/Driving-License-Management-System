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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_System
{
    public partial class AddUpdateLocalDrivingLicenseApplicationForm : Form
    {

        enum enMode { AddNew = 1 , Update = 2 }

        enMode _Mode = enMode.AddNew;
        public int PersonID
        {
            get { return userControl_Search_Person1.PersonID; }
        }

        const int _ApplicationTypeID = (int)clsApplicationType.enApplicationType.NewLocalDrivingLicenseService;

        int _LocalDrivingLicenseApplicationID = -1;

        clsLocalDrivingLicenseApplication _LocalDrivingLicenseApplication;

        public AddUpdateLocalDrivingLicenseApplicationForm()
        {

            InitializeComponent();
            _Mode = enMode.AddNew;

        }

        public AddUpdateLocalDrivingLicenseApplicationForm(int localDrivingLicenseApplication)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = localDrivingLicenseApplication;
            _Mode = enMode.Update;

        }

        private void AddUpdateLocalDrivingLicenseApplicationForm_Load(object sender, EventArgs e)
        {

            _ResetDefaultValues();
            if (_Mode == enMode.Update)
            {
                _LoadData();
            }

        }

        private void AddUpdateLocalDrivingLicenseApplicationForm_Activated(object sender, EventArgs e)
        {
            userControl_Search_Person1.FilterFocus();
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {

            if (clsPerson.IsPersonExists(PersonID))
            {


                ButtonSave.Enabled = true;
                tabControl1.SelectedIndex = 1;


            }
            else
            {

                MessageBox.Show("You didn't Select Any person", "Select person", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }


        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

            int oldLicenseClassID = _LocalDrivingLicenseApplication.LicenseClassID;

            _ReadLocalDrivingLicenseApplicationData();

            if (!_ValidateApplication(oldLicenseClassID))
            {
                return;
            }

            if (_LocalDrivingLicenseApplication.Save())
            {
                if (_Mode == enMode.AddNew)
                {
                    _Mode = enMode.Update;
                    _TransformToUpdateForm();
                }
                _LoadApplicationInfo();
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Data Save Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _ResetDefaultValues()
        {

            _FillLicenseClassesIntoComboBox();

            if (_Mode == enMode.Update)
            {
                _TransformToUpdateForm();
                _LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationByID(_LocalDrivingLicenseApplicationID);
                ButtonSave.Enabled = true;
            }
            else
            {

                _LocalDrivingLicenseApplication = new clsLocalDrivingLicenseApplication();
                LabelApolicationDate.Text = DateTime.Now.ToString("d");
                LabelCreatedBy.Text = clsGlobalSettings.CurrentUser.Username;
                LabelApplicatioFees.Text = clsApplicationType.GetApplicationTypeByID(_ApplicationTypeID).Fees.ToString();

            }

        }

        private void _FillLicenseClassesIntoComboBox()
        {

            List<string> licenseClassesName = clsLicenseClass.GetAllLicenseClassesName();

            if (licenseClassesName.Count != 0)
            {

                ComboBoxLicenseClass.Items.AddRange(licenseClassesName.ToArray());


                ComboBoxLicenseClass.SelectedIndex = 2;


            }

        }

        private void _LoadApplicationInfo()
        {

            LabelID.Text = _LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            LabelApolicationDate.Text = _LocalDrivingLicenseApplication.ApplicationDate.ToString("d");
            LabelApplicatioFees.Text = _LocalDrivingLicenseApplication.PaidFees.ToString();
            LabelCreatedBy.Text = clsUser.GetUserInfoByUserID(_LocalDrivingLicenseApplication.CreatedByUserID).Username.ToString();

        }

        private void _LoadData()
        {

            if (_LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("No Application with ID = " + _LocalDrivingLicenseApplicationID, "Application Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

                return;
            }

            userControl_Search_Person1.LoadPersonInfo(_LocalDrivingLicenseApplication.ApplicationPersonID);
            ComboBoxLicenseClass.Text = _LocalDrivingLicenseApplication.LicenseClassInfo.ClassName;
            _LoadApplicationInfo();

        }

        private void _ReadLocalDrivingLicenseApplicationData()
        {

            _LocalDrivingLicenseApplication.LicenseClassID = clsLicenseClass.GetLicenseClassIDByName(ComboBoxLicenseClass.Text);

            _LocalDrivingLicenseApplication.ApplicationDate = DateTime.Now;

            _LocalDrivingLicenseApplication.ApplicationPersonID = PersonID;

            _LocalDrivingLicenseApplication.ApplicationTypeID = _ApplicationTypeID;

            _LocalDrivingLicenseApplication.LastStatusDate = DateTime.Now;

            _LocalDrivingLicenseApplication.PaidFees = clsApplicationType.GetApplicationTypeByID(_ApplicationTypeID).Fees.Value;

            _LocalDrivingLicenseApplication.CreatedByUserID = clsGlobalSettings.CurrentUser.UserID;

        }

        private void _TransformToUpdateForm()
        {

            this.Text = "Update Local Driving License Application";
            LabelTitle.Text = "Update Local Driving License Application";
            userControl_Search_Person1.GroupBoxFilter_Enable = false;

        }

        private bool _ValidateApplication(int oldLicenseClassID)
        {

            int activeApplicationID = clsApplication.GetActiveApplicationIDByPersonAndClass(_LocalDrivingLicenseApplication.ApplicationPersonID, _LocalDrivingLicenseApplication.LicenseClassID);

            if (clsLocalDrivingLicenseApplication.IsAgeOfPersonNotAllowed(_LocalDrivingLicenseApplication.ApplicationPersonID, _LocalDrivingLicenseApplication.LicenseClassID))
            {
                MessageBox.Show("The age of this person is not allowed for this license class.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

            if (clsLicense.IsPersonHaveLicense(_LocalDrivingLicenseApplication.ApplicationPersonID, _LocalDrivingLicenseApplication.LicenseClassID))
            {
                MessageBox.Show("Person already have a license with the same applied driving class, Choose different driving class.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (activeApplicationID != -1 && ((_Mode == enMode.AddNew) || (_Mode == enMode.Update && oldLicenseClassID != _LocalDrivingLicenseApplication.LicenseClassID)))
            {
                MessageBox.Show($"Choose another license class, The selected person already have an active application for the selected class with id = {activeApplicationID}.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

    }
}
