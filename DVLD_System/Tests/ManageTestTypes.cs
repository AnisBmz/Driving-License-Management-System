using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_Business;

namespace DVLD_System
{
    public partial class ManageTestTypesForm : Form
    {

        DataView _DataView;

        public ManageTestTypesForm()
        {
            InitializeComponent();
        }

        private void ManageTestTypesForm_Load(object sender, EventArgs e)
        {

            _LoadApplicationTypesTable();


            if (_DataView.Table.Columns.Count > 0)
            {

                DataGridViewTestTypes.Columns["ID"].Width = 40;

                DataGridViewTestTypes.Columns["Fees"].Width = 150;

                DataGridViewTestTypes.Columns["Title"].Width = 150;

            }

        }

        private void DataGridViewTestTypes_SelectionChanged(object sender, EventArgs e)
        {
            if (DataGridViewTestTypes.CurrentRow != null)
            {
                DataGridViewTestTypes.CurrentRow.ContextMenuStrip = contextMenuStrip1;
            }
        }

        private void EditTestTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int rowIndex = -1;

            if (DataGridViewTestTypes.RowCount != 0)
            {

                rowIndex = DataGridViewTestTypes.SelectedRows[0].Index;


            }

            _OpenUpdateTestTypeForm();
            _LoadApplicationTypesTable();

            if (rowIndex != -1 && DataGridViewTestTypes.RowCount != 0)
            {

                DataGridViewTestTypes.Rows[rowIndex].Selected = true;
                DataGridViewTestTypes.CurrentCell = DataGridViewTestTypes.Rows[rowIndex].Cells[0];

            }


        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void _LoadApplicationTypesTable()
        {

            _DataView = clsTestType.GetAllTestTypes().DefaultView;
            DataGridViewTestTypes.DataSource = _DataView;
            LabelCount.Text = _DataView.Count.ToString();

        }

        private void _OpenUpdateTestTypeForm()
        {

            int testTypeID = Convert.ToInt32(DataGridViewTestTypes.CurrentRow.Cells[0].Value);
            UpdateTestTypeForm updateTestTypeForm = new UpdateTestTypeForm(testTypeID);
            updateTestTypeForm.ShowDialog();

        }

    }
}
