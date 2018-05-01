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

        public frmEmpMan()
        {
            InitializeComponent();
        }

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
        }
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
                        dbFunctions.Delete(Convert.ToInt32(txtPersonID.Text));
                        MessageBox.Show("Person :" + txtPersonName.Text +
                                        " had been deleted from DB and Serializable File. Press OK to continue.",
                                        "Transaction Complete", MessageBoxButtons.OK);

                        matchCounter++;
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
                if (matchCounter == 0)
                {
                    MessageBox.Show("Person is not deleted");
                    btnEditUpdate.Enabled = false;
                    btnDelete.Enabled = false;
                    btnFindDisplay.Enabled = true;
                    btnCancel.Visible = false;
                    grpPerson.Enabled = false;
                    txtPersonName.Enabled = false;
                    txtPersonBirthDate.Enabled = false;
                    txtPersonID.Enabled = true;
                }
            }
        }

        private void btnFindDisplay_Click_1(object sender, EventArgs e)
        {
            int matchCounter = 0;
            btnClearForm.Enabled = false;

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
                    person = dbStringPerson.Split('*');
                    children = dbStringRest.Split('*');
                    txtPersonID.Text = person[0];
                    txtPersonName.Text = person[1];
                    txtPersonBirthDate.Text = person[2];
                    txtClientType.Text = children[0];

                    matchCounter++;

                    grpEntryControl.Enabled = false;
                    txtPersonID.Enabled = false;
                    txtPersonName.Enabled = true;
                    txtPersonBirthDate.Enabled = true;
                    txtClientType.Enabled = true;
                    grpEmployee.Enabled = false;
                    grpManager.Enabled = false;
                    btnEditUpdate.Enabled = true;
                    btnDelete.Enabled = true;
                    btnFindDisplay.Enabled = false;
                    btnCancel.Visible = true;
                }
                else if (displayDbInformation(newclient) == false)
                {

                    if (displayDbInformation(newmanager) == true)
                    {
                        person = dbStringPerson.Split('*');
                        children = dbStringRest.Split('*');
                        txtPersonID.Text = person[0];
                        txtPersonName.Text = person[1];
                        txtPersonBirthDate.Text = person[2];
                        txtEmployeeJobTitle.Text = children[0];
                        txtManagerSalary.Text = children[1];
                        txtManagerBonus.Text = children[2];

                        matchCounter++;

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
                            person = dbStringPerson.Split('*');
                            children = dbStringRest.Split('*');
                            txtPersonID.Text = person[0];
                            txtPersonName.Text = person[1];
                            txtPersonBirthDate.Text = person[2];
                            txtEmployeeJobTitle.Text = children[0];
                            txtWorkerHourlyPay.Text = children[1];

                            matchCounter++;

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
                            dbFunctions.UpdatePerson(Convert.ToInt32(txtPersonID.Text), txtPersonName.Text, txtPersonBirthDate.Text);
                            dbFunctions.UpdateManager(Convert.ToInt32(txtPersonID.Text), txtEmployeeJobTitle.Text, Convert.ToDecimal(txtManagerSalary.Text), Convert.ToDecimal(txtManagerBonus.Text));
                            MessageBox.Show("Person :" + txtPersonName.Text +
                                        " had been upadted from DB and Serializable File. Press OK to continue.",
                                        "Transaction Complete", MessageBoxButtons.OK);

                            matchCounter++;

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
                        if (personList.personList[i].GetType() == typeof(Worker))
                        {
                            Worker newWorker = new Worker();
                            newWorker.Save(this);
                            personList.personList.RemoveAt(i);
                            personList.personList.Insert(i, newWorker);
                            dbFunctions.UpdatePerson(Convert.ToInt32(txtPersonID.Text), txtPersonName.Text, txtPersonBirthDate.Text);
                            dbFunctions.UpdateWorker(Convert.ToInt32(txtPersonID.Text), txtEmployeeJobTitle.Text, Convert.ToDecimal(txtWorkerHourlyPay.Text));
                            MessageBox.Show("Person :" + txtPersonName.Text +
                                        " had been upadted from DB and Serializable File. Press OK to continue.",
                                        "Transaction Complete", MessageBoxButtons.OK);

                            matchCounter++;

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
                        if (personList.personList[i].GetType() == typeof(Client))
                        {
                            Client newClient = new Client();
                            newClient.Save(this);
                            personList.personList.RemoveAt(i);
                            personList.personList.Insert(i, newClient);

                            dbFunctions.UpdatePerson(Convert.ToInt32(txtPersonID.Text), txtPersonName.Text, txtPersonBirthDate.Text);
                            dbFunctions.UpdateClient(Convert.ToInt32(txtPersonID.Text), txtClientType.Text);
                            MessageBox.Show("Person :" + txtPersonName.Text +
                                        " had been upadted from DB and Serializable File. Press OK to continue.",
                                        "Transaction Complete", MessageBoxButtons.OK);


                            matchCounter++;

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
        private void Reset()
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
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btndisplayList_Click(object sender, EventArgs e)
        {
            personList.displayList();

        }

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
