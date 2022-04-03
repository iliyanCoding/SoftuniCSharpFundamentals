using System;
using System.Collections.Generic;

namespace Boto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacityOfPossibleMessages = int.Parse(Console.ReadLine());
            Dictionary<string, int> users = new Dictionary<string, int>();
            string input = Console.ReadLine();
            while (input != "Statistics")
            {
                string[] command = input.Split('=');
                if (command[0] == "Add")
                {
                    string user = command[1];
                    if (!users.ContainsKey(user))
                    {
                        users.Add(user, int.Parse(command[2]) + int.Parse(command[3]));

                    }
                }
                else if (command[0] == "Message")
                {
                    string sender = command[1];
                    string reciever = command[2];
                    if (users.ContainsKey(sender) && users.ContainsKey(reciever))
                    {
                        users[sender] += 1;
                        users[reciever] += 1;
                    }

                    if(users[sender] >= 10)
                    {
                        users.Remove(sender);
                        Console.WriteLine($"{sender} reached the capacity!");
                    }

                    if (users[reciever] >= 10)
                    {
                        users.Remove(reciever);
                        Console.WriteLine($"{reciever} reached the capacity!");
                    }
                }
                else if (command[0] == "Empty")
                {
                    if(users.ContainsKey(command[1]))
                    {
                        users.Remove(command[1]);
                    }

                    if(command[1] == "All")
                    {
                        users.Clear();
                    }
                    
                }

                input = Console.ReadLine();


            }

            Console.WriteLine($"Users count: {users.Count}");

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} - {user.Value}");
            }
        }
    }
}
