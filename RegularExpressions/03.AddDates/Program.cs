using System;
using System.Text.RegularExpressions;

namespace _03.AddDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pethern = @"(?<day>\d{2})(?<symbol>\.|-|\/)(?<montj>[A-Z][a-z]{2})\1(?<year>\d{4})";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pethern);

            foreach (Match match in matches)
            {
                string day = match.Groups["day"].Value;
                string month = match.Groups["month"].Value;
                string year = match.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
