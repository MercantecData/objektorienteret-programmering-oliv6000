using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTest1
{
    public class People
    {
        public List<Person> people = new List<Person>();

        public void addPersonToPeople(Person person)
        {
            people.Add(person);
        }
    }

}
