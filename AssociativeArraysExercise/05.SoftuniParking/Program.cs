using System;
using System.Linq;
using System.Collections.Generic;

namespace _05.SoftuniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingInfo = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string command = input[0];
                if(command == "register")
                {
                    string username = input[1];
                    string licensePlateNumber = input[2];
                    if(parkingInfo.ContainsKey(username))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                    else
                    {
                        parkingInfo.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                }
                else
                {
                    string username = input[1];
                    if (parkingInfo.ContainsKey(username))
                    {
                        parkingInfo.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach (var item in parkingInfo)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
