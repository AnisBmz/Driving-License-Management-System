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
    public partial class ShowPersonLicensesHistoryForm : Form
    {

        int _PersonID = -1;

        public ShowPersonLicensesHistoryForm(int personID)
        {
            InitializeComponent();
            _PersonID = personID;
        }

        private void LicenseHistoryForm_Load(object sender, EventArgs e)
        {

            userControl_Person_Details1.LoadPersonInfo(_PersonID);
            userControl_DriverLicenses.LoadDriverLicenses(_PersonID);

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
