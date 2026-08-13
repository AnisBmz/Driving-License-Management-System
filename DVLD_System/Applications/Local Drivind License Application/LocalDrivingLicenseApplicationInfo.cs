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
    public partial class LocalDrivingLicenseApplicationInfoForm : Form
    {

        int _localDrivingLicenseApplicationID = -1;

        public LocalDrivingLicenseApplicationInfoForm(int localDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
        }

        private void LocalDrivingLicenseApplicationInfoForm_Load(object sender, EventArgs e)
        {

            userControl_DrivingLicenseApplicationInfo1.LoadApplicationInfoByLocalApplicationID(_localDrivingLicenseApplicationID);

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
