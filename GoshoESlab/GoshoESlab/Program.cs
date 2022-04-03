using System;
using System.Text.RegularExpressions;

namespace GoshoESlab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int passwordsCount = int.Parse(Console.ReadLine());
            string pattern = @"(\S+)>(?<nums>[0-9]{3})|(?<lowercaseLetters>[a-z]{3})|(?<uppercaseLetters>[A-Z]{3})|(?<symbols>[^<>]{3})<\1";

            for (int i = 0; i < passwordsCount; i++)
            {
                string newLine = Console.ReadLine();

                Match currMatch = Regex.Match(newLine, pattern);

                if (currMatch.Success)
                {
                    string nums = currMatch.Groups["nums"].Value;
                    string lowercaseLetters = currMatch.Groups["lowercaseLetters"].Value;
                    string uppercaseLetters = currMatch.Groups["uppercaseLetters"].Value;
                    string symbols = currMatch.Groups["symbols"].Value;

                    string password = nums + lowercaseLetters + uppercaseLetters + symbols;
                    Console.WriteLine($"Password: {password}");
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
    }
}
