using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> phoneStorage = Console.ReadLine().Split(", ").ToList();

            int index = 0;
            string[] currCommandAndPhone = Console.ReadLine().Split(" - ").ToArray();
            string command = currCommandAndPhone[0];

            while (command != "End")
            {
                

                if (command == "Add")
                {
                    string phone = currCommandAndPhone[1];
                    
                        if (!phoneStorage.Contains(phone))
                        {
                            phoneStorage.Add(phone);
                        }
                    

                }

                else if (command == "Remove")
                {
                    string phone = currCommandAndPhone[1];
                    
                        if (phoneStorage.Contains(phone))
                        {
                            phoneStorage.Remove(phone);
                        }
                    

                }
                else if (command == "Bonus phone")
                {
                    string[] doublePhones = currCommandAndPhone[1].Split(':').ToArray();
                    index = phoneStorage.FindIndex(s => s == doublePhones[0]);
                    if (phoneStorage.Contains(doublePhones[0]))
                    {
                        phoneStorage.Insert(index + 1, doublePhones[1]);
                    }

                }
                else if (command == "Last")
                {
                    string lastPhone = currCommandAndPhone[1];
                    if (phoneStorage.Contains(lastPhone))
                    {
                        phoneStorage.Remove(lastPhone);
                        phoneStorage.Add(lastPhone);
                    }
                }
                currCommandAndPhone = Console.ReadLine().Split(" - ").ToArray();
                command = currCommandAndPhone[0];
            }
            Console.WriteLine(string.Join(", ", phoneStorage));
        }
    }
}
