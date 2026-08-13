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
    public partial class InternationalDriverInfoForm : Form
    {

        int _InternationalLicenseID = -1;
        public InternationalDriverInfoForm(int internationalLicenseID)
        {
            InitializeComponent();
            _InternationalLicenseID = internationalLicenseID;

        }

        private void InternationalDriverInfoForm_Load(object sender, EventArgs e)
        {

            userControl_InternationalLicenseInfo1.LoadInternationalLicenseInfo(_InternationalLicenseID);

        }
    }
}
