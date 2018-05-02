/*
 * EmpMan Database Class
 * Authors: Nick Filauro & Erika Gepilano
 * April 2016 * Version 1
 * 
 * Updated 11/18/2016 * Version 2 * Elliot Stoner
 * Updated 06/17/2017 * Version 3 * Frank Friedman
 * 
 * Purpose: A class that interacts and performs database operations for Empman
 * in a Microsoft Access database using an OLEDB Data Reader.
 * It will contain methods for CRUD (Create, Read, Update, Delete) operations.
 * 
 * !! Requirements !!
 * You must have the Access Database Engine installed on the system you are running the program on.
 * https://www.microsoft.com/en-us/download/details.aspx?id=13255
 * 
 * No constructors were written
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.OleDb;

namespace EmpMan.Classes
{
    class EmpManDB
    {
        // Connection string for EmpManDB (type: Microsoft Access) in the Resources folder
        string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=../Debug/EmpManDB.accdb";

        // *********** INSERTION METHODS **********
        // Inserts a new record for Person in the Person table with parameters name, birthDate and personID
        public bool InsertPerson(int personID, string personName, string personBirthDate)
        {
            // SQL insert statement for Person
            string strInsertPerson = "INSERT INTO PERSON (fldID, fldName, fldBirthDate) " +
                "VALUES(" + personID + " , '" + personName + "', '" + personBirthDate + "' );";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertPerson, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Insert Person error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }
        public bool InsertClient(int personID, string ClientType)
        {
            // SQL insert statement for Person
            string strInsertClient = "INSERT INTO CLIENT (fldID, fldType) " +
                "VALUES(" + personID + " , '" + ClientType + "' );";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertClient, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Insert Person error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }
        public bool InsertEmployee(int personID, string EmployeeJobTitle)
        {
            // SQL insert statement for Person
            string strInsertEmployee = "INSERT INTO EMPLOYEE (fldID, fldTitle) " +
                "VALUES(" + personID + " , '" + EmployeeJobTitle + "' );";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertEmployee, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Insert Person error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }
        public bool InsertManager(int personID,  decimal ManagerSalary, decimal ManagerBonus)
        {
            // SQL insert statement for Person
            string strInsertManager = "INSERT INTO MANAGER (fldID, fldSalary, fldBonus) " +
                "VALUES(" + personID + " , '" + ManagerSalary + "' , '" + ManagerBonus + "' );";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertManager, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Insert Person error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }
        public bool InsertWorker(int personID, decimal WorkerHourlyPay)
        {
            // SQL insert statement for Person
            string strInsertWorker = "INSERT INTO WORKER (fldID, fldHourlyPay) " +
                "VALUES(" + personID + " , '" + WorkerHourlyPay  + "' );";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strInsertWorker, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Insert Person error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }
        public OleDbDataReader SelectPersonFromClient(int personID, out bool OKFlag)
        {
            // string strSelectPerson = "SELECT * FROM CLIENT WHERE CLIENT.fldID = " + personID; 
            string strSelectPerson = "SELECT PERSON.fldID, PERSON.fldName, PERSON.fldBirthDate, "
               + "CLIENT.fldType FROM PERSON "
               + "INNER JOIN CLIENT ON CLIENT.fldID = PERSON.fldID "
               + "WHERE CLIENT.fldID = " + personID + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectPerson, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                OKFlag = true; // returns true if Select was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an error: " + ex.Message);
                myDataReader = null;
                myConnection.Close();
                OKFlag = false; // returns false if Select was unsuccessful
            }

            return myDataReader;
        }  // end SelectPersonFromClient
       
        public OleDbDataReader SelectPersonFromManager(int personID, out bool OKFlag)
        {
            // string strSelectPerson = "SELECT * FROM CLIENT WHERE CLIENT.fldID = " + personID; 
            
            string strSelectManager = "SELECT PERSON.fldID, PERSON.fldName, PERSON.fldBirthDate, "
               + "EMPLOYEE.fldTitle, MANAGER.fldSalary, MANAGER.fldBonus FROM(PERSON "
               + "INNER JOIN EMPLOYEE ON EMPLOYEE.fldID = PERSON.fldID) "
               + "INNER JOIN MANAGER ON MANAGER.fldID = PERSON.fldID "
               + "WHERE PERSON.fldID = " + personID + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectManager, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                OKFlag = true; // returns true if Select was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an error: " + ex.Message);
                myDataReader = null;
                myConnection.Close();
                OKFlag = false; // returns false if Select was unsuccessful
            }

            return myDataReader;
        }  // end SelectPersonFromClient
        public OleDbDataReader SelectPersonFromWorker(int personID, out bool OKFlag)
        {
            // string strSelectPerson = "SELECT * FROM CLIENT WHERE CLIENT.fldID = " + personID; 
            string strSelectWorker = "SELECT PERSON.fldID, PERSON.fldName, PERSON.fldBirthDate, EMPLOYEE.fldTitle, "
            + "WORKER.fldHourlyPay FROM (PERSON "
            + "INNER JOIN EMPLOYEE ON EMPLOYEE.fldID = PERSON.fldID) "
            + "INNER JOIN WORKER ON WORKER.fldID = PERSON.fldID "
            + "WHERE PERSON.fldID = " + personID + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectWorker, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                OKFlag = true; // returns true if Select was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an error: " + ex.Message);
                myDataReader = null;
                myConnection.Close();
                OKFlag = false; // returns false if Select was unsuccessful
            }

            return myDataReader;
        }  // end SelectPersonFromClient
        public bool UpdatePerson(int personID, string personName, string personBirthDate)
        {
            string strUpdatePerson = "UPDATE PERSON SET fldName = '" + personName + "', fldBirthDate = " + "'" + personBirthDate + "' WHERE fldID = " + personID+";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdatePerson, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update Client error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful

        }
        public bool UpdateClient(int personID, string ClientType)
        {
            string strUpdateClient = "UPDATE CLIENT SET fldType = '" + ClientType + "' WHERE fldID = " + personID+";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateClient, myConnection);

            try
            {
                myConnection.Open();
                myCommand.ExecuteNonQuery();
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an Update Client error: " + ex.Message);
                myConnection.Close();
                return false; // returns false if Update was unsuccessful
            }

            return true; // returns true if Update was successful
            
        }
        public bool UpdateManager(int personID, string EmployeeJobTitle, decimal ManagerSalary , decimal ManagerBonus)
        {
            // SQL insert statement for Person
            string strUpdateManager =
                "UPDATE EMPLOYEE SET  fldTitle = '" + EmployeeJobTitle + "' WHERE fldID = " + personID+";"+
                "UPDATE MANAGER SET fldSalary = " + "'" + ManagerSalary + "'" + ", fldBonus = " + "'" + ManagerBonus + "'" + "WHERE fldID = " + personID + " ;"; 
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateManager, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an update Manager error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }
        public bool UpdateWorker(int personID, string EmployeeJobTitle, decimal WorkerHourlyPay)
        {
            string strUpdateManager =
                "UPDATE EMPLOYEE SET  fldTitle = '" + EmployeeJobTitle + "' WHERE fldID = " + personID + ";" + 
                "UPDATE WORKER SET fldHourlyPay = " + "'" + WorkerHourlyPay + "'" +"WHERE fldID = " + personID + " ;";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateManager, myConnection);
            OleDbDataReader myDataReader;

            try
            {
                myConnection.Open();
                myDataReader = myCommand.ExecuteReader();
                myDataReader.Close();
                return true; // returns true if Insert was successful
            }
            catch (OleDbException ex)
            {
                Console.Write("There was an update Manager error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }
        public void Delete(int personID)
        {
            using (OleDbConnection connection = new OleDbConnection(strConnection))
            {
                try
                {
                    connection.Open();

                    using (OleDbCommand command1 = new OleDbCommand("DELETE FROM PERSON WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command1.ExecuteReader();
                    }
                    using (OleDbCommand command2 = new OleDbCommand("DELETE FROM CLIENT WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command2.ExecuteReader();
                    }
                    using (OleDbCommand command3 = new OleDbCommand("DELETE FROM EMPLOYEE WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command3.ExecuteReader();
                    }
                    using (OleDbCommand command4 = new OleDbCommand("DELETE FROM MANAGER WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command4.ExecuteReader();
                    }
                    using (OleDbCommand command5 = new OleDbCommand("DELETE FROM WORKER WHERE fldID = " + personID, connection))
                    {
                        OleDbDataReader reader = command5.ExecuteReader();
                    }
                    connection.Close();
                }
                catch (OleDbException ex)
                {
                    Console.Write("Error: " + ex.Message);
                    connection.Close();
                }
            }  // end using block
            // FormController.clear(this);
        }  // end Delete

    }

}

