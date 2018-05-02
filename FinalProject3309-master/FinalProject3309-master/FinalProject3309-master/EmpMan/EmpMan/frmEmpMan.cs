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
using System.Runtime.Serialization.Formatters.Binary;
namespace EmpMan
{
    public partial class frmEmpMan : Form
    {
        PersonList personList = new PersonList();
        EmpManDB dbFunctions = new EmpManDB();
        Client client = new Client();
        Employee employee = new Employee();
        Manager manager = new Manager();
        Worker worker = new Worker();
        Validation validate = new Validation();
        FormController fc = new FormController();
        string FileName = "PersistentObject.bin";

        int currentIndex = -1;
        int recordsProcessedCount = 0;
        string dbStringPerson = " ";
        string dbStringRest = " ";

        //String values for tooltip information
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
        string ttDisplayList = "Press to Display the internal list";

        ToolTip toolTip1 = new ToolTip();

        public frmEmpMan()
        {
            InitializeComponent();
        }

        //When the form loads
        private void frmEmpMan_Load(object sender, EventArgs e)
        {
            txtPersonID.Focus();
            grpClient.Enabled = false;
            grpEmployee.Enabled = false;
            grpManager.Enabled = false;
            grpWorker.Enabled = false;
            txtPersonName.Enabled = false;
            txtPersonBirthDate.Enabled = false;
            btnEditUpdate.Enabled = false;
            btnDelete.Enabled = false;           
            POManager.ReadFromFile(out personList, FileName);


            // tool tips for all the buttons and textboxes
            toolTip1.SetToolTip(btnManager, ttCreateManager);
            toolTip1.SetToolTip(btnWorker, ttCreateWorker);
            toolTip1.SetToolTip(btnClient, ttCreateClient);

            toolTip1.SetToolTip(btnClearForm, ttClear);
            toolTip1.SetToolTip(btnDelete, ttDelete);
            toolTip1.SetToolTip(btnEditUpdate, ttEdit);
            toolTip1.SetToolTip(btnFindDisplay, ttFind);
            toolTip1.SetToolTip(btnCreateClient, ttAdd);
            toolTip1.SetToolTip(btnManager, ttAdd);
            toolTip1.SetToolTip(btnCreateWorker, ttAdd);
            toolTip1.SetToolTip(btnExit, ttExit);
            toolTip1.SetToolTip(btndisplayList, ttDisplayList);

            toolTip1.SetToolTip(txtManagerSalary, ttManagerSalary);
            toolTip1.SetToolTip(txtManagerBonus, ttManagerBonus);
            toolTip1.SetToolTip(txtWorkerHourlyPay, ttWorkerHourlyPay);
            toolTip1.SetToolTip(txtPersonName, ttPersonName);
            toolTip1.SetToolTip(txtPersonBirthDate, ttPersonBirthDate);
            toolTip1.SetToolTip(txtPersonID, ttPersonID);
            toolTip1.SetToolTip(txtEmployeeJobTitle, ttEmployeeJobTitle);
            toolTip1.SetToolTip(txtClientType, ttClientType);
        } // end frmEmpMan_Load
        private void frmEmpMan_FormClosing(Object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            // Save serialized binary file
            POManager.writeToFile(ref personList, FileName);
        } // end frmEmpMan_FormClosing


        //Event handler to exit the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } // end btnExit_Click

        //Event handler to clear the form
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

        }// end btnClearForm_Click

        //validate input and create client
        private void btnCreateClient_Click(object sender, EventArgs e)
        {

            if (!(validate.checkID(txtPersonID.Text))) //check ID
            {
                MessageBox.Show("Please enter a digit ID");
                txtPersonID.Text = "";
                txtPersonID.Focus();
            }
            else if (!(validate.checkName(txtPersonName.Text))) //check name
            {
                MessageBox.Show("Please enter a valid name");
                txtPersonName.Text = "";
                txtPersonName.Focus();              
            }
            else if (!(validate.checkBirthDate(txtPersonBirthDate.Text))) //check birthdate
            {
                MessageBox.Show("Incorrect date formate enter MM/DD/YYYY.");
                txtPersonBirthDate.Text = "";
                txtPersonBirthDate.Focus();
            }
            else if (!(validate.checkName(txtClientType.Text))) //check client type
            {
                MessageBox.Show("Please enter a valid Client type!");
                txtClientType.Text = "";
                txtClientType.Focus();
            }
            else
            {
                client = new Client();
                client.Save(this);
                if (personList.addPerson(client))
                {

                    dbFunctions.InsertPerson(Convert.ToInt32(txtPersonID.Text), txtPersonName.Text,
                    txtPersonBirthDate.Text);
                    dbFunctions.InsertClient(Convert.ToInt32(txtPersonID.Text), txtClientType.Text);
                    MessageBox.Show("Person :" + txtPersonName.Text +
                                    " Added to DB and Serializable File. Press OK to continue.",
                                    "Transaction Complete", MessageBoxButtons.OK);

                    Reset();
                }
                else
                {
                    MessageBox.Show("ID already exist");
                }
            }
        }// end btnCreateClient_Click

