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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD_System
{
    public partial class UserControl_DriverLicenseInfo : UserControl
    {

        clsLicense _License;
        public clsLicense License { get { return _License; } }

        public UserControl_DriverLicenseInfo()
        {
            InitializeComponent();
        }

        public void LoadDriverLicenseInfo(int licenseID)
        {

            _License = clsLicense.GetLicenseInfoByID(licenseID);

            if (_License == null)
            {
                MessageBox.Show($"No License With License ID = {licenseID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadEmptyDriverLicenseInfo();
                return;
            }

            LabelClass.Text = _License.licenseClassInfo.ClassName;
            LabelName.Text = _License.applicationInfo.PersonInfo.FullName;
            LabelLicenseID.Text = _License.LicenseID.ToString();
            LabelNationalNo.Text = _License.applicationInfo.PersonInfo.NationalNo;
            LabelGender.Text = _License.applicationInfo.PersonInfo.Gender;
            LabelIssueDate.Text = _License.IssueDate.ToString("d");
            labelIssueReason.Text = _License.IssueReason;
            LabelNotes.Text = _License.Notes != "" ? _License.Notes : "No Notes";
            LabelIsActive.Text = _License.IsActive == true ? "Yes" : "No";
            LabelDateOfBirth.Text = _License.applicationInfo.PersonInfo.DateOfBirth.ToString("d");
            LabelDriverID.Text = _License.DriverID.ToString();
            LabelExpirationDate.Text = _License.ExpirationDate.ToString("d");
            LabelIsDetained.Text = _License.IsDetained ? "Yes" : "No";

            string imagePath = _License.applicationInfo.PersonInfo.ImagePath;

            PictureBoxPerson.Image = !string.IsNullOrEmpty(imagePath) && File.Exists(imagePath)
            ? System.Drawing.Image.FromFile(imagePath)
            : (_License.applicationInfo.PersonInfo.Gender == "Male" ? Resources.question__2_ : Resources.question__3_);

            PictureBoxGender.Image = _License.applicationInfo.PersonInfo.Gender == "Male" ? Resources.letter_m : Resources.letter_f;

        }

        public void LoadEmptyDriverLicenseInfo()
        {

            LabelClass.Text = "????";
            LabelName.Text = "????";
            LabelLicenseID.Text = "????";
            LabelNationalNo.Text = "????";
            LabelGender.Text = "????";
            LabelIssueDate.Text = "????";
            labelIssueReason.Text = "????";
            LabelNotes.Text = "????";
            LabelIsActive.Text = "????";
            LabelDateOfBirth.Text = "????";
            LabelDriverID.Text = "????";
            LabelExpirationDate.Text = "????";
            LabelIsDetained.Text = "????";
            PictureBoxPerson.Image = Resources.question__2_;
            PictureBoxGender.Image = Resources.user__1_;

        }

        public void UpdateActiveStatus(bool isActive)
        {
            if (isActive)
            {

                LabelIsActive.Text = "Yes";

            }
            else
            {
                LabelIsActive.Text = "No";


            }
        }

        public void UpdateDetainedStatus(bool isDetained)
        {
            if (isDetained)
            {

                LabelIsDetained.Text = "Yes";

            }
            else
            {
                LabelIsDetained.Text = "No";


            }


        }


    }
}
