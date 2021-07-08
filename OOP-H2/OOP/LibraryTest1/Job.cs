using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryTest1
{
    public class Job
    {
        public string jobTitle;
        public string jobPosition;
        public int salary;

        public Job(string jobTitle, string jobPosition, int salary)
        {
            this.jobTitle = jobTitle;
            this.jobPosition = jobPosition;
            this.salary = salary;
        }
    }
}
