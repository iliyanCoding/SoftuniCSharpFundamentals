using System;
using System.Text;

namespace _05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder letters = new StringBuilder();
            StringBuilder numbers = new StringBuilder();
            StringBuilder otherCharacters = new StringBuilder();

            string text = Console.ReadLine();

            foreach (char item in text)
            {
                if(char.IsLetter(item))
                {
                    letters.Append(item);
                }
                else if(char.IsDigit(item))
                {0
                    numbers.Append(item);
                }
                else
                {
                    otherCharacters.Append(item);
                }
            }

            Console.WriteLine(numbers.ToString());
            Console.WriteLine(letters.ToString());
            Console.WriteLine(otherCharacters.ToString());
            
            
        }
    }
}
