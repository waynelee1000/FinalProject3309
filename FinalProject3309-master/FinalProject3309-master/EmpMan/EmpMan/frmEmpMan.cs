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
            grpClient.Enabled = false;
            grpEmployee.Enabled = false;
            grpManager.Enabled = false;
            grpWorker.Enabled = false;
            txtPersonName.Enabled = false;
            txtPersonBirthDate.Enabled = false;
            btnEditUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtPersonID.Focus();
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
                MessageBox.Show("Please Enter a Name");
            }
            else if (!(validate.checkID(txtPersonID.Text)))
            {
                MessageBox.Show("Please enter a digit ID");
            }
            else if (!(validate.checkBirthDate(txtPersonBirthDate.Text)))
            {
                MessageBox.Show("Incorrect date formate enter MM/DD/YYYY.");
            }
            else if (!(validate.checkName(txtClientType.Text)))
            {
                MessageBox.Show("Please enter a Client type!");
            }
            else
            {
                client = new Client();
                client.Save(this);

                if (personList.addPerson(client))
                {
                    MessageBox.Show("Person :" + txtPersonName.Text + " has been added"+ '\n'+"Press Cancel to continue");
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
                if (txtManagerBonus.Text.Contains('$'))
                {
                    txtManagerBonus.Text = txtManagerBonus.Text.Remove(0,1);
                }
                if (txtManagerSalary.Text.Contains('$'))
                {
                    txtManagerSalary.Text = txtManagerSalary.Text.Remove(0,1);
                }
                manager = new Manager();
                manager.Save(this);

                if (personList.addPerson(manager))
                {
                    MessageBox.Show("Person :" + txtPersonName.Text + " has been added" + '\n' + "Press Cancel to continue");
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
                if (txtWorkerHourlyPay.Text.Contains('$'))
                {
                    txtWorkerHourlyPay.Text = txtWorkerHourlyPay.Text.Remove(0,1);
                }
                worker = new Worker();
                worker.Save(this);

                if (personList.addPerson(worker))
                {
                    MessageBox.Show("Person :" + txtPersonName.Text + " has been added" + '\n' + "Press Cancel to continue");
                    
                }
                else
                {
                    MessageBox.Show("ID already exist");
                }
            }

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            int matchCounter = 0;
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

                        MessageBox.Show("Person is deleted" + '\n' + "Press Cancel to continue");

                        matchCounter++;

                        btnEditUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        btnFindDisplay.Enabled = true;
                        btnCancel.Visible = false;
                        grpClient.Enabled = false;
                        grpEmployee.Enabled = false;
                        grpManager.Enabled = false;
                        grpWorker.Enabled = false;
                        txtPersonName.Enabled = false;
                        txtPersonBirthDate.Enabled = false;
                        txtPersonID.Enabled = true;

                        txtClientType.Text = "";
                        txtEmployeeJobTitle.Text = "";
                        txtManagerBonus.Text = "";
                        txtManagerSalary.Text = "";
                        txtPersonBirthDate.Text = "";
                        txtPersonID.Text = "";
                        txtPersonName.Text = "";
                        txtWorkerHourlyPay.Text = "";
                        break;
                    }

                }
                if (matchCounter == 0)
                {
                    MessageBox.Show("Person is not deleted");
                    btnEditUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnFindDisplay.Enabled = true;
                    btnCancel.Visible = false;
                    grpPerson.Enabled = false;
                    txtPersonID.Enabled = true;
                }
            }
        }

        private void btnFindDisplay_Click_1(object sender, EventArgs e)
        {
            int matchCounter = 0;

                if (!validate.checkID(txtPersonID.Text))
                {
                    MessageBox.Show("Please enter a valid ID number");
                }
                else if (personList.personList.Count == 0)

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

                                MessageBox.Show(personList.personList[i].ToString());
                                personList.personList[i].Display(this);

                                matchCounter++;

                                txtPersonID.Enabled = false;
                                txtPersonName.Enabled = true;
                                txtPersonBirthDate.Enabled = true;
                                grpEmployee.Enabled = true;
                                grpManager.Enabled = true;
                                btnEditUpdate.Enabled = true;
                                btnDelete.Enabled = true;
                                btnFindDisplay.Enabled = false;
                                btnCancel.Visible = true;

                                break;
                                

                            }
                            if (personList.personList[i].GetType() == typeof(Worker))
                            {

                                MessageBox.Show(personList.personList[i].ToString());
                                personList.personList[i].Display(this);

                                matchCounter++;

                                txtPersonID.Enabled = false;
                                txtPersonName.Enabled = true;
                                txtPersonBirthDate.Enabled = true;
                                grpEmployee.Enabled = true;
                                grpWorker.Enabled = true;
                                btnEditUpdate.Enabled = true;
                                btnDelete.Enabled = true;
                                btnFindDisplay.Enabled = false;
                                btnCancel.Visible = true;

                                break;
                            }
                            if (personList.personList[i].GetType() == typeof(Client))
                            {

                                MessageBox.Show(personList.personList[i].ToString());
                                personList.personList[i].Display(this);

                                matchCounter++;

                                txtPersonID.Enabled = false;
                                txtPersonName.Enabled = true;
                                txtPersonBirthDate.Enabled = true;
                                grpClient.Enabled = true;
                                btnEditUpdate.Enabled = true;
                                btnDelete.Enabled = true;
                                btnFindDisplay.Enabled = false;
                                btnCancel.Visible = true;

                                break;
                            }


                        }
                    }

                    if (matchCounter == 0)
                    {
                        MessageBox.Show("Person does not exist");
                    }
                }
        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            int matchCounter = 0;

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

                            matchCounter++;

                            btnEditUpdate.Enabled = false;
                            btnDelete.Enabled = false;
                            btnFindDisplay.Enabled = true;
                            btnCancel.Visible = false;
                            grpEmployee.Enabled = false;
                            grpManager.Enabled = false;
                            txtPersonName.Enabled = false;
                            txtPersonBirthDate.Enabled = false;
                            txtClientType.Enabled = false;
                            txtPersonID.Enabled = true;

                            txtClientType.Text = "";
                            txtEmployeeJobTitle.Text = "";
                            txtManagerBonus.Text = "";
                            txtManagerSalary.Text = "";
                            txtPersonBirthDate.Text = "";
                            txtPersonID.Text = "";
                            txtPersonName.Text = "";
                            txtWorkerHourlyPay.Text = "";

                            break;
                        }
                        if (personList.personList[i].GetType() == typeof(Worker))
                        {
                            Worker newWorker = new Worker();
                            newWorker.Save(this);
                            personList.personList.RemoveAt(i);
                            personList.personList.Insert(i, newWorker);

                            MessageBox.Show("Changes have been made");

                            matchCounter++;

                            btnEditUpdate.Enabled = false;
                            btnDelete.Enabled = false;
                            btnFindDisplay.Enabled = true;
                            btnCancel.Visible = false;
                            txtClientType.Enabled = false;
                            grpWorker.Enabled = false;
                            grpEmployee.Enabled = false;
                            txtPersonName.Enabled = false;
                            txtPersonBirthDate.Enabled = false;
                            txtPersonID.Enabled = true;

                            txtClientType.Text = "";
                            txtEmployeeJobTitle.Text = "";
                            txtManagerBonus.Text = "";
                            txtManagerSalary.Text = "";
                            txtPersonBirthDate.Text = "";
                            txtPersonID.Text = "";
                            txtPersonName.Text = "";
                            txtWorkerHourlyPay.Text = "";

                            break;

                        }
                        if (personList.personList[i].GetType() == typeof(Client))
                        {
                            Client newClient = new Client();
                            newClient.Save(this);
                            personList.personList.RemoveAt(i);
                            personList.personList.Insert(i, newClient);

                            MessageBox.Show("Changes have been made" );

                            matchCounter++;

                            btnEditUpdate.Enabled = false;
                            btnDelete.Enabled = false;
                            btnFindDisplay.Enabled = true;
                            btnCancel.Visible = false;
                            txtClientType.Enabled = false;
                            txtPersonName.Enabled = false;
                            txtPersonBirthDate.Enabled = false;
                            txtPersonID.Enabled = true;

                            txtClientType.Text = "";
                            txtEmployeeJobTitle.Text = "";
                            txtManagerBonus.Text = "";
                            txtManagerSalary.Text = "";
                            txtPersonBirthDate.Text = "";
                            txtPersonID.Text = "";
                            txtPersonName.Text = "";
                            txtWorkerHourlyPay.Text = "";

                            break;
                        }



                    }

                }

                if (matchCounter == 0)
                {
                    MessageBox.Show("Person does not exist");
                }
            }

        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            grpEntryControl.Enabled = false;
            btnCreateManager.Enabled = false;
            btnCreateWorker.Enabled = false;
            txtPersonName.Enabled = true;
            txtPersonBirthDate.Enabled = true;
            grpClient.Enabled = true;
            btnCreateClient.Visible= true;
            txtClientType.Enabled = true;
            btnCreateClient.Enabled = true;
            btnCreateManager.Enabled = false;
            btnCreateWorker.Enabled = false;
            btnFindDisplay.Enabled = false;
            btnCancel.Visible = true;
        }
        

        private void btnManager_Click_1(object sender, EventArgs e)
        {
            grpEntryControl.Enabled = false;
            txtPersonName.Enabled = true;
            txtPersonBirthDate.Enabled = true;
            grpClient.Enabled = false;
            grpEmployee.Enabled = true;
            grpManager.Enabled = true;
            btnFindDisplay.Enabled = false;
            btnCreateManager.Enabled = true;
            btnCreateManager.Visible = true;
            btnCreateClient.Visible = false;
            btnCreateWorker.Visible = false;
            btnCancel.Visible = true;
        }

        private void btnWorker_Click(object sender, EventArgs e)
        {
            grpEntryControl.Enabled = false;
            txtPersonName.Enabled = true;
            txtPersonBirthDate.Enabled = true;
            grpClient.Enabled = false;
            grpEmployee.Enabled = true;
            grpManager.Enabled = false;
            grpWorker.Enabled = true;
            btnFindDisplay.Enabled = false;
            btnCreateManager.Visible = false;
            btnCreateClient.Visible = false;
            btnCreateWorker.Visible = true;
            btnCreateWorker.Enabled = true;
            btnCancel.Visible = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grpEntryControl.Enabled = true;
            txtPersonID.Focus();
            btnCancel.Visible = false;
            grpClient.Enabled = false;
            grpEmployee.Enabled = false;
            grpManager.Enabled = false;
            grpWorker.Enabled = false;
            txtPersonName.Enabled = false;
            txtPersonBirthDate.Enabled = false;
            txtPersonID.Enabled = true;
            btnEditUpdate.Enabled = false;
            btnDelete.Enabled = false;
            btnCreateManager.Visible = false;
            btnCreateClient.Visible = false;
            btnCreateWorker.Visible = false;
            btnCancel.Visible = false;

            btnFindDisplay.Enabled = true;
            txtClientType.Text = "";
            txtEmployeeJobTitle.Text = "";
            txtManagerBonus.Text = "";
            txtManagerSalary.Text = "";
            txtPersonBirthDate.Text = "";
            txtPersonID.Text = "";
            txtPersonName.Text = "";
            txtWorkerHourlyPay.Text = "";
        }
    }
}
