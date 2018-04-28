// Persistent Object (Serializable File) Class 
// Responsible for all processing related to a Serializable File
// Written in VB by Joseph Jupin     Fall 2009
// Converted to CSharp by Frank Friedman   Ver 3  Spring 2016

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EmpMan.Classes;

// To read and write files
using System.IO;
// To serialize a persistant object
using System.Runtime.Serialization.Formatters.Binary;

namespace EmpMan
{
    public static class POManager
    {
        // This class manages the persistant object by reading from and writing to a file

        // Write the Person List to file as a serialized binary object
        public static bool writeToFile(ref PersonList plist, string fn)
        {
            Stream thisFileStream;
            BinaryFormatter serializer = new BinaryFormatter();

            if (plist.Count() > 0)
            {
                try
                {
                    thisFileStream = File.Create(fn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File open error: Person List not written", "POManager File Open");
                    MessageBox.Show(ex.ToString());
                    return false;
                }  // end Try

                try
                {
                    serializer.Serialize(thisFileStream, plist);
                    //MsgBox("File write: Person List was written")
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File write error: Person List not written", "POManager File Write");
                    MessageBox.Show(ex.ToString());
                    return false;
                }
                finally
                {
                    thisFileStream.Close();
                }  // end Try
            }
            else
                MessageBox.Show("No Person in List");
            // end if

            return true;  // The file write succeeded

        }  // end WriteToFile


        // Read the Person List from file as a serialized binary object
        public static bool ReadFromFile(out PersonList plist, string fn)
        {
            Stream TestFileStream;
            BinaryFormatter deserializer = new BinaryFormatter();

            if (File.Exists(fn))
            {
                try
                {
                    TestFileStream = File.OpenRead(fn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File open error: Open with new Person List", "POManager, File Open");
                    plist = new Classes.PersonList();
                    return false;
                }  // end Try

                try
                {
                    plist = (PersonList)deserializer.Deserialize(TestFileStream);
                    // pl = CType(deserializer.Deserialize(TestFileStream), PersonList);
                    // MsgBox("File open: Person loaded to List");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File read error: Open with new Person List", "POManager File Read");
                    plist = new Classes.PersonList();
                    return false;
                }
                finally
                {
                    TestFileStream.Close();
                }  // end Try
            }  // end then part of if
            else
            {
                MessageBox.Show("File does not exist: Open with new Person List", "PO Manager Exists ");
                plist = new Classes.PersonList();
            }  // end if

            return true;   // The file read succeeded

        }  // end readFromFile 

    }  // end POManager Class
}  // end namespace


