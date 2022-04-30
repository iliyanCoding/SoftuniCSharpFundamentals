using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sequences = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            double sum = 0;
            foreach (var sequence in sequences)
            {
                string letters = string.Empty;
                string stringNumber = string.Empty;

                foreach (var symbol in sequence)
                {
                    if(char.IsLetter(symbol))
                    {
                        
                        letters += symbol.ToString();
                    }
                    else
                    {
                       
                        stringNumber += symbol.ToString();
                    }
                }

                double number = double.Parse(stringNumber);
                if(char.IsUpper(letters[0]))
                {
                    number /= (double)letters[0] - 64;
                }
                else
                {
                    number *= (double)letters[0] - 96;
                }

                if (char.IsUpper(letters[1]))
                {
                    number -= (double)letters[1] - 64;
                }
                else
                {
                    number += (double)letters[1] - 96;
                }

                sum += number;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
