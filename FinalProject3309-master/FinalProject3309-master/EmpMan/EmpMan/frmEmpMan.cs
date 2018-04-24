using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmpMan.Classes;

namespace EmpMan
{
    public partial class frmEmpMan : Form
    {
        Validation validate = new Validation();
        FormController fc = new FormController();
        public frmEmpMan()
        {
            InitializeComponent();
        }
        

        private void frmEmpMan_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validate.checkName(txtPersonName.Text);
            //validate.checkBirthDate(txtPersonBirthDate.Text);
            //validate.checkID(txtPersonID.Text);
            //validate.checkMoney(txtManagerSalary.Text);
        }

        private void btnCreateClient_Click(object sender, EventArgs e)
        {
            
        }
    }
}
