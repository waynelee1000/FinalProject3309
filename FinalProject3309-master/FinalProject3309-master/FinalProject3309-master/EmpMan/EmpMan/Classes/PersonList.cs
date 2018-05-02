using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpMan.Classes
{
    [Serializable()]

    //Encapsulates methods for manipulating the personlist
    public class PersonList
    {
        public List<Person> personList = new List<Person>();

        //parameterless constructor
        public PersonList()
        {

        }//end constructor

        //method to add a person to the list
        public bool addPerson(Person p)
        {
            int matchCounter = 0;
            bool add = false;
            if (personList.Count == 0)
            {

                personList.Add(p);
                add = true;
            }
            else
            {
                for (int i = 0; i < personList.Count; i++)
                {
                    if (personList[i].personID == p.personID)
                    {
                        matchCounter++;

                        add = false;
                        break;

                    }
                }

                if (matchCounter == 0)
                {
                    add = true;
                    personList.Add(p);
                }
                
            }
            return add;
        } //end addPerson

        //method to count items in the personlist
        public int Count()
        {
            int num = personList.Count();
            return num;
        }// end Count

        //method to display items in the personlist
        public void displayList() {
            string PersonListString = " ";
            for (int i = 0; i < personList.Count; i++) {
                PersonListString += "PersonID:"+ personList[i].personID +" "+ personList[i].GetType()+"\n";
            }
            MessageBox.Show(PersonListString, "List in Serializable");
        }// end displayList
    } //end class
} //end namespace
