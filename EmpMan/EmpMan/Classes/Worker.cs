
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
    class Worker : Employee
    {
        private Decimal HiddenWorkerHourlyPay;   // 

        // Parameterless constructor
        public Worker()
        {
            HiddenWorkerHourlyPay = 0m;
        }  // end Manager parameterless constructor

        // Parameterized constructor (not used)
        public Worker(string name, string birthdate, string id, string jt, Decimal hp) : base(name, birthdate, id, jt)
        {
            HiddenWorkerHourlyPay = hp;
        }  // end Manager parametierized constructor


        // Accessor/mutator for salary
        public Decimal WorkerHourlyPay
        {
            get
            {
                return HiddenWorkerHourlyPay;
            }  // end get
            set  //(Decimal value)
            {
                HiddenWorkerHourlyPay = value;
            }  // end get
        }  // end Property


        // Save data from form to object
        public override void Save(frmEmpMan f)
        {
            base.Save(f);
            WorkerHourlyPay = Convert.ToDecimal(f.txtWorkerHourlyPay.Text);
        }  // end Save


        // Display data in object on form
        public override void Display(frmEmpMan f)
        {
            base.Display(f);
            f.txtWorkerHourlyPay.Text = WorkerHourlyPay.ToString();
        }  // end Display


        // This toString function overrides the Employee toString
        //     function.  The base refers to the Employee because this class
        //     inherits Employee by definition.
        public override string ToString()
        {
            string s = base.ToString() + "\n";
            s += "WorkerHourlyPay:     " + HiddenWorkerHourlyPay.ToString() + "\n";
            return s;
        }  // end ToString


    }  // end Manager Class
}  // end namespace
