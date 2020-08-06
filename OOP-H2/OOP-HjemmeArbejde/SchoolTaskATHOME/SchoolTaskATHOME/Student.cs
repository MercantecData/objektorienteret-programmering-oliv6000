using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTaskATHOME
{
    public class Student
    {
        public string name;
        private string birthDate;
        public int parentPhoneNumber;
        public string parentEmail;
        private string address;

        public Student(string name, string birthDate, int parentPhoneNumber, string parentEmail, string address)
        {
            this.name = name;
            this.birthDate = birthDate;
            this.parentPhoneNumber = parentPhoneNumber;
            this.parentEmail = parentEmail;
            this.address = address;
        }
    }
}
