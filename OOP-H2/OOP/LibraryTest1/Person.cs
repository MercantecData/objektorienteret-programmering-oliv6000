using System;
using System.Collections.Generic;

namespace LibraryTest1
{
    public class Person
    {
        public string name;
        public int cpr;
        public string birthDate;
        public int height;
        public int weight;
        public Job job;

        public Person(string name, int cpr, string birthDate, int height, int weight, Job job)
        {
            this.name = name;
            this.cpr = cpr;
            this.birthDate = birthDate;
            this.height = height;
            this.weight = weight;
            this.job = job;
        }
    }

}
