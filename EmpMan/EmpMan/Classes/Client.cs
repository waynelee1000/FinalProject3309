using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

// For serialization
using System.Runtime.Serialization.Formatters.Binary;

namespace EmpMan.Classes
{
    // Client inherits the data and methods in Person
    //    and can be a serialized to a binary file
    [Serializable()]
    class Client : Person
    {

        private string HiddenClientType;   // Salary amount

        // Parameterless constructor
        public Client()
        {
            HiddenClientType = "";
        }  // end Manager parameterless constructor

        // Parameterized constructor (not used)
        public Client(string name, string birthdate, string id, string ct) : base(name, birthdate, id)
        {
            HiddenClientType = ct;
        }  // end Manager parametierized constructor


        // Accessor/mutator for name
        public string ClientType
        {
            get
            {
                return HiddenClientType;
            }  // end get
            set   // (string value)
            {
                HiddenClientType = value;
            }  // end get
        }  // end Property


        // Save data from form to object
        public override void Save(frmEmpMan f)
        {
            base.Save(f);
            ClientType = f.txtClientType.Text;
        }  // end Save


        // Display data in object on form
        public override void Display(frmEmpMan f)
        {
            base.Display(f);
            f.txtClientType.Text = ClientType.ToString();
        }  // end Display


        // This toString function overrides the Employee toString
        //     function.  The base refers to the Employee because this class
        //     inherits Employee by definition.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "ClientType:     " + HiddenClientType.ToString() + "\n";
            return s;
        }  // end ToString


    }  // end Manager Class
}  // end namespace

