using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Student> students = new List<Student>();
            while (command != "end")
            {
                string[] studentArgs = command.Split(' ');
                string studentFirstName = studentArgs[0];
                string studentLastName = studentArgs[1];
                string studentAge = studentArgs[2];
                string studentHomeTown = studentArgs[3];

                Student student = new Student()
                {
                    FirstName = studentFirstName,
                    LastName = studentLastName,
                    Age = studentAge,
                    HomeTown = studentHomeTown
                };
                students.Add(student);


                command = Console.ReadLine();
            }

            string hometown = Console.ReadLine();

            List<Student> neededStudents = students.FindAll(students => students.HomeTown == hometown);

            foreach (Student student in neededStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
            }

        }
    }

    class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Age { get; set; }

        public string HomeTown { get; set; }

    }
}