        //validate input and create manager
        private void btnCreateManager_Click_1(object sender, EventArgs e)
        {
            if (!validate.checkID(txtPersonID.Text))//check ID
            {
                MessageBox.Show("Please enter a digit ID.");
                txtPersonID.Text = "";
                txtPersonID.Focus();
            }
            else if (!validate.checkName(txtPersonName.Text))//check name
            {
                MessageBox.Show("Please enter a valid Name.");
                txtPersonName.Text = "";
                txtPersonName.Focus();
            }            
            else if (!validate.checkBirthDate(txtPersonBirthDate.Text))//check birthdate
            {
                MessageBox.Show("Incorrect date formate enter MM/DD/YYYY.");
                txtPersonBirthDate.Text = "";
                txtPersonBirthDate.Focus();
            }
            else if (!validate.checkName(txtEmployeeJobTitle.Text))//check EmployeeJobTitle
            {
                MessageBox.Show("Please enter a valid Employee Job Title.");
                txtEmployeeJobTitle.Text = "";
                txtEmployeeJobTitle.Focus();
            }
            else if (!validate.checkMoney(txtManagerSalary.Text))//check salary
            {
                MessageBox.Show("Please enter valid Salary.");
                txtManagerSalary.Text = "";
                txtManagerSalary.Focus();
            }
            else if (!validate.checkMoney(txtManagerBonus.Text))//check bonus
            {
                MessageBox.Show("Please enter valid Bonus.");
                txtManagerBonus.Text = "";
                txtManagerBonus.Focus();
            }

            else
            {   //remove $ sign
                if (txtManagerBonus.Text.Contains('$'))
                {
                    txtManagerBonus.Text = txtManagerBonus.Text.Remove(0, 1);
                }
                if (txtManagerSalary.Text.Contains('$'))
                {
                    txtManagerSalary.Text = txtManagerSalary.Text.Remove(0, 1);
                }
                manager = new Manager();
                manager.Save(this);

                if (personList.addPerson(manager))
                {
                    dbFunctions.InsertPerson(Convert.ToInt32(txtPersonID.Text), txtPersonName.Text, txtPersonBirthDate.Text);
                    dbFunctions.InsertEmployee(Convert.ToInt32(txtPersonID.Text), txtEmployeeJobTitle.Text);
                    dbFunctions.InsertManager(Convert.ToInt32(txtPersonID.Text), Convert.ToInt32(txtManagerSalary.Text), Convert.ToInt32(txtManagerBonus.Text));
                    MessageBox.Show("Person :" + txtPersonName.Text +
                                    " Added to DB and Serializable File. Press OK to continue.",
                                    "Transaction Complete", MessageBoxButtons.OK);
                    Reset();
                }
                else
                {
                    MessageBox.Show("ID already exist");

                }
            }
        }// end btnCreateManager_Click





