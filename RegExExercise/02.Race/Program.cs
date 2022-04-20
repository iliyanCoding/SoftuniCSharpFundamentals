using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine().Split(", ");
            List<string> paticipantsWhoHaveChanceToWin = new List<string>();
            string input = Console.ReadLine();
            while (input != "end of the race")
            {
                string participant = input;
                string nameRegex = @"[A-z]";

                MatchCollection nameMatch = Regex.Matches(participant, nameRegex);
                string name = string.Empty;
                foreach (Match match in nameMatch)
                {
                    name += match.Value;
                }

                if (participant.Contains(name))
                {
                    paticipantsWhoHaveChanceToWin.Add(name);
                }

                string kilometersRegex = @"[0-9]";
                MatchCollection kilometersMatch = Regex.Matches(participant, kilometersRegex);
                string stringKilometers = string.Empty;
                foreach (Match distance in kilometersMatch)
                {
                    stringKilometers += distance;
                }
                int kilometers = int.Parse(stringKilometers);
            }
        }
    }
}
