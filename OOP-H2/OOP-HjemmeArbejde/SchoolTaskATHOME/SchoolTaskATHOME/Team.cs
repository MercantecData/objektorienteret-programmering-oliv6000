using System;
using System.Collections.Generic;
using System.Text;

namespace SchoolTaskATHOME
{
    public class Team
    {
        public string name;
        public List<Student> students = new List<Student>();
        public List<Teacher> teachers = new List<Teacher>();

        public Team(string name)
        {
            this.name = name;
        }
    }
}
