using System;
using LibraryTest1;

namespace test1test
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            Job job1 = new Job();
            CreatePeter(person1, job1);
            People people1 = new People();

            people1.addPersonToPeople(person1);

            
            foreach(var person in people1.people)
            {
                Console.WriteLine("Navn: " + person.name + "\nFødselsår: " + person.birthDate + "\ncpr: " + person.cpr + "\nJob: " + person.job.jobTitle + "\nsalary: " + person.job.salary);
            }

        
        }
        public static void CreatePeter(Person person1, Job job1) {
            person1.name = "Peter";
            person1.cpr = 1849587854;
            person1.height = 186;
            person1.weight = 78;
            person1.birthDate = "01-11-1998";
            job1.jobTitle = "programmør";
            job1.jobPosition = "employee";
            job1.salary = 20000;
            person1.job = job1;
        }
    }
}
