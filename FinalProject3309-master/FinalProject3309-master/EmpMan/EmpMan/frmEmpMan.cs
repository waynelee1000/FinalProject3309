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
            txtClientType.Text = "";
            txtEmployeeJobTitle.Text = "";
            txtManagerBonus.Text = "";
            txtManagerSalary.Text = "";
            txtPersonBirthDate.Text = "";
            txtPersonID.Text = "";
            txtPersonName.Text = "";
            txtWorkerHourlyPay.Text = "";
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
            if (!(validate.checkName(txtPersonName.Text)))
            {
                MessageBox.Show("Incorrect Name.");
            }
            else if (!(validate.checkID(txtPersonID.Text)))
            {
                MessageBox.Show("Incorrect ID.");
            }
            else if (!(validate.checkBirthDate(txtPersonBirthDate.Text)))
            {
                MessageBox.Show("Incorrect Date.");
            }
            else if (!(validate.checkName(txtClientType.Text)))
            {
                MessageBox.Show("Incorrect Client Type.");
            }
            else
            {
                client.personName = txtPersonName.Text;

                client.personID = txtPersonID.Text;

                client.personBirthDate = DateTime.Parse(txtPersonBirthDate.Text);

                client.ClientType = txtClientType.Text;

                if (personList.addPerson(client))
                {
                    MessageBox.Show("Person :" + txtPersonName.Text + " has been added");
                }
                else
                {
                    MessageBox.Show("ID already exist");
                }
            }


        }
        private void btnCreateManager_Click_1(object sender, EventArgs e)
        {
            if (!validate.checkName(txtPersonName.Text))
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

            else
            {
                manager.personName = txtPersonName.Text;

                manager.personID = txtPersonID.Text;
                manager.personBirthDate = DateTime.Parse(txtPersonBirthDate.Text);
                manager.managerSalary = Decimal.Parse(txtManagerSalary.Text);
                manager.managerBonus = Decimal.Parse(txtManagerBonus.Text);

                if (personList.addPerson(manager))
                {
                    MessageBox.Show("Person :" + txtPersonName.Text + " has been added");
                }
                else
                {
                    MessageBox.Show("ID already exist");
                }
            }


        }

        private void btnCreateWorker_Click_1(object sender, EventArgs e)
        {

            if (!validate.checkName(txtPersonName.Text))
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

            else
            {
                worker.personName = txtPersonName.Text;

                worker.personID = txtPersonID.Text;
                worker.personBirthDate = DateTime.Parse(txtPersonBirthDate.Text);
                worker.WorkerHourlyPay = Decimal.Parse(txtWorkerHourlyPay.Text);

                if (personList.addPerson(worker))
                {
                    MessageBox.Show("Person :" + txtPersonName.Text + " has been added");
                }
                else
                {
                    MessageBox.Show("ID already exist");
                }
            }

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            if (personList.personList.Count == 0)
            {
                MessageBox.Show("Person is not deleted");
            }

            else
            {
                for (int i = 0; i < personList.personList.Count(); i++)
                {
                    if (personList.personList[i].personID == txtPersonID.Text)
                    {
                        personList.personList.RemoveAt(i);

                        MessageBox.Show("Person is deleted");
                    }
                    else
                    {
                        MessageBox.Show("Person is not deleted");
                    }
                }
            }
        }

        private void btnFindDisplay_Click_1(object sender, EventArgs e)
        {
            if (personList.personList.Count == 0)
            {
                MessageBox.Show("Person does not exist");
            }
            else
            {
                for (int i = 0; i < personList.personList.Count; i++)
                {
                    if (personList.personList[i].personID == txtPersonID.Text)
                    {
                        if (personList.personList[i].GetType() == typeof(Manager))
                        {
                            Manager newManager = new Manager();
                            newManager.Save(this);
                            MessageBox.Show(newManager.ToString());
                        }
                        if (personList.personList[i].GetType() == typeof(Worker))
                        {
                            Worker newWorker = new Worker();
                            newWorker.Save(this);
                            MessageBox.Show(newWorker.ToString());

                        }
                        if (personList.personList[i].GetType() == typeof(Client))
                        {
                            Client newClient = new Client();
                            newClient.Save(this);
                            MessageBox.Show(newClient.ToString());
                            
                        }

                    }
                    else
                    {
                        MessageBox.Show("Person does not exist");
                    }
                }
            }

        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            if (personList.personList.Count == 0)
            {
                MessageBox.Show("Person does not exist");
            }
            else
            {
                for (int i = 0; i < personList.personList.Count; i++)
                {
                    if (personList.personList[i].personID == txtPersonID.Text)
                    {
                        if (personList.personList[i].GetType() == typeof(Manager))
                        {
                            Manager newManager = new Manager();
                            newManager.Save(this);
                            personList.personList.RemoveAt(i);
                            personList.personList.Insert(i, newManager);
                            MessageBox.Show("Changes have been made");
                        }
                        if (personList.personList[i].GetType() == typeof(Worker))
                        {
                            Worker newWorker = new Worker();
                            newWorker.Save(this);
                            personList.personList.RemoveAt(i);
                            personList.personList.Insert(i, newWorker);
                            MessageBox.Show("Changes have been made");

                        }
                        if (personList.personList[i].GetType() == typeof(Client))
                        {
                            Client newClient = new Client();
                            newClient.Save(this);
                            personList.personList.RemoveAt(i);
                            personList.personList.Insert(i, newClient);
                            MessageBox.Show("Changes have been made");
                        }

                    }
                    else
                    {
                        MessageBox.Show("Person does not exist");
                    }
                }
            }

        }
    }
}
