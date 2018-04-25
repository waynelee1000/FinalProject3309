using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMan.Classes
{
    public class PersonList
    {
        public List<Person> personList = new List<Person>();
        public PersonList()
        {

        }

        public void addPerson(Person p)
        {

            personList.Add(p);
        }

        public int Count()
        {
            int num = personList.Count();
            return num;
        }

        public bool deletePerson(string ID)
        {
            bool deletable = false;
            for (int i = 0; i < personList.Count; i++)
            {

                if (personList[i].personID == ID)
                {
                    personList[i] = null;
                    deletable = true;
                }
            }

            return deletable;
        }

        public bool displayPersonInList(string ID)
        {
            bool display = false;
            for (int i = 0; i < personList.Count; i++)
            {
                if (personList[i].personID == ID)
                {
                    if (personList[i].GetType() == typeof(Manager))
                    {

                    }
                    if (personList[i].GetType() == typeof(Worker))
                    {


                    }
                    if (personList[i].GetType() == typeof(Client))
                    {

                    }

                }
            }

            return display;
        }

    }
}
