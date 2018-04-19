
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
    class Employee : Person
    {
        private string HiddenEmployeeJobTitle;   // Salary amount

        // Parameterless constructor
        public Employee()
        {
            HiddenEmployeeJobTitle = "";
        }  // end Manager parameterless constructor

        // Parameterized constructor (not used)
        public Employee(string name, string birthdate, string id, string jt) : base(name, birthdate, id)
        {
            HiddenEmployeeJobTitle = jt;
        }  // end Manager parametierized constructor


        // Accessor/mutator for name
        public string EmployeeJobTitle
        {
            get
            {
                return HiddenEmployeeJobTitle;
            }  // end get
            set   // (string value)
            {
                HiddenEmployeeJobTitle = value;
            }  // end get
        }  // end Property


        // Save data from form to object
        public override void Save(frmEmpMan f)
        {
            base.Save(f);
            EmployeeJobTitle = f.txtEmployeeJobTitle.Text;
        }  // end Save


        // Display data in object on form
        public override void Display(frmEmpMan f)
        {
            base.Display(f);
            f.txtEmployeeJobTitle.Text = EmployeeJobTitle.ToString();
        }  // end Display


        // This toString function overrides the Employee toString
        //     function.  The base refers to the Employee because this class
        //     inherits Employee by definition.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "EmployeeJobTitle:     " + HiddenEmployeeJobTitle.ToString() + "\n";
            return s;
        }  // end ToString


    }  // end Manager Class
}  // end namespace

