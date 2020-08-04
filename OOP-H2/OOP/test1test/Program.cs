using System;
using LibraryTest1;

namespace TestLibrary1
{
    class Program
    {
        static void Main(string[] args)
        {
            People people1 = new People();
            CreatePeter(people1);

            Job job = (new Job("it-supporter", "employee", 15000));
            Person person = (new Person("Laban", 1948578468, "04-07-1978", 172, 99, job));
            CreatePerson(people1, person);
        }
        public static void CreatePeter(People people1) {
            Job job1 = (new Job("programmør", "employee", 20000));
            Person person1 = (new Person("Peter", 1849587854, "01-11-1998", 186, 78, job1));
            
            
            people1.addPersonToPeople(person1);
            
                Console.WriteLine("Navn: " + person1.name + "\nFødselsår: " + person1.birthDate + "\ncpr: " + person1.cpr + "\nJob: " + person1.job.jobTitle + "\nsalary: " + person1.job.salary);

        }
        public static void CreatePerson(People people, Person person1)
        {
            
                Console.WriteLine("\nNavn: " + person1.name + "\nFødselsår: " + person1.birthDate + "\ncpr: " + person1.cpr + "\nJob: " + person1.job.jobTitle + "\nsalary: " + person1.job.salary);
            

            people.addPersonToPeople(person1);
        }
    }
}
