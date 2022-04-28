using System;

namespace _02.CharactersMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            
            Console.WriteLine(CharMultiplier(input[0], input[1]));
        }

        static string CharMultiplier(string firstString, string secondString)
        {
            int sum = 0;
            string smallerString = string.Empty;
            string biggerString = string.Empty;
            if(firstString.Length <= secondString.Length)
            {
                smallerString = firstString;
                biggerString = secondString;
            }
            else
            {
                smallerString = secondString;
                biggerString = firstString;

            }
            for (int i = 0; i < smallerString.Length; i++)
            {
                sum += firstString[i] * secondString[i];
            }

            for (int i = smallerString.Length; i < biggerString.Length; i++)
            {
                sum += biggerString[i];
            }
            return sum.ToString();
        }
    }
}
