using System;
using SchoolTaskATHOME;

namespace SchoolTestConsole
{
    class Program
    {
            public static School school = new School("Mercantec", 1998);

        static void Main(string[] args)
        {
            createStudentsTeachersTeams();

            bool i = true;
                Console.Clear();
            while (i == true) {
                Console.WriteLine("What do you want to access in the school?\nWrite the number of the following, you wish to access!\n\n1) students\n2) teachers\n3) teams\n");
                string userChoice = Console.ReadLine();
                if (userChoice == "1")
                {
                    Console.Clear();
                    students();
                }
                else if (userChoice == "2")
                {
                    Console.Clear();
                    teacher();
                }
                else if (userChoice == "3")
                {
                    Console.Clear();
                    teams();
                }
            }
        }

        public static void createStudentsTeachersTeams()
        {
            //Students
            school.addStudent("Karl", "01-15-2001", 48759685, "JennyJensen@gmail.com", "tvassten 17");
            school.addStudent("Poul", "04-10-2010", 18495868, "MarkTresen@outlook.com", "klepstrop 08");
            school.addStudent("Kim", "07-21-2005", 16485245, "T1mTreck@yahoo.com", "hilltop 42");
            school.addStudent("Lars", "02-30-2017", 46841525, "LisbethTremp@live.com", "grogsten 21");

            //Teachers
            school.addTeacher("Kevin", "01-17-1980", 16949985, "KevinKevson@outlook.com", "jeltrop 43", 20000);
            school.addTeacher("Juli", "21-01-1988", 16495844, "julijipson@outlook.com", "jeltrop 02", 18000);
            school.addTeacher("Poul", "18-05-1998", 18459875, "PoulKover@outlook.com", "Koltrop 08", 22000);
            school.addTeacher("Mari", "07-12-1972", 11548556, "MariEverson@outlook.com", "thievlstrip 12", 26000);

            //Teams
            school.createTeam("Team1");
            school.createTeam("Team2");
            school.createTeam("Team3");
        }

