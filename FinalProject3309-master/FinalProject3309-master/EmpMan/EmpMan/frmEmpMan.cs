using System;
using System.Data.OleDb; // This is needed to access the database
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

        PersonList personList = new PersonList();
        EmpManDB dbFunctions = new EmpManDB();
        Client client = new Client();
        Employee employee = new Employee();
        Manager manager = new Manager();
        Worker worker = new Worker();

        int currentIndex = -1;
        int recordsProcessedCount = 0;

        string FileName = "PersistentObject.bin";

        string ttCreateManager = "Click to enter Make Manager mode to add a Manager to the List of Persons.";
        string ttCreateWorker = "Click to enter Make Worker mode to add a Worker to the List of Persons.";
        string ttCreateClient = "Click to enter Make Client mode to add a Client to the List of Persons.";
        string ttSaveManager = "Click to Save the Manager to the List Persons.";
        string ttSaveWorker = "Click to Save the Worker to the List of Persons.";
        string ttSaveClient = "Click to Save the Client to the List of Persons.";
        string ttClear = "Click to Clear Form.";
        string ttFind = "Click to Find a Person in the List of Persons.";
        string ttDelete = "Click to Delete Person from the List of Persons.";
        string ttEdit = "Click to Edit a Person's data.";
        string ttAdd = "Click to Add a Person's data to the end of the Person List.";
        // string ttCancel = "Click to cancel operation.";
        string ttExit = "Click to exit application.";

        string ttManagerSalary = "Enter dollars and cents.";
        string ttManagerBonus = "Enter dollars and cents.";
        string ttWorkerHourlyPay = "Enter dollars and cents";
        string ttPersonName = "Enter A .. Z and a .. z ONLY";
        string ttPersonBirthDate = "Enter mm/dd/yyyy";
        string ttPersonID = "Enter Exactly 5 Digits";
        string ttEmployeeJobTitle = "Enter Job Title as text";
        string ttClientType = "Enter Client Type as text";

        private void frmEmpMan_Load(object sender, EventArgs e)
        {
        }
        /*
        private void frmEmpMan_Load(object sender, EventArgs e)
        {
            POManager.ReadFromFile(ref personList, FileName);
            FormController.clear(this);

            // get initial Tooltips
            toolTip1.SetToolTip(btnCreateManager, ttCreateManager);
            toolTip1.SetToolTip(btnCreateWorker, ttCreateWorker);
            toolTip1.SetToolTip(btnCreateClient, ttCreateClient);

            toolTip1.SetToolTip(btnClear, ttClear);
            toolTip1.SetToolTip(btnDelete, ttDelete);
            toolTip1.SetToolTip(btnEdit, ttEdit);
            toolTip1.SetToolTip(btnFind, ttFind);
            toolTip1.SetToolTip(btnAdd, ttAdd);
            toolTip1.SetToolTip(btnExit, ttExit);

            toolTip1.SetToolTip(txtManagerSalary, ttManagerSalary);
            toolTip1.SetToolTip(txtManagerBonus, ttManagerBonus);
            toolTip1.SetToolTip(txtWorkerHourlyPay, ttWorkerHourlyPay);
            toolTip1.SetToolTip(txtPersonName, ttPersonName);
            toolTip1.SetToolTip(txtPersonBirthDate, ttPersonBirthDate);
            toolTip1.SetToolTip(txtPersonID, ttPersonID);
            toolTip1.SetToolTip(txtEmployeeJobTitle, ttEmployeeJobTitle);
            toolTip1.SetToolTip(txtClientType, ttClientType);
        } // end frmEmpMan_Load
````````
*/





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
            if (!validate.checkName(txtPersonID.Text))
            {
                MessageBox.Show("Incorrect Name.");
            }
            if (!validate.checkID(txtPersonID.Text))
            {
                MessageBox.Show("Incorrect ID.");
            }
            if (!validate.checkBirthDate(txtPersonBirthDate.Text))
            {
                MessageBox.Show("Incorrect Date.");
            }
            if (!validate.checkName(txtClientType.Text))
            {
                MessageBox.Show("Incorrect Client Type.");
            }

            client.personName = txtPersonName.Text;

            client.personID = txtPersonID.Text;
            client.personBirthDate = DateTime.Parse(txtPersonBirthDate.Text);
            client.ClientType = txtClientType.Text;

            personList.addPerson(client);

        }

        private void btnCreateManager_Click(object sender, EventArgs e)
        {

            if (!validate.checkName(txtPersonID.Text))
            {
                MessageBox.Show("Incorrect Name.");
            }
            if (!validate.checkID(txtPersonID.Text))
            {
                MessageBox.Show("Incorrect ID.");
            }
            if (!validate.checkBirthDate(txtPersonBirthDate.Text))
            {
                MessageBox.Show("Incorrect Date.");
            }
            if (!validate.checkMoney(txtManagerSalary.Text))
            {
                MessageBox.Show("Incorrect Salary.");
            }
            if (!validate.checkMoney(txtManagerBonus.Text))
            {
                MessageBox.Show("Incorrect Bonus.");
            }

            manager.personName = txtPersonName.Text;

            manager.personID = txtPersonID.Text;
            manager.personBirthDate = DateTime.Parse(txtPersonBirthDate.Text);
            manager.managerSalary = Decimal.Parse(txtManagerSalary.Text);
            manager.managerBonus = Decimal.Parse(txtManagerBonus.Text);

            personList.addPerson(manager);
        }

        private void btnCreateWorker_Click(object sender, EventArgs e)
        {


            if (!validate.checkName(txtPersonID.Text))
            {
                MessageBox.Show("Incorrect Name.");
            }
            if (!validate.checkID(txtPersonID.Text))
            {
                MessageBox.Show("Incorrect ID.");
            }
            if (!validate.checkBirthDate(txtPersonBirthDate.Text))
            {
                MessageBox.Show("Incorrect Date.");
            }
            if (!validate.checkMoney(txtWorkerHourlyPay.Text))
            {
                MessageBox.Show("Incorrect Hourly Pay.");
            }

            worker.personName = txtPersonName.Text;

            worker.personID = txtPersonID.Text;
            worker.personBirthDate = DateTime.Parse(txtPersonBirthDate.Text);
            worker.WorkerHourlyPay = Decimal.Parse(txtWorkerHourlyPay.Text);

            personList.addPerson(worker);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (personList.deletePerson(txtPersonID.Text))
            {
                MessageBox.Show("Person is deleted");
            }
            else
            {
                MessageBox.Show("Person is not deleted");
            }
        }

        private void btnFindDisplay_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < personList.Count(); i++)
            {
            }

        }
    }
}
