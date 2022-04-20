using System;
using System.Linq;
using System.Collections.Generic;

namespace TeamworkProjects
{
    class Person
    {
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }
        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Person> peopleList = new List<Person>();
            while(input != "End")
            {
                string[] personArgs = input.Split(' ');
                string name = personArgs[0];
                string id = personArgs[1];
                int age = int.Parse(personArgs[2]);

                Person person = new Person(name, id, age);
                peopleList.Add(person);
                foreach (Person iD in peopleList)
                {
                    if(iD.ID == id)
                    {
                        iD.Name = name;
                        iD.Age = age;
                    }
                    
                    
                }
                input = Console.ReadLine();
            }
            foreach(Person person in peopleList)
            {
                Console.WriteLine(person);
            }

        }

    }  
}