        //validate input and create worker
        private void btnCreateWorker_Click_1(object sender, EventArgs e)
        {           
            if (!validate.checkID(txtPersonID.Text))//check ID
            {
                MessageBox.Show("Please enter a valid ID.");
                txtPersonID.Text = "";
                txtPersonID.Focus();
            }
            else if (!validate.checkName(txtPersonName.Text))//check name
            {
                MessageBox.Show("Please enter a valid Name.");
                txtPersonName.Text = "";
                txtPersonName.Focus();
            }
            else if (!validate.checkBirthDate(txtPersonBirthDate.Text))//check birthdate
            {
                MessageBox.Show("Incorrect date formate enter MM/DD/YYYY.");
                txtPersonBirthDate.Text = "";
                txtPersonBirthDate.Focus();
            }
            else if (!validate.checkName(txtEmployeeJobTitle.Text))//check EmployeeJobTitle
            {
                MessageBox.Show("Please enter a valid Employee Job Title.");
                txtEmployeeJobTitle.Text = "";
                txtEmployeeJobTitle.Focus();
            }
            else if (!validate.checkMoney(txtWorkerHourlyPay.Text))//check hourly pay
            {
                MessageBox.Show("Please enter valid Hourly Pay.");
                txtWorkerHourlyPay.Text = "";
                txtWorkerHourlyPay.Focus();
            }

            else
            {   //remove $ sign
                if (txtWorkerHourlyPay.Text.Contains('$'))
                {
                    txtWorkerHourlyPay.Text = txtWorkerHourlyPay.Text.Remove(0, 1);
                }
                worker = new Worker();
                worker.Save(this);

                if (personList.addPerson(worker))
                {
                    dbFunctions.InsertPerson(Convert.ToInt32(txtPersonID.Text), txtPersonName.Text, txtPersonBirthDate.Text);
                    dbFunctions.InsertEmployee(Convert.ToInt32(txtPersonID.Text), txtEmployeeJobTitle.Text);
                    dbFunctions.InsertWorker(Convert.ToInt32(txtPersonID.Text), Convert.ToInt32(txtWorkerHourlyPay.Text));
                    MessageBox.Show("Person :" + txtPersonName.Text +
                                    " Added to DB and Serializable File. Press OK to continue.",
                                    "Transaction Complete", MessageBoxButtons.OK);
                    Reset();
                }
                else
                {
                    MessageBox.Show("ID already exist");
                }
            }

        }//end btnCreateWorker_Click

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

            bool hasOk = true;

