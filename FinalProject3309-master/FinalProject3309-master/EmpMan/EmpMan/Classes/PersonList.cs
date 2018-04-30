using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpMan.Classes
{
    [Serializable()]
    public class PersonList
    {
        public List<Person> personList = new List<Person>();
        public PersonList()
        {

        }

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
        }

        public int Count()
        {
            int num = personList.Count();
            return num;
        }

        public void displayList() {
            string PersonListString = " ";
            for (int i = 0; i < personList.Count; i++) {
                PersonListString += "PersonID:"+ personList[i].personID +" "+ personList[i].GetType()+"\n";
            }
            MessageBox.Show(PersonListString, "List in Serializable");
        }

    }
}
