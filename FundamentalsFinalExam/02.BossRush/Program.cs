using System;
using System.Text.RegularExpressions;

namespace _02.BossRush
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfIndicates = int.Parse(Console.ReadLine());
            Regex pathern = new Regex(@"\|(?<name>[A-Z{4,}]+)\|:#(?<title>[A-Za-z]+ [A-Za-z]+)#");
            for (int i = 0; i < numOfIndicates; i++)
            {
                string indicate = Console.ReadLine();
                Match match = pathern.Match(indicate);
                if (match.Success)
                {
                    string name = match.Groups["name"].Value;
                    string title = match.Groups["title"].Value;
                    int strenght = match.Groups["name"].Value.Length;
                    int armor = match.Groups["title"].Value.Length;

                    Console.WriteLine($"{name}, The {title}");
                    Console.WriteLine($">> Strength: {strenght}");
                    Console.WriteLine($">> Armor: {armor}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
