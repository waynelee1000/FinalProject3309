// Person Class
// Responsible for all processing related to a Person 
// Written in VB by Joseph Jupin     Fall 2009
// Converted to CSharp by Frank Friedman     Spring 2016

// This class contains the data and methods that are inherited
// by both the Employee and Client classes

// Class Person is an abstract class and must be inherited 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Globalization.CultureInfo;
//using System.Globalization.DateTimeStyles;
//using System.IFormatProvider;

// For serialization
using System.Runtime.Serialization.Formatters.Binary;

namespace EmpMan
{
    [Serializable()]
    public abstract class Person
    {
        private string HiddenPersonName; // Person name
        private DateTime HiddenPersonBirthDate;   // Person birth date
        private string HiddenPersonID;   // Person ID

        // Non-parameterized constructor
        public Person()
        {
            HiddenPersonName = "";
            HiddenPersonBirthDate = DateTime.Now;
            HiddenPersonID = "";
        }  // end Person Non-parameterized Constructor

        // Parameterized constructor (not used)
        public Person(string name, string birthdate, string id)
        {
            HiddenPersonName = name;
            HiddenPersonBirthDate = Convert.ToDateTime(birthdate);
            HiddenPersonID = id;
        }  // end Person parameterized constructor


        // Accessor/mutator for name
        public string personName
        {
            get
            {
                return HiddenPersonName;
            }  // end get
            set   // (string value)
            {
                HiddenPersonName = value;
            }  // end get
        }  // end Property


        // Accessor/mutator for birth date
        public DateTime personBirthDate
        {
            get
            {
                return HiddenPersonBirthDate;
            }  // end get
            set   // (DateTime value)
            {
                HiddenPersonBirthDate = value;
            }  // end get
        }  // end Property


        // Accessor/mutator for id
        public string personID
        {
            get
            {
                return HiddenPersonID;
            } //  end get
            set   // (string value)
            {
                HiddenPersonID = value;
            }  // end get
        }  // End Property


        // Save data from form to object
        public virtual void Save(frmEmpMan f)
        {
            personName = f.txtPersonName.Text;
            personBirthDate = DateTime.Parse(f.txtPersonBirthDate.Text);
            personID = f.txtPersonID.Text;
        }  // end Save


        // Display data in object on form
        public virtual void Display(frmEmpMan f)
        {
            f.txtPersonName.Text = personName;
            f.txtPersonBirthDate.Text = personBirthDate.ToShortDateString();
            f.txtPersonID.Text = personID;
        }  // end Display


        // This toString function overrides the Object toString
        // function.  The base refers to Object because this class
        // inherits Object by default.
        public override string ToString()
        {
            string s = "ObjectType       : " + base.ToString() + "\n";
            s += "PersonName     : " + HiddenPersonName + "\n";
            s += "PersonBirthDate: " + HiddenPersonBirthDate.ToShortDateString() + "\n";
            s += "PersonID       :" + HiddenPersonID;
            return s;
        }  // end ToString

    } // end PersonClass

} // end namespace


