using System;
using System.Collections.Generic;

namespace SchoolTaskATHOME
{
    public class School
    {
        private string name;
        private int founded;
        public List<Student> students = new List<Student>();
        public List<Teacher> teachers = new List<Teacher>();
        public List<Team> teams = new List<Team>();

        public School(string name, int founded)
        {
            this.name = name;
            this.founded = founded;
        }

    // Students
        public void addStudent(string studentName, string birthDate, int parrentPhoneNumber, string parrentEmail, string address)
        {
            students.Add(new Student(studentName, birthDate, parrentPhoneNumber, parrentEmail, address));
        }

        public Student removeStudent(string studentName, int parrentPhoneNumber, string parrentEmail)
        {
            foreach (var student in students)
            {
                if (student.name == studentName && student.parentEmail == parrentEmail && student.parentPhoneNumber == parrentPhoneNumber)
                {
                    Console.WriteLine("\nAre you sure you want to remove: " + studentName + "?");
                    bool i = true;
                    while (i == true) {
                        string userChoice = Console.ReadLine();
                        if (userChoice == "yes" || userChoice == "Yes")
                        {
                            i = false;

                            foreach (var team in teams)
                            {
                                int h = 0;

                                foreach (var studentInTeam in team.students)
                                {

                                    if (studentInTeam == student)
                                    {
                                        h += 1;
                                    }

                                }

                                if (h >= 1)
                                {
                                    team.students.Remove(student);
                                }
                            }
                            students.Remove(student);

                            return student;
                        }
                        else if (userChoice == "no" || userChoice == "No")
                        {
                            Console.WriteLine("\nStudent " + student.name + " was not removed.");
                            i = false;
                        }
                        else
                        {
                            Console.WriteLine("Please write either Yes or No");
                        }
                    }
                }
            }
            return null;
        }

        public void fetchAllStudents()
        {
            foreach (var student in students)
            {
                Console.WriteLine("Student name: " + student.name + "\nParrent email: " + student.parentEmail + "\nParrent phone number: " + student.parentPhoneNumber);
                Console.WriteLine("-------------------------------\n");
            }
        }

        public void fetchSpecificStudent(string studentName)
        {
            foreach (var student in students)
            {
                if (student.name == studentName)
                {
                    Console.WriteLine("\n--------------------------\nStudent(s) found --->\n");
                    Console.WriteLine("Student name: " + student.name + "\nParent email: " + student.parentEmail + "\nParent phone number: " + student.parentPhoneNumber);
                }
            }
        }

    // Teachers
        public void addTeacher(string teacherName, string birthDate, int phoneNumber, string email, string address, double salary)
            {
                teachers.Add(new Teacher(teacherName, birthDate, phoneNumber, email, address, salary));
            }

        public Teacher removeTeacher(string teacherName, int teacherPhoneNumber, string email)
        {
            foreach (var teacher in teachers)
            {
                if (teacher.name == teacherName && teacher.email == email && teacher.phoneNumber == teacherPhoneNumber)
                {
                    Console.WriteLine("\nAre you sure you want to remove: " + teacherName + "?");
                    bool i = true;
                    while (i == true)
                    {
                        string userChoice = Console.ReadLine();
                        if (userChoice == "yes" || userChoice == "Yes")
                        {
                            foreach (var team in teams)
                            {
                                int h = 0;
                                foreach (var teacherInTeam in team.teachers)
                                {
                                    if (teacherInTeam == teacher)
                                    {
                                        h += 1;
                                    }
                                }
                                if (h >= 1)
                                {
                                    team.teachers.Remove(teacher);
                                }
                            }
                            i = false;
                            return teacher;
                        }
                        else if (userChoice == "no" || userChoice == "No")
                        {
                            Console.WriteLine("\nTeacher " + teacher.name + " was not removed.");
                            i = false;
                        }
                        else
                        {
                            Console.WriteLine("Please write either Yes or No");
                        }
                    }
                }
            }
            return null;
        }

        public void fetchAllTeachers()
        {
            foreach (var teacher in teachers)
            {
                Console.WriteLine("Teacher name: " + teacher.name + "\nEmail: " + teacher.email + "\nPhone number: " + teacher.phoneNumber);
                Console.WriteLine("-------------------------------\n");
            }
        }

        public void fetchSpecificTeacher(string teacherName)
        {
            foreach (var teacher in teachers)
            {
                if (teacher.name == teacherName)
                {
                    Console.WriteLine("\n--------------------------\nTeacher(s) found --->\n");
                    Console.WriteLine("Student name: " + teacher.name + "\nParent email: " + teacher.email + "\nParent phone number: " + teacher.phoneNumber);
                }
            }
        }

    // Teams
        public void createTeam(string teamName)
        {
            teams.Add(new Team(teamName));
        }

