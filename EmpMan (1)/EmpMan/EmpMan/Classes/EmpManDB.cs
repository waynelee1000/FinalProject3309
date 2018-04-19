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
    }
}
