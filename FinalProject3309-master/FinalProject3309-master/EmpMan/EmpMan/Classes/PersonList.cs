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

    }
}
