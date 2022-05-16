using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.WordFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ').Where(x => x.Length % 2 == 0).ToArray();
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
