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

        public void addPersonToPeople(string name, int cpr, string birthDate, int height, int weight, Job job)
        {
            people.Add(new Person(name, cpr, birthDate, height, weight, job));
        }
    }

}
