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
using static DVLD_Business.clsApplicationType;

namespace DVLD_System
{
    public partial class UpdateTestTypeForm : Form
    {

        int _TestTypeID;

        clsTestType _TestType;

        public UpdateTestTypeForm(int testTypeID)
        {
            InitializeComponent();
            _TestTypeID = testTypeID;
        }

        private void UpdateTestTypeForm_Load(object sender, EventArgs e)
        {

            _FillUpdateTestTypeForm();

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

            if (!_ValidateChildrenForSave())
            {
                return;
            }

            _TestType.Title = TextBoxTitle.Text.Trim();

            _TestType.Description = TextBoxDescription.Text.Trim();

            _TestType.Fees = Convert.ToDecimal(TextBoxFees.Text.Trim());

            bool saved = _TestType.UpdateTestType();

            if (saved)
            {

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

                MessageBox.Show("Data Save Failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void TextBoxTitle_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace((TextBoxTitle.Text.Trim())))
            {

                errorProviderTitle.SetError((TextBoxTitle), "Title Field cannot be blank.");

            }
            else
            {

                errorProviderTitle.SetError((TextBoxTitle), string.Empty);


            }

        }

        private void TextBoxDescription_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace((TextBoxDescription.Text.Trim())))
            {

                errorProviderDescricption.SetError((TextBoxDescription), "Description Field cannot be blank.");

            }
            else
            {

                errorProviderDescricption.SetError((TextBoxDescription), string.Empty);


            }

        }

        private void TextBoxFees_Validating(object sender, CancelEventArgs e)
        {

            string input = TextBoxFees.Text.Trim();

            if (string.IsNullOrWhiteSpace(input))
            {
                errorProviderFees.SetError(TextBoxFees, "Fees Field cannot be blank.");
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

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _FillUpdateTestTypeForm()
        {

            _TestType = clsTestType.GetTestTypeInfoByID(_TestTypeID);

            if (_TestType != null)
            {

                LabelID.Text = _TestType.TestTypeID.ToString();
                TextBoxTitle.Text = _TestType.Title;
                TextBoxDescription.Text = _TestType.Description;
                TextBoxFees.Text = _TestType.Fees.Value.ToString("G29");

            }

            TextBoxTitle.SelectionStart = TextBoxTitle.Text.Length;

        }

        private void _ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool _ValidateChildrenForSave()
        {

            this.ValidateChildren();

            if (!string.IsNullOrEmpty(errorProviderTitle.GetError(TextBoxTitle)) &&
                !string.IsNullOrEmpty(errorProviderDescricption.GetError(TextBoxDescription)) &&
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

            if (!string.IsNullOrEmpty(errorProviderDescricption.GetError(TextBoxDescription)))
            {

                _ShowError(errorProviderDescricption.GetError(TextBoxDescription));
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
