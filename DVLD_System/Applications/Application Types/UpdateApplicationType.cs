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
    public partial class UpdateApplicationTypeForm : Form
    {

        int _ApplicationTypeID = -1;

        clsApplicationType _ApplicationType;

        public UpdateApplicationTypeForm(int ID)
        {
            InitializeComponent();

            _ApplicationTypeID = ID;

        }

        private void UpdateApplicationTypeForm_Load(object sender, EventArgs e)
        {
            _FillApplicationTypeInfo();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

            if (!_ValidateChildrenForSave())
            {
                return;
            }

            _ApplicationType.Title = TextBoxTitle.Text.Trim();

            _ApplicationType.Fees = Convert.ToDecimal(TextBoxFees.Text.Trim());

            bool saved = _ApplicationType.UpdateApplicationType();

            if (saved)
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Data Save Failed.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TextBoxTitle_Validating(object sender, CancelEventArgs e)
        {


            string input = TextBoxTitle.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {

                errorProviderTitle.SetError(TextBoxTitle, "Title cannot be blank.");

            }
            else
            {

                errorProviderTitle.Clear();

            }

        }

        private void TextBoxFees_Validating(object sender, CancelEventArgs e)
        {

            string input = TextBoxFees.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {

                errorProviderFees.SetError(TextBoxFees, "Fees cannot be blank.");

            }
            else if (!decimal.TryParse(input, out decimal fees))
            {

                errorProviderFees.SetError(TextBoxFees, "Fees Value must be numeric.");

            }
            else if (fees < 0)
            {

                errorProviderFees.SetError(TextBoxFees, "Negative Fees values cannot be entered.");

            }
            else
            {

                errorProviderFees.SetError(TextBoxFees, string.Empty);

            }


        }

        private void _FillApplicationTypeInfo()
        {

            LabelID.Text = _ApplicationTypeID.ToString();

            _ApplicationType = clsApplicationType.GetApplicationTypeByID(_ApplicationTypeID);

            if (_ApplicationType != null)
            {
                TextBoxTitle.Text = _ApplicationType.Title.ToString();
                TextBoxTitle.SelectionStart = TextBoxTitle.Text.Length;
                TextBoxFees.Text = _ApplicationType.Fees.Value.ToString("G29");
            }

        }

        private void _ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool _ValidateChildrenForSave()
        {

            this.ValidateChildren();

            if (!string.IsNullOrEmpty(errorProviderTitle.GetError(TextBoxTitle)) &&
                !string.IsNullOrEmpty(errorProviderFees.GetError(TextBoxFees)))
            {
                _ShowError("Some fields are not valid!, please check the red icons.");
                return false;
            }

            if (!string.IsNullOrEmpty(errorProviderTitle.GetError(TextBoxTitle)))
            {

                _ShowError(errorProviderTitle.GetError(TextBoxTitle));
                return false;

            }

            if (!string.IsNullOrEmpty(errorProviderFees.GetError(TextBoxFees)))
            {

                _ShowError(errorProviderFees.GetError(TextBoxFees));
                return false;

            }

            return true;
        }

    }
}
