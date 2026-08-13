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
    public partial class UserControl_InternationalLicenseInfo : UserControl
    {
        public UserControl_InternationalLicenseInfo()
        {
            InitializeComponent();
        }

        public void LoadInternationalLicenseInfo(int internationalLicenseID)
        {

            clsInternationalLicense internationalLicense = clsInternationalLicense.GetInternationalLicenseByID(internationalLicenseID);

            if (internationalLicense == null)
            {
                MessageBox.Show($"No International License With InternationalLicense ID = {internationalLicenseID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            LabelName.Text = internationalLicense.ApplicationInfo.PersonInfo.FullName;
            LabelInternationalLicenseID.Text = internationalLicense.InternationalLicenseID.ToString();
            LabelLicenseID.Text = internationalLicense.LocalLicenseID.ToString();
            LabelNationalNo.Text = internationalLicense.ApplicationInfo.PersonInfo.NationalNo.ToString();
            LabelGender.Text = internationalLicense.ApplicationInfo.PersonInfo.Gender;
            LabelDateOfBirth.Text = internationalLicense.ApplicationInfo.PersonInfo.DateOfBirth.ToString("d");
            LabelDriverID.Text = internationalLicense.DriverID.ToString();
            LabelExpirationDate.Text = internationalLicense.ExpirationDate.ToString("d");
            LabelIssueDate.Text = internationalLicense.IssueDate.ToString("d");
            LabelApplicationID.Text = internationalLicense.ApplicationID.ToString();

            if (internationalLicense.ApplicationInfo.PersonInfo.GenderN == 0)
            {
                PictureBoxGender.Image = Resources.letter_m;
            }
            else
            {
                PictureBoxGender.Image = Resources.letter_f;
            }

            if (internationalLicense.IsActive)
            {
                LabelIsActive.Text = "Yes";
            }
            else
            {
                LabelIsActive.Text = "No";
            }

            string imagePath = internationalLicense.ApplicationInfo.PersonInfo.ImagePath;

            if (File.Exists(imagePath) && internationalLicense.ApplicationInfo.PersonInfo.ImagePath != "")
                PictureBoxPerson.Image = Image.FromFile(imagePath);
            else
            {
                if (internationalLicense.ApplicationInfo.PersonInfo.GenderN == 0)
                    PictureBoxPerson.Image = Resources.question__2_;
                else
                    PictureBoxPerson.Image = Resources.question__3_;
            }

        }

    }
}
