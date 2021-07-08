using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTaskATHOME
{
    public class Teacher
    {
        public string name;
        private string birthDate;
        public int phoneNumber;
        public string email;
        private string address;
        private double salary;

        public Teacher(string name, string birthDate, int phoneNumber, string email, string address, double salary)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.phoneNumber = phoneNumber;
            this.email = email;
            this.address = address;
            this.salary = salary;
        }
    }
}
