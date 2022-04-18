using System;

namespace _01.Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Random random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int currWordIndex = random.Next(0, words.Length);
                string currWord = words[i];
                words[i] = words[currWordIndex];
                words[currWordIndex] = currWord;
            }

            foreach(string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
