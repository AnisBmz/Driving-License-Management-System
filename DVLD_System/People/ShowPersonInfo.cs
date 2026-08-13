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
    public partial class ShowPersonInfoForm : Form
    {

        public ShowPersonInfoForm(int personID)
        {
            InitializeComponent();
            userControlPersonDetails1.LoadPersonInfo(personID);


        }

        public ShowPersonInfoForm(string nationalNo)
        {
            InitializeComponent();
            userControlPersonDetails1.LoadPersonInfo(nationalNo);

        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