        public void changeTeamName (string oldTeamName, string newTeamName)
        {
            int i = 0;
            foreach (var team in teams)
            {
                if (team.name == oldTeamName)
                {
                    i += 1;
                }

                
                if (i > 0)
                {
                    team.name = newTeamName;
                }
            }
        }

        public Team removeTeam(string teamRemove)
        {
            int i = 0;
            foreach (var team in teams)
            {
                if (team.name == teamRemove)
                {
                    i += 1;
                    return team;
                }
            }
                return null;
        }

        public void addStudentToTeam(string teamName, Student student)
        {
            int i = 0;
            foreach (var team in teams)
            {
                if (teamName == team.name)
                {
                    foreach (var studentInTeam in team.students)
                    {
                        if (student == studentInTeam)
                        {
                            i += 1;
                        }
                    }


                    if (i < 1) 
                    { 
                        team.students.Add(student);
                        Console.WriteLine(student.name + " Has succesfully been added to the team " + teamName + "\n-----------------------\nPress any key to continue");
                    }
                    else
                    {
                        Console.WriteLine("\n student " + student.name + " is already in that team.");
                        Console.ReadKey();
                    }
                }
            }
        }
        
        public void addTeacherToTeam(string teamName, Teacher teacher)
        {
            int i = 0;
            foreach (var team in teams)
            {
                if (teamName == team.name)
                {
                    foreach (var teacherInTeam in team.teachers)
                    {
                        if (teacher == teacherInTeam)
                        {
                            i += 1;
                        }
                    }


                    if (i < 1)
                    {
                        team.teachers.Add(teacher);
                        Console.WriteLine(teacher.name + " Has succesfully been added to the team " + teamName + "\n-----------------------\nPress any key to continue");
                    }
                    else
                    {
                        Console.WriteLine("\nTeacher " + teacher.name + " is already in that team.");
                        Console.ReadKey(); Console.Clear();
                    }
                }
            }
        }

        public void removeStudentFromTeam(string teamName, Student student)
        {
            int i = 0;
            foreach (var team in teams)
            {
                if (teamName == team.name)
                {
                    foreach (var studentInTeam in team.students)
                    {
                        if (student == studentInTeam)
                        {
                            i += 1;
                            
                        }
                    }

                    if (i >= 1)
                    {
                        Console.WriteLine("\n\n" + student.name + " was removed succesfully!");
                        team.students.Remove(student);
                        Console.WriteLine("\n\nPress any key to continue!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
        }
        public void removeTeacherFromTeam(string teamName, Teacher teacher)
        {
            int i = 0;
            foreach (var team in teams)
            {
                if (teamName == team.name)
                {
                    foreach (var teacherInTeam in team.teachers)
                    {
                        if (teacher == teacherInTeam)
                        {
                            i += 1;

                        }
                    }

                    if (i >= 1)
                    {
                        Console.WriteLine("\n\n" + teacher.name + " was removed succesfully!");
                        team.teachers.Remove(teacher);
                        Console.WriteLine("\n\nPress any key to continue!");
                        Console.ReadKey(); Console.Clear();
                    }
                }
            }
        }

        public void fetchAllTeams ()
        {
            foreach (var team in teams)
            {
                Console.WriteLine("- " + team.name);
            }
            Console.WriteLine("\n-------------");
        }

        public void fetchAllInTeam(string teamName)
        {
            foreach (var team in teams)
            {
                if (teamName == team.name)
                {
                    Console.WriteLine("This is all the people in the team: " + team.name);

                    Console.WriteLine("\nStudents--->");
                    foreach (var student in team.students)
                    {
                        Console.WriteLine(student.name);
                    }

                    Console.WriteLine("\nTeachers--->");
                    foreach (var teacher in team.teachers)
                    {
                        Console.WriteLine(teacher.name);
                    }
                }
            }
        }

        public void fetchTeamTeachers(string teamName)
        {
            foreach (var team in teams)
            {
                if (teamName == team.name)
                {
                    Console.WriteLine("Name: " + team.name);

                    Console.WriteLine("\nTeacher(s) in charge--->\n");
                    foreach (var teacher in team.teachers)
                    {
                        Console.WriteLine(teacher.name);
                    }
                }
            }
        }

        public void fetchTeachersTeam(Teacher teacher)
        {
            int i = 0;
            foreach (var team in teams)
            {
                foreach (var teamTeacher in team.teachers)
                {
                    if (teacher == teamTeacher)
                    {
                        i += 1;
                        Console.WriteLine(team.name);
                    }
                }
            }

            if (i <= 0)
            {
                Console.Clear();
                Console.WriteLine("The teacher " + teacher.name + " is not in charge of any teams!\n\nPress any key to continue");
                Console.ReadKey();
            }

        }
    }
}
