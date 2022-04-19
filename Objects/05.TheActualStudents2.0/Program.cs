//using System;
//using System.Collections.Generic;
//using System.Linq;

//namespace _05.TheActualStudents2._0
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string command = Console.ReadLine();
//            List<Student> students = new List<Student>();
//            while (command != "end")
//            {
//                string[] studentArgs = command.Split(' ');
//                string studentFirstName = studentArgs[0];
//                string studentLastName = studentArgs[1];
//                string studentAge = studentArgs[2];
//                string studentHomeTown = studentArgs[3];

//                bool doesStudentExsist = DoesStudentExsist(students, studentFirstName, studentLastName);

//                if(doesStudentExsist)
//                {
//                    Student existingStudent = GetExistingStudent(students, studentFirstName, studentLastName);
//                }
//                else
//                {
//                    Student student = new Student(studentFirstName, studentLastName, studentAge, studentHomeTown);
//                }

//                //Student student = new Student(studentFirstName, studentLastName, studentAge, studentHomeTown);


//                students.Add(student);


//                command = Console.ReadLine();
//            }

//            string hometown = Console.ReadLine();

//            List<Student> neededStudents = students.FindAll(students => students.HomeTown == hometown);

//            foreach (Student student in neededStudents)
//            {
//                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
//            }
//        }

//        private static Student GetExistingStudent(List<Student> students, string studentFirstName, string studentLastName)
//        {
//            throw new NotImplementedException();
//        }

//        static bool DoesStudentExsist(List<Student> students, string firstName, string lastName)
//        {
//            foreach (Student student in students)
//            {
//                if(student.FirstName == firstName && student.LastName == lastName)
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }
//        }
//    }

//    class Student
//    {
//        public Student(string firstName, string lastName, string age, string homeTown)
//        {
//            this.FirstName = firstName;
//            this.LastName = lastName;
//            this.Age = age;
//            this.HomeTown = homeTown;
//        }
//        public string FirstName { get; set; }

//        public string LastName { get; set; }

//        public string Age { get; set; }

//        public string HomeTown { get; set; }

//    }
//}
