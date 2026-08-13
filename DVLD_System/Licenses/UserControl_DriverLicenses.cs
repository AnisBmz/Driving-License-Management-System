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

namespace DVLD_System.Licenses
{
    public partial class UserControlDriverLicenses : UserControl
    {

        int _PersonID = -1;

        public UserControlDriverLicenses()
        {
            InitializeComponent();
        }

        private void DataGridViewLocalLicense_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridViewLocalLicense.CurrentRow != null)
            {
                DataGridViewLocalLicense.CurrentRow.ContextMenuStrip = ContextMenuLocalLicense;
            }
        }

        private void DataGridViewInternationalLicense_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridViewInternationalLicense.CurrentRow != null)
            {
                DataGridViewInternationalLicense.CurrentRow.ContextMenuStrip = ContextMenuStripInternationalLicense;
            }
        }

        private void ShowLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int licenseID = Convert.ToInt32(DataGridViewLocalLicense.CurrentRow.Cells["License ID"].Value);
            DriverLicenseInfoForm driverLicenseInfo = new DriverLicenseInfoForm(licenseID);
            driverLicenseInfo.ShowDialog();

        }

        private void ShowInternationalLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int internationalLicenseID = Convert.ToInt32(DataGridViewInternationalLicense.CurrentRow.Cells["Int.License ID"].Value);
            InternationalDriverInfoForm internationalDriverInfo = new InternationalDriverInfoForm(internationalLicenseID);
            internationalDriverInfo.ShowDialog();
        }

        public void LoadDriverLicenses(int personID)
        {
            _PersonID = personID;
            _LoadAllLocalDrivingLicenses();
            _LoadAllInternationalDrivingLicenses();
        }

        private void _LoadAllInternationalDrivingLicenses()
        {
            DataTable dataTable = clsDriver.GetAllInternationalDrivingLicensesForPerson(_PersonID);

            if (dataTable.Rows.Count == 0)
            {
                LabelNo.Visible = true;
                return;
            }

            LabelNo.Visible = false;
            DataGridViewInternationalLicense.DataSource = dataTable;
            LabelRecordsCountInternational.Text = dataTable.Rows.Count.ToString();
        }

        private void _LoadAllLocalDrivingLicenses()
        {

            DataTable dataTable = clsDriver.GetAllLocalDrivingLicensesForPerson(_PersonID);

            if (dataTable.Rows.Count == 0)
            {
                LabelNoLocal.Visible = true;
                return;
            }

            LabelNoLocal.Visible = false;
            DataGridViewLocalLicense.DataSource = dataTable;

            if (dataTable.Columns.Count > 0)
            {
                DataGridViewLocalLicense.Columns[0].Width = 90;
                DataGridViewLocalLicense.Columns[1].Width = 100;
                DataGridViewLocalLicense.Columns[2].Width = 200;
                DataGridViewLocalLicense.Columns[5].Width = 60;
            }

            LabelRecordsCountLocal.Text = dataTable.Rows.Count.ToString();


        }
    }
}
