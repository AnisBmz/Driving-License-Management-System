using DVLD_Business;
using DVLD_System.Properties;
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
    public partial class DriverLicenseInfoForm : Form
    {

        int _LicenseID = -1;

        public DriverLicenseInfoForm(int licenseID)
        {
            InitializeComponent();
            _LicenseID = licenseID;
        }

        private void DriverLicenseInfoFrom_Load(object sender, EventArgs e)
        {

            userControl_DriverLicenseInfo1.LoadDriverLicenseInfo(_LicenseID);

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
