using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> friends = Console.ReadLine().Split(", ").ToList();
            string[] input = Console.ReadLine().Split(' ').ToArray();
            string command = input[0];
            int blacklistedNames = 0;
            int lostNames = 0;
            while (command != "Report")
            {
                switch (command)
                {
                    case "Blacklist":
                        string name = input[1];
                        int index = friends.FindIndex(s => s == name);
                        if (friends.Contains(name))
                        {
                            Console.WriteLine($"{name} was blacklisted.");
                            friends[index] = "Blacklisted";
                            blacklistedNames++;
                        }
                        else
                        {
                            Console.WriteLine($"{name} was not found.");
                        }
                        break;
                    case "Error":
                        int index1 = int.Parse(input[1]);
                        string name1 = friends[index1];
                        if (name1 != "Blacklisted" && name1 != "Lost")
                        {
                            Console.WriteLine($"{name1} was lost due to an error.");
                            friends[index1] = "Lost";
                            lostNames++;
                        }
                        break;
                    case "Change":
                        int index3 = int.Parse(input[1]);
                        string name3 = input[2];
                        if (index3 <= friends.Count && index3 >= 0)
                        {
                            Console.WriteLine($"{friends[index3]} changed his username to {name3}");
                            friends[index3] = name3;

                        }
                        break;
                }
                input = Console.ReadLine().Split(' ').ToArray();
                command = input[0];
                
            }
            Console.WriteLine($"Blacklisted names: {blacklistedNames}");
            Console.WriteLine($"Lost names: {lostNames}");
            Console.WriteLine(String.Join(' ', friends));
        }
    }
}
