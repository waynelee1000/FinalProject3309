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
        string strConnection = "provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=../Debug/Resources/EmpManDB.accdb";

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
        public bool InsertClient(int personID, string personName, string personBirthDate, string ClientType)
        {
            // SQL insert statement for Person
            string strInsertClient = "INSERT INTO CLIENT (fldID, fldName, fldBirthDate, fldClientType) " +
                "VALUES(" + personID + " , '" + personName + "', '" + personBirthDate +"', '" + ClientType + "' );";
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
        public bool InsertEmployee(int personID, string personName, string personBirthDate, string EmployeeJobTitle)
        {
            // SQL insert statement for Person
            string strInsertEmployee = "INSERT INTO EMPLOYEE (fldID, fldName, fldBirthDate, fldJobTitle) " +
                "VALUES(" + personID + " , '" + personName + "', '" + personBirthDate + "', '" + EmployeeJobTitle + "' );";
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
        public bool InsertManager(int personID, string personName, string personBirthDate, string EmployeeJobTitle, decimal ManagerSalary, decimal ManagerBonus)
        {
            // SQL insert statement for Person
            string strInsertManager = "INSERT INTO MANAGER (fldID, fldName, fldBirthDate, fldJobTitle, fldSalary, fldBonus) " +
                "VALUES(" + personID + " , '" + personName + "', '" + personBirthDate + " ', '" + EmployeeJobTitle + " ', '" + ManagerSalary + "' , '" + ManagerBonus + "' );";
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
        public bool InsertWorker(int personID, string personName, string personBirthDate, string EmployeeJobTitle, decimal WorkerHourlyPay)
        {
            // SQL insert statement for Person
            string strInsertWorker = "INSERT INTO WORKER (fldID, fldName, fldBirthDate, fldJobTitle, fldHourlyPay) " +
                "VALUES(" + personID + " , '" + personName + "', '" + personBirthDate + " ', '" + EmployeeJobTitle + " ', '" + WorkerHourlyPay  + "' );";
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
               + "CLIENT.fldClientType FROM PERSON "
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
        public OleDbDataReader SelectPersonFromEmployee(int personID, out bool OKFlag)
        {
            // string strSelectPerson = "SELECT * FROM CLIENT WHERE CLIENT.fldID = " + personID; 
            string strSelectEmployee = "SELECT PERSON.fldID, PERSON.fldName, PERSON.fldBirthDate, "
               + "EMPLOYEE.fldJobTitle FROM PERSON "
               + "INNER JOIN EMPLOYEE ON EMPLOYEE.fldID = PERSON.fldID "
               + "WHERE EMPLOYEE.fldID = " + personID + ";";

            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strSelectEmployee, myConnection);
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
            string strSelectManager = "SELECT PERSON.fldID, PERSON.fldName, PERSON.fldBirthDate, EMPLOYEE.fldJobTitle, "
               + "MANAGER.fldSalary, MANAGER.fldBonus  FROM PERSON "
               + "INNER JOIN EMPLOYEE ON EMPLOYEE.fldID = PERSON.fldID "
               + "INNER JOIN MANAGER ON MANAGER.fldID = EMPLOYEE.fldID "
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
            string strSelectWorker = "SELECT PERSON.fldID, PERSON.fldName, PERSON.fldBirthDate, EMPLOYEE.fldJobTitle, "
               + "WORKER.fldHourlyPay FROM PERSON "
               + "INNER JOIN EMPLOYEE ON EMPLOYEE.fldID = PERSON.fldID "
               + "INNER JOIN WORKER ON WORKER.fldID = EMPLOYEE.fldID "
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
        public bool UpdateClient(int personID, string personName, string personBirthDate, string ClientType)
        {
            // SQL insert statement for Person
            string strUpdateClient =
                "UPDATE PERSON SET fldName = " + "'" + personName + "'" + " , fldBirthDate = " + "'" + personBirthDate + "'" +
                "WHERE fldID = " + personID + " ;"+
                "UPDATE CLIENT SET fldName = " + "'" + personName + "'" + " , fldBirthDate = " + "'" + personBirthDate + "'" + ", fldClientType = " + "'" + ClientType + "'" +
                "WHERE fldID = " + personID + " ;";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateClient, myConnection);
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
                Console.Write("There was an update Client error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }
        public bool UpdateEmployee(int personID, string personName, string personBirthDate, string EmployeeJobTitle)
        {
            // SQL insert statement for Person
            string strUpdateEmployee =
                "UPDATE PERSON SET fldName = " + "'" + personName + "'" + " , fldBirthDate = " + "'" + personBirthDate + "'" +
                "WHERE fldID = " + personID + " ;" +
                "UPDATE EMPLOYEE SET fldName = " + "'" + personName + "'" + " , fldBirthDate = " + "'" + personBirthDate + "'" + ", fldJobTitle = " + "'" + EmployeeJobTitle + "'" +
                "WHERE fldID = " + personID + " ;";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strUpdateEmployee, myConnection);
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
                Console.Write("There was an update Employee error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }
        public bool UpdateManager(int personID, string personName, string personBirthDate, string EmployeeJobTitle, decimal ManagerSalary , decimal ManagerBonus)
        {
            // SQL insert statement for Person
            string strUpdateManager =
                "UPDATE PERSON SET fldName = " + "'" + personName + "'" + " , fldBirthDate = " + "'" + personBirthDate + "'" +
                "WHERE fldID = " + personID + " ;" +
                "UPDATE EMPLOYEE SET fldName = " + "'" + personName + "'" + " , fldBirthDate = " + "'" + personBirthDate + "'" + ", fldJobTitle = " + "'" + EmployeeJobTitle + "'" +
                "WHERE fldID = " + personID + " ;"+
                "UPDATE MANAGER SET fldName = " + "'" + personName + "'" + " , fldBirthDate = " + "'" + personBirthDate + "'" + ", fldJobTitle = " + "'" + EmployeeJobTitle + "'" + ", fldSalary = " + "'" + ManagerSalary + "'" + ", fldBonus = " + "'" + ManagerBonus + "'" +
                "WHERE fldID = " + personID + " ;"; 
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
        public bool UpdateWorker(int personID, string personName, string personBirthDate, string EmployeeJobTitle, decimal WorkerHourlyPay)
        {
            // SQL insert statement for Person
            string strUpdateManager =
                "UPDATE PERSON SET fldName = " + "'" + personName + "'" + " , fldBirthDate = " + "'" + personBirthDate + "'" +
                "WHERE fldID = " + personID + " ;" +
                "UPDATE EMPLOYEE SET fldName = " + "'" + personName + "'" + " , fldBirthDate = " + "'" + personBirthDate + "'" + ", fldJobTitle = " + "'" + EmployeeJobTitle + "'" +
                "WHERE fldID = " + personID + " ;" +
                "UPDATE WORKER SET fldName = " + "'" + personName + "'" + " , fldBirthDate = " + "'" + personBirthDate + "'" + ", fldJobTitle = " + "'" + EmployeeJobTitle + "'" + ", fldHourlyPay = " + "'" + WorkerHourlyPay + "'"  +
                "WHERE fldID = " + personID + " ;";
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
        public bool DeleteClient(int personID)
        {
            // SQL insert statement for Person
            string strDeleteClient =
                "DELETE FROM PERSON WHERE fldID = " + personID + " ;" +
                "DELETE FROM CLIENT WHERE fldID = " + personID + " ;";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strDeleteClient, myConnection);
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
                Console.Write("There was an Delete error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }
        public bool DeleteEmployee(int personID)
        {
            // SQL insert statement for Person
            string strDeleteEmployee =
                "DELETE FROM PERSON WHERE fldID = " + personID + " ;" +
                "DELETE FROM EMPLOYEE WHERE fldID = " + personID + " ;";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strDeleteEmployee, myConnection);
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
                Console.Write("There was an Delete employee error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }
        public bool DeleteManager(int personID)
        {
            // SQL insert statement for Person
            string strDeleteEmployee =
                "DELETE FROM PERSON WHERE fldID = " + personID + " ;" +
                "DELETE FROM EMPLOYEE WHERE fldID = " + personID + " ;" +
                "DELETE FROM MANAGER WHERE fldID = " + personID + " ;";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strDeleteEmployee, myConnection);
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
                Console.Write("There was an Delete Manager error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }
        public bool DeleteWorker(int personID)
        {
            // SQL insert statement for Person
            string strDeleteWorker =
                "DELETE FROM PERSON WHERE fldID = " + personID + " ;" +
                "DELETE FROM EMPLOYEE WHERE fldID = " + personID + " ;" +
                "DELETE FROM WORKER WHERE fldID = " + personID + " ;";
            OleDbConnection myConnection = new OleDbConnection(strConnection);
            OleDbCommand myCommand = new OleDbCommand(strDeleteWorker, myConnection);
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
                Console.Write("There was an Delete Worker error: " + ex.Message);

                return false; // returns false if Insert was unsuccessful
            }
            finally
            {
                myConnection.Close();
            }

        }

    }

}

