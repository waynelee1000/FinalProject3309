﻿using System;
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

    }
}