            DialogResult dialogResult = MessageBox.Show("Do you want to delete?","Yes or no",MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (personList.personList.Count != 0)
                {
                    for (int i = 0; i < personList.personList.Count(); i++)
                    {
                        if (personList.personList[i].personID == txtPersonID.Text)
                        {
                            //deleting person from both list and database
                            personList.personList.RemoveAt(i);
                            dbFunctions.Delete(Convert.ToInt32(txtPersonID.Text));
                            MessageBox.Show("Person :" + txtPersonName.Text +
                                            " had been deleted from DB and Serializable File. Press OK to continue.",
                                            "Transaction Complete", MessageBoxButtons.OK);

                            //Enabling and disbling certain buttons and textboxes for deletion
                            grpEntryControl.Enabled = true;
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
                        // If txtPerson cannot be found in the list but exist in the database
                        else if (txtPersonID.Text != "")
                        {
                            if (dbFunctions.SelectPersonFromClient(int.Parse(txtPersonID.Text), out hasOk).HasRows == true)
                            {
                                //delete client from the database
                                dbFunctions.Delete(Convert.ToInt32(txtPersonID.Text));

                                MessageBox.Show("Person :" + txtPersonName.Text +
                                                " had been deleted from DB and Serializable File. Press OK to continue.",
                                                "Transaction Complete", MessageBoxButtons.OK);

                                //Enabling and disbling certain buttons and textboxes for deletion

                                grpEntryControl.Enabled = true;
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
                            else if (dbFunctions.SelectPersonFromManager(int.Parse(txtPersonID.Text), out hasOk).HasRows == true)
                            {
                                //Delete Manager from database
                                dbFunctions.Delete(Convert.ToInt32(txtPersonID.Text));
                                MessageBox.Show("Person :" + txtPersonName.Text +
                                                " had been deleted from DB and Serializable File. Press OK to continue.",
                                                "Transaction Complete", MessageBoxButtons.OK);
                                //Enabling and disbling certain buttons and textboxes for deletion
                                grpEntryControl.Enabled = true;
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
                            else if (dbFunctions.SelectPersonFromWorker(int.Parse(txtPersonID.Text), out hasOk).HasRows == true)
                            {
                                //Delete worker from database
                                dbFunctions.Delete(Convert.ToInt32(txtPersonID.Text));
                                MessageBox.Show("Person :" + txtPersonName.Text +
                                                " had been deleted from DB and Serializable File. Press OK to continue.",
                                                "Transaction Complete", MessageBoxButtons.OK);

                                //Enabling and disbling certain buttons and textboxes for deletion
                                grpEntryControl.Enabled = true;
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
                    }
                }
            }
            else if (dialogResult == DialogResult.No)
            {

            }

            
        }
        //button to display database information onto the form
        private void btnFindDisplay_Click_1(object sender, EventArgs e)
        {
            int matchCounter = 0;
            btnClearForm.Enabled = false;
            //The id needs to be valid
            if (!validate.checkID(txtPersonID.Text))
            {
                MessageBox.Show("Please enter a valid ID number");
            }
            else
            {
                Client newclient = new Client();
                newclient.personID = txtPersonID.Text;
                Manager newmanager = new Manager();
                newmanager.personID = txtPersonID.Text;
                Worker newworker = new Worker();
                newworker.personID = txtPersonID.Text;
                string[] person;
                string[] children;

                if (displayDbInformation(newclient) == true)
                {
                    //display database information for client
                    person = dbStringPerson.Split('*');
                    children = dbStringRest.Split('*');
                    txtPersonID.Text = person[0];
                    txtPersonName.Text = person[1];
                    txtPersonBirthDate.Text = person[2];
                    txtClientType.Text = children[0];

                    matchCounter++;

                    //Enabling and disbling certain buttons and textboxes for client
                    grpEntryControl.Enabled = false;
                    txtPersonID.Enabled = false;
                    txtPersonName.Enabled = true;
                    txtPersonBirthDate.Enabled = true;
                    txtClientType.Enabled = true;
                    grpEmployee.Enabled = false;
                    grpManager.Enabled = false;
                    grpClient.Enabled = true;
                    btnEditUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnFindDisplay.Enabled = false;
                    btnCancel.Visible = true;
                }
                else if (displayDbInformation(newclient) == false)
                {

                    if (displayDbInformation(newmanager) == true)
                    {
                        //display manager information from the database
                        person = dbStringPerson.Split('*');
                        children = dbStringRest.Split('*');
                        txtPersonID.Text = person[0];
                        txtPersonName.Text = person[1];
                        txtPersonBirthDate.Text = person[2];
                        txtEmployeeJobTitle.Text = children[0];
                        txtManagerSalary.Text = children[1];
                        txtManagerBonus.Text = children[2];

                        matchCounter++;

                        //Enabling and disbling certain buttons and textboxes for manager
                        grpEntryControl.Enabled = false;
                        txtPersonID.Enabled = false;
                        txtPersonName.Enabled = true;
                        txtPersonBirthDate.Enabled = true;
                        grpEmployee.Enabled = true;
                        grpManager.Enabled = true;
                        grpWorker.Enabled = false;
                        btnEditUpdate.Enabled = true;
                        btnDelete.Enabled = true;
                        btnFindDisplay.Enabled = false;
                        btnCancel.Visible = true;
                    }
                    else if (displayDbInformation(newmanager) == false)
                    {
                        if (displayDbInformation(newworker))
                        {
                            //Display worker information based on the database
                            person = dbStringPerson.Split('*');
                            children = dbStringRest.Split('*');
                            txtPersonID.Text = person[0];
                            txtPersonName.Text = person[1];
                            txtPersonBirthDate.Text = person[2];
                            txtEmployeeJobTitle.Text = children[0];
                            txtWorkerHourlyPay.Text = children[1];

                            matchCounter++;

                            //Enabling and disbling certain buttons and textboxes for worker

                            grpEntryControl.Enabled = false;
                            txtPersonID.Enabled = false;
                            txtPersonName.Enabled = true;
                            txtPersonBirthDate.Enabled = true;
                            grpEmployee.Enabled = true;
                            grpManager.Enabled = false;
                            grpWorker.Enabled = true;
                            btnEditUpdate.Enabled = true;
                            btnDelete.Enabled = true;
                            btnFindDisplay.Enabled = false;
                            btnCancel.Visible = true;
                        }

                        //Checks the list if it doeesn't exist in the database
                        else if (displayDbInformation(newworker) == false)
                        {
                            if (personList.personList.Count > 0)
                            {
                                //Loop through the list
                                for (int i = 0; i < personList.personList.Count; i++)
                                {
                                    // checks if the id matches for the client, manager, and worker
                                    if (personList.personList[i].personID == txtPersonID.Text)
                                    {
                                        if (personList.personList[i].GetType() == typeof(Client))
                                        {
                                            //Display client information from the list 
                                            personList.personList[i].Display(this);

                                            matchCounter++;

                                            //Enabling and disbling certain buttons and textboxes for client
                                            grpEntryControl.Enabled = false;
                                            txtPersonID.Enabled = false;
                                            txtPersonName.Enabled = true;
                                            txtPersonBirthDate.Enabled = true;
                                            txtClientType.Enabled = true;
                                            grpEmployee.Enabled = false;
                                            grpManager.Enabled = false;
                                            grpClient.Enabled = true;
                                            btnEditUpdate.Enabled = true;
                                            btnDelete.Enabled = true;
                                            btnFindDisplay.Enabled = false;
                                            btnCancel.Visible = true;
                                        }
                                        else if (personList.personList[i].GetType() == typeof(Manager))
                                        {
                                            //Display manager information
                                            personList.personList[i].Display(this);

                                            matchCounter++;

                                            //Enabling and disbling certain buttons and textboxes for manager
                                            grpEntryControl.Enabled = false;
                                            txtPersonID.Enabled = false;
                                            txtPersonName.Enabled = true;
                                            txtPersonBirthDate.Enabled = true;
                                            grpEmployee.Enabled = true;
                                            grpManager.Enabled = true;
                                            grpWorker.Enabled = false;
                                            btnEditUpdate.Enabled = true;
                                            btnDelete.Enabled = true;
                                            btnFindDisplay.Enabled = false;
                                            btnCancel.Visible = true;
                                        }
                                        
                                        else if (personList.personList[i].GetType() == typeof(Worker))
                                        {
                                            //display worker information in the list
                                            personList.personList[i].Display(this);

                                            matchCounter++;

                                            //Enabling and disbling certain buttons and textboxes for Worker
                                            grpEntryControl.Enabled = false;
                                            txtPersonID.Enabled = false;
                                            txtPersonName.Enabled = true;
                                            txtPersonBirthDate.Enabled = true;
                                            grpEmployee.Enabled = true;
                                            grpManager.Enabled = false;
                                            grpWorker.Enabled = true;
                                            btnEditUpdate.Enabled = true;
                                            btnDelete.Enabled = true;
                                            btnFindDisplay.Enabled = false;
                                            btnCancel.Visible = true;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Person does not exist");
                            }

                        }
                    }
                }

                if (matchCounter == 0)
                {
                    MessageBox.Show("Person does not exist");
                }
            }
        }

        //A button that edits client, manager, and worker information.
        private void btnEditUpdate_Click(object sender, EventArgs e)
        {

            int matchCounter = 0;

            //creates temporary client manager and worker with the same person ID
            Client newclient = new Client();
            newclient.personID = txtPersonID.Text;
            Manager newmanager = new Manager();
            newmanager.personID = txtPersonID.Text;
            Worker newworker = new Worker();
            newworker.personID = txtPersonID.Text;

            //The if and else if test if the id belongs to client, manager or worker
            if (displayDbInformation(newclient) == true)
            {
                //update client information for the database 
                dbFunctions.UpdatePerson(Convert.ToInt32(txtPersonID.Text), txtPersonName.Text, txtPersonBirthDate.Text);
                dbFunctions.UpdateClient(Convert.ToInt32(txtPersonID.Text), txtClientType.Text);
                MessageBox.Show("Person :" + txtPersonName.Text +
                            " had been upadted from DB and Serializable File. Press OK to continue.",
                            "Transaction Complete", MessageBoxButtons.OK);

                //Enabling and disbling certain buttons and textboxes for client
                grpEntryControl.Enabled = true;
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

            }
            else if (displayDbInformation(newmanager) == true)
            {
                //update manager information in the database
                dbFunctions.UpdatePerson(Convert.ToInt32(txtPersonID.Text), txtPersonName.Text, txtPersonBirthDate.Text);
                dbFunctions.UpdateManager(Convert.ToInt32(txtPersonID.Text), txtEmployeeJobTitle.Text, Convert.ToDecimal(txtManagerSalary.Text), Convert.ToDecimal(txtManagerBonus.Text));
                MessageBox.Show("Person :" + txtPersonName.Text +
                            " had been upadted from DB and Serializable File. Press OK to continue.",
                            "Transaction Complete", MessageBoxButtons.OK);

                //Enabling and disbling certain buttons and textboxes for manager
                grpEntryControl.Enabled = true;
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

            }
            else if (displayDbInformation(newworker) == true)
            {
                //update worker information in the database
                dbFunctions.UpdatePerson(Convert.ToInt32(txtPersonID.Text), txtPersonName.Text, txtPersonBirthDate.Text);
                dbFunctions.UpdateWorker(Convert.ToInt32(txtPersonID.Text), txtEmployeeJobTitle.Text, Convert.ToDecimal(txtWorkerHourlyPay.Text));
                MessageBox.Show("Person :" + txtPersonName.Text +
                            " had been upadted from DB and Serializable File. Press OK to continue.",
                            "Transaction Complete", MessageBoxButtons.OK);

                //Enabling and disbling certain buttons and textboxes for worker
                grpEntryControl.Enabled = true;
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
            }

            //If the information exist both in the list and the database
            else
            {
                //doesn't work if the list is empty
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
                                //creates a temporary manager 
                                Manager newManager = new Manager();
                                newManager.Save(this);   

                                //replaces the old manager with the new managaer
                                personList.personList.RemoveAt(i);
                                personList.personList.Insert(i, newManager);

                                //updates the database information for the manager
                                dbFunctions.UpdatePerson(Convert.ToInt32(txtPersonID.Text), txtPersonName.Text, txtPersonBirthDate.Text);
                                dbFunctions.UpdateManager(Convert.ToInt32(txtPersonID.Text), txtEmployeeJobTitle.Text, Convert.ToDecimal(txtManagerSalary.Text), Convert.ToDecimal(txtManagerBonus.Text));
                                MessageBox.Show("Person :" + txtPersonName.Text +
                                            " had been upadted from DB and Serializable File. Press OK to continue.",
                                            "Transaction Complete", MessageBoxButtons.OK);

                                matchCounter++;

                                //Enabling and disbling certain buttons and textboxes for Manager
                                grpEntryControl.Enabled = true;
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

                            else if (personList.personList[i].GetType() == typeof(Worker))
                            {
                                //Creates a temporary worker
                                Worker newWorker = new Worker();
                                newWorker.Save(this);
                                //replaces the old worker with new worker information
                                personList.personList.RemoveAt(i);
                                personList.personList.Insert(i, newWorker);

                                //Calls the update worker method and updates database information
                                dbFunctions.UpdatePerson(Convert.ToInt32(txtPersonID.Text), txtPersonName.Text, txtPersonBirthDate.Text);
                                dbFunctions.UpdateWorker(Convert.ToInt32(txtPersonID.Text), txtEmployeeJobTitle.Text, Convert.ToDecimal(txtWorkerHourlyPay.Text));
                                MessageBox.Show("Person :" + txtPersonName.Text +
                                            " had been upadted from DB and Serializable File. Press OK to continue.",
                                            "Transaction Complete", MessageBoxButtons.OK);

                                matchCounter++;

                                //Enabling and disbling certain buttons and textboxes for worker
                                grpEntryControl.Enabled = true;
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
                            else if (personList.personList[i].GetType() == typeof(Client))
                            {
                                //creates a temporty client 
                                Client newClient = new Client();
                                newClient.Save(this);

                                //replaces the old client info with new one
                                personList.personList.RemoveAt(i);
                                personList.personList.Insert(i, newClient);

                                //calls the update the client for the database
                                dbFunctions.UpdatePerson(Convert.ToInt32(txtPersonID.Text), txtPersonName.Text, txtPersonBirthDate.Text);
                                dbFunctions.UpdateClient(Convert.ToInt32(txtPersonID.Text), txtClientType.Text);
                                MessageBox.Show("Person :" + txtPersonName.Text +
                                            " had been upadted from DB and Serializable File. Press OK to continue.",
                                            "Transaction Complete", MessageBoxButtons.OK);


                                matchCounter++;

                                //Enabling and disbling certain buttons and textboxes for client
                                grpEntryControl.Enabled = true;
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
                }
            }
    
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            //Enabling and disbling certain buttons and textboxes for client
            grpEntryControl.Enabled = false;
            btnCreateManager.Enabled = false;
            btnCreateWorker.Enabled = false;
            txtPersonName.Enabled = true;
            txtPersonBirthDate.Enabled = true;
            grpClient.Enabled = true;
            btnCreateClient.Visible = true;
            txtClientType.Enabled = true;
            btnCreateClient.Enabled = true;
            btnCreateManager.Enabled = false;
            btnCreateWorker.Enabled = false;
            btnFindDisplay.Enabled = false;
            btnCancel.Visible = true;
        }


        private void btnManager_Click_1(object sender, EventArgs e)
        {
            //Enabling and disbling certain buttons and textboxes for manger
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
            //Enabling and disbling certain buttons and textboxes for Worker
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

        //reset method
        private void Reset()
        {
            //Enabling and disbling certain buttons and textboxes
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

            //Making sure the text boxes are all empty
            txtClientType.Text = "";
            txtEmployeeJobTitle.Text = "";
            txtManagerBonus.Text = "";
            txtManagerSalary.Text = "";
            txtPersonBirthDate.Text = "";
            txtPersonID.Text = "";
            txtPersonName.Text = "";
            txtWorkerHourlyPay.Text = "";
        }

        //A button that will reset all the text field values
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        //simple button to display the internal list
        private void btndisplayList_Click(object sender, EventArgs e)
        {
            personList.displayList();

        }

        //This method displays the database information
        public bool displayDbInformation(Person p)
        {
            bool successFlag;
            if (p == null)
            {
                return false;
            }  // end p == null if

            OleDbDataReader myDataReader;

            if (p.GetType() == typeof(Client))     // Process CLIENT
            {
                myDataReader = dbFunctions.SelectPersonFromClient(Convert.ToInt32(txtPersonID.Text), out successFlag);
                myDataReader.Read();
                if (!myDataReader.HasRows)
                {
                    return false;
                }
                else
                {
                    MessageBox.Show("Client record found and read.  ", "Client Record Found", MessageBoxButtons.OK);
                    try
                    {
                        dbStringPerson = myDataReader[0].ToString() + "*" + myDataReader[1].ToString() + "*";
                        dbStringPerson = dbStringPerson + ((DateTime)myDataReader[2]).ToString("MM/dd/yyyy") + Environment.NewLine;
                        dbStringRest = myDataReader[3].ToString();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }  // end try-catch
                }  // end else on myDataReader HasRows
            }  // end processing Client 

            else if (p.GetType() == typeof(Manager))     // Process MANAGER
            {

                try
                {
                    myDataReader = dbFunctions.SelectPersonFromManager(Convert.ToInt32(txtPersonID.Text), out successFlag);
                    myDataReader.Read();
                }
                catch
                {
                    return false;
                }

                if (!myDataReader.HasRows)
                {

                    return false;
                }
                else
                {
                    MessageBox.Show("Manager record found and read.", "Manager Record Found", MessageBoxButtons.OK);
                    try
                    {
                        dbStringPerson = myDataReader[0].ToString() + "*" + myDataReader[1].ToString() + "*";
                        dbStringPerson = dbStringPerson + ((DateTime)myDataReader[2]).ToString("MM/dd/yyyy") + Environment.NewLine;
                        dbStringRest = myDataReader[3].ToString() + "*" + Convert.ToDecimal(myDataReader[4]).ToString()
                            + "*" + Convert.ToDecimal(myDataReader[5]).ToString();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }  // end try-catch
                }  // end else on myDataReader HasRows
            }  // end Processing Manager

            else if (p.GetType() == typeof(Worker))   /// Process WORKER
            {
                try
                {
                    myDataReader = dbFunctions.SelectPersonFromManager(Convert.ToInt32(txtPersonID.Text), out successFlag);
                    myDataReader.Read();
                }
                catch
                {
                    return false;
                }
                if (!myDataReader.HasRows)
                {
                    return false;
                }
                else
                {
                    MessageBox.Show("Worker record found and read.  ", "Worker Record Found", MessageBoxButtons.OK);
                    try
                    {
                        dbStringPerson = myDataReader[0].ToString() + "*" + myDataReader[1].ToString() + "*"
                            + ((DateTime)myDataReader[2]).ToString("MM/dd/yyyy") + Environment.NewLine;
                        dbStringRest = myDataReader[3].ToString() + "*" + Convert.ToDecimal(myDataReader[4]).ToString();
                        return true;
                    }
                    catch
                    {
                        return false;
                    }  // end try-catch
                }  // end else on myDataReader HasRows
            }  // end processing Worker
            else
            {
                MessageBox.Show("Type of object to Edit/Update is not valid. Contact System Admin.", "Delete Object Type Error",
                    MessageBoxButtons.OK);
                MessageBox.Show("Number of records processed = " + recordsProcessedCount.ToString(),
                    "Exit Message", MessageBoxButtons.OK);
                return false;
            }  // end multiple alternative if
            MessageBox.Show(dbStringPerson + dbStringRest, "DataBase Retrieval", MessageBoxButtons.OK);
        }  // end displayDbInformation


    } //end class
} //end namespace