        public static void students()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do in students?\n\n1) Fetch all students in the school\n2) Add new student to the school\n3) Add student to a team\n4) Remove student from a team\n5) Remove a student\n\nWrite the number of what you'd like to do.");

            bool i = true;
            while (i == true)
            {
                string userChoice = Console.ReadLine();
                if (userChoice == "1")
                {
                    i = false;
                    Console.Clear();
                    Console.WriteLine("Here are all the students in the school--->\n\n");
                    school.fetchAllStudents();
                    Console.WriteLine("\nPress any key to conitnue!");
                    Console.ReadKey(); Console.Clear();
                }
                else if (userChoice == "2")
                {
                    i = false;
                    Console.WriteLine("\nTo add a student to the school, fill out the following information");

                    Console.Write("Student name: "); string studentName = Console.ReadLine();
                    Console.Write("Student birth date: "); string birthDate = Console.ReadLine();
                    Console.Write("Parrent phone number: "); int parrentPhoneNumber = int.Parse(Console.ReadLine());
                    Console.Write("Parrent Email: "); string parrentEmail = Console.ReadLine();
                    Console.Write("Student address: "); string address = Console.ReadLine();

                    school.addStudent(studentName, birthDate, parrentPhoneNumber, parrentEmail, address);
                    Console.WriteLine("\n" + studentName + " has succesfully been added to the school!\n\nPress any key to continue");
                    Console.ReadKey(); Console.Clear();
                }
                else if (userChoice == "3")
                {
                    i = false;
                    Console.WriteLine("\nTo add a student to a team, fill out the following information");

                    Console.Write("Team name: "); string teamName = Console.ReadLine(); 
                    Console.Write("Student name: "); string studentName = Console.ReadLine(); 
                    Console.Write("Parrent Email: "); string parrentEmail = Console.ReadLine(); 
                    Console.Write("Parrent phone number: "); int parrentPhoneNumber = int.Parse(Console.ReadLine());

                    Console.Clear();
                    addStudentToTeam(teamName, studentName, parrentEmail, parrentPhoneNumber);
                    Console.ReadKey(); Console.Clear();
                }
                else if (userChoice == "4")
                {
                    i = false;
                    Console.WriteLine("\nTo remove a student from a team, fill out the following information");

                    Console.Write("Team name: "); string teamName = Console.ReadLine();
                    Console.Write("Student name: "); string studentName = Console.ReadLine();
                    Console.Write("Parrent Email: "); string parrentEmail = Console.ReadLine();
                    Console.Write("Parrent phone number: "); int parrentPhoneNumber = int.Parse(Console.ReadLine());

                    int n = 0;
                    foreach (var student in school.students)
                    {
                        if (student.name == studentName && student.parentEmail == parrentEmail && student.parentPhoneNumber == parrentPhoneNumber)
                        {
                            n += 1;
                            school.removeStudentFromTeam(teamName, student);
                        }
                    }
                    if (n < 0)
                    {
                        Console.WriteLine(studentName + " was not removed from " + teamName + "\n\nPress any key to coninue!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else if (userChoice == "5")
                {
                    i = false;
                    Console.WriteLine("\nTo remove a student from the school, fill out the following information");

                    Console.Write("full name: "); string studentName = Console.ReadLine();
                    Console.Write("Parrent Email: "); string parrentEmail = Console.ReadLine();
                    Console.Write("Parrent phone number: "); int parrentPhoneNumber = int.Parse(Console.ReadLine());

                    var removedStudent = school.removeStudent(studentName, parrentPhoneNumber, parrentEmail);

                    Console.WriteLine("\n" + removedStudent.name + " has succesfully been removed from the school!\n\nPress any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Write a number from one of the following!\n1) Fetch all students in the school\n2) Add new student to the school\n3) Add student to a team\n4) Remove student from a team\n5) Remove a student\n");
                }
            }
        }

        public static void teacher()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do in teachers?\n\n1) Fetch all teachers in the school\n2) Add new teacher to the school\n3) Add teacher to a team\n4) Remove teacher from a team\n5) Remove a teacher\n\nWrite the number of what you'd like to do.");

            bool i = true;
            while (i == true)
            {
                string userChoice = Console.ReadLine();
                if (userChoice == "1")
                {
                    i = false;
                    Console.Clear();
                    Console.WriteLine("Here are all the teachers in the school--->\n\n");
                    school.fetchAllTeachers();
                    Console.WriteLine("\nPress any key to conitnue!");
                    Console.ReadKey(); Console.Clear();
                }
                else if (userChoice == "2")
                {
                    i = false;
                    Console.WriteLine("\nTo add a teacher to the school, fill out the following information");

                    Console.Write("Teacher name: "); string name = Console.ReadLine();
                    Console.Write("Teacher birth date: "); string birthDate = Console.ReadLine();
                    Console.Write("Teacher phone number: "); int phoneNumber = int.Parse(Console.ReadLine());
                    Console.Write("Teacher email: "); string email = Console.ReadLine();
                    Console.Write("Teacher address: "); string address = Console.ReadLine();
                    Console.Write("Teacher salary: "); int salary = int.Parse(Console.ReadLine());

                    school.addTeacher(name, birthDate, phoneNumber, email, address, salary);
                    Console.WriteLine("\n" + name + " has succesfully been added to the school!\n\nPress any key to continue");
                    Console.ReadKey(); Console.Clear();
                }
                else if (userChoice == "3")
                {
                    i = false;
                    Console.WriteLine("\nTo add a teacher to a team, fill out the following information");

                    Console.Write("Team name: "); string teamName = Console.ReadLine();
                    Console.Write("Teacher name: "); string name = Console.ReadLine();
                    Console.Write("Teacher Email: "); string email = Console.ReadLine();
                    Console.Write("Teacher phone number: "); int phoneNumber = int.Parse(Console.ReadLine());

                    Console.Clear();
                    addTeacherToTeam(teamName, name, email, phoneNumber);
                    Console.ReadKey(); Console.Clear();
                }
                else if (userChoice == "4")
                {
                    i = false;
                    Console.WriteLine("\nTo remove a teacher from a team, fill out the following information");

                    Console.Write("Team name: "); string teamName = Console.ReadLine();
                    Console.Write("teacher name: "); string teacherName = Console.ReadLine();
                    Console.Write("teacher Email: "); string email = Console.ReadLine();
                    Console.Write("teacher phone number: "); int phoneNumber = int.Parse(Console.ReadLine());

                    int n = 0;
                    foreach (var teacher in school.teachers)
                    {
                        if (teacher.name == teacherName && teacher.email == email && teacher.phoneNumber == phoneNumber)
                        {
                            n += 1;
                            school.removeTeacherFromTeam(teamName, teacher);
                        }
                    }
                    if (n < 0)
                    {
                        Console.WriteLine(teacherName + " was not removed from " + teamName + "\n\nPress any key to coninue!");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else if (userChoice == "5")
                {
                    i = false;
                    Console.WriteLine("\nTo remove a teacher from the school, fill out the following information");

                    Console.Write("Teacher name: "); string name = Console.ReadLine();
                    Console.Write("Teacher Email: "); string email = Console.ReadLine();
                    Console.Write("Teacher phone number: "); int phoneNumber = int.Parse(Console.ReadLine());

                    var removedTeacher = school.removeTeacher(name, phoneNumber, email);

                    Console.WriteLine("\n" + removedTeacher.name + " has succesfully been removed from the school!\n\nPress any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Write one from one of the following!\n\n1) Fetch all teachers in the school\n2) Add new teacher to the school\n3) Add teacher to a team\n4) Remove teacher from a team\n5) Remove a teacher\n");
                }
            }
        }

        public static void teams()
        {
            Console.Clear();
            Console.WriteLine("What would you like to do in teams?\n\n1) Fetch all teams\n2) Fetch all people in specific team\n3) Create a new team\n4) Change existing team name\n5) Remove a team\n\nWrite the number of what you'd like to do.");

            bool i = true;
            while (i == true)
            {
                string userChoice = Console.ReadLine();
                if (userChoice == "1")
                {
                    i = false;
                    Console.Clear();

                    Console.WriteLine("These are all the teams in the school--->\n");
                    school.fetchAllTeams();
                    Console.WriteLine("Press any key to continue!"); Console.ReadKey(); Console.Clear();
                }
                else if (userChoice == "2")
                {
                    i = false;
                    Console.Clear();
                    Console.WriteLine("Write the name of the team you'd like to fetch!");
                    string teamName = Console.ReadLine();

                    Console.Clear();
                    school.fetchAllInTeam(teamName);
                    Console.WriteLine("\n-------------------------\nPress any key to continue!");
                    Console.ReadKey(); Console.Clear();
                }
                
                if (userChoice == "3")
                {
                    i = false;
                    Console.Clear();

                    Console.Write("To creat a new team fill out the following information!\n\nTeam name: "); string teamName = Console.ReadLine();

                    school.createTeam(teamName);

                    Console.WriteLine("\n-----------------------\nThe team " + teamName + " has succesfully been created!\n\n-----------------------\nPress any key to continue!");
                    Console.ReadKey(); Console.Clear();
                }
                if (userChoice == "4")
                {
                    i = false;
                    Console.Clear();

                    Console.Write("To change a teams name fill out the following information!\n\nCurrent team name: "); string oldTeamName = Console.ReadLine();
                    Console.Write("New team name: "); string newTeamName = Console.ReadLine();

                    school.changeTeamName(oldTeamName, newTeamName);
                    Console.WriteLine("\nThe team name *" + oldTeamName + "* has succesfully been replaced with *" + newTeamName + "*\n\n--------------------\nPress any key to continue");
                    Console.ReadKey(); Console.Clear();
                }
                if (userChoice == "5")
                {
                    i = false;
                    Console.Clear();

                    Console.Write("To remove a team fill out the following information!\n\nTeam name: "); string teamName = Console.ReadLine();
                    
                    var teamToRemove = school.removeTeam(teamName);
                    school.teams.Remove(teamToRemove);

                    Console.WriteLine("\nThe team " + teamName + " was succesfully removed!\n\n----------------------\nPress any key to continue!"); Console.ReadKey(); Console.Clear();
                }
            }
        }
        
        public static void addStudentToTeam(string teamName, string studentName, string parrentEmail, int parrentPhoneNumber)
        {
            foreach (var student in school.students)
            {
                if (studentName == student.name && parrentEmail == student.parentEmail && parrentPhoneNumber == student.parentPhoneNumber)
                {
                    school.addStudentToTeam(teamName, student);
                    Console.ReadKey(); Console.Clear();

                    Console.WriteLine("Fetching everything in: " + teamName + "\n----------------------\n");

                    school.fetchAllInTeam(teamName);
                    Console.WriteLine("\n----------------------\nPress any key to continue!");
                }
            }
        }
        public static void addTeacherToTeam(string teamName, string name, string email, int phoneNumber)
        {
            foreach (var teacher in school.teachers)
            {
                if (name == teacher.name && email == teacher.email && phoneNumber == teacher.phoneNumber)
                {
                    school.addTeacherToTeam(teamName, teacher);
                    Console.ReadKey(); Console.Clear();

                    Console.WriteLine("Fetching everything in: " + teamName + "\n----------------------\n");

                    school.fetchAllInTeam(teamName);
                    Console.WriteLine("\n----------------------\nPress any key to continue!");
                    
                }
            }
        }

    }
}
