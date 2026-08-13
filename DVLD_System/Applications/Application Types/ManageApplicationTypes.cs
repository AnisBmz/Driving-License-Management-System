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
    public partial class ManageApplicationTypesForm : Form
    {

        DataView _DataView;

        public ManageApplicationTypesForm()
        {
            InitializeComponent();
        }

        private void ManageApplicationTypesForm_Load(object sender, EventArgs e)
        {

            _LoadApplicationTypesTable();

            if (_DataView.Table.Columns.Count > 0)
            {

                DataGridViewApplicationTypes.Columns["ID"].Width = 40;

                DataGridViewApplicationTypes.Columns["Fees"].Width = 150;


            }

        }

        private void DataGridViewApplicationTypes_SelectionChanged(object sender, EventArgs e)
        {

            if (DataGridViewApplicationTypes.CurrentRow != null)
            {
                DataGridViewApplicationTypes.CurrentRow.ContextMenuStrip = contextMenuStrip1;
            }

        }

        private void EditApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int rowIndex = -1;

            if (DataGridViewApplicationTypes.RowCount != 0)
            {

                rowIndex = DataGridViewApplicationTypes.SelectedRows[0].Index;


            }

            _OpenUpdateApplicationTypeForm();
            _LoadApplicationTypesTable();


            if (rowIndex != -1 && DataGridViewApplicationTypes.RowCount != 0)
            {

                DataGridViewApplicationTypes.Rows[rowIndex].Selected = true;
                DataGridViewApplicationTypes.CurrentCell = DataGridViewApplicationTypes.Rows[rowIndex].Cells[0];


            }

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _LoadApplicationTypesTable()
        {

            _DataView = clsApplicationType.GetAllApplicationTypes().DefaultView;
            DataGridViewApplicationTypes.DataSource = _DataView;
            LabelCount.Text = _DataView.Count.ToString();

        }

        private void _OpenUpdateApplicationTypeForm()
        {

            int ApplicationTypeID = Convert.ToInt32(DataGridViewApplicationTypes.CurrentRow.Cells[0].Value);
            UpdateApplicationTypeForm updateApplicationTypeForm = new UpdateApplicationTypeForm(ApplicationTypeID);
            updateApplicationTypeForm.ShowDialog();

        }


    }
}
