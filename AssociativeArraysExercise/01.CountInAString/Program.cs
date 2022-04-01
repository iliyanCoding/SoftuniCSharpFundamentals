using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.CountInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] input = Console.ReadLine().ToArray();
            Dictionary<char, int> countedSymbols = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i] == ' ')
                {
                    continue;
                }

                char key = input[i];

                if(!countedSymbols.ContainsKey(key))
                {
                    countedSymbols[key] = 0;
                }
                
                countedSymbols[key]++;
            }

            foreach(var symbol in countedSymbols)
            {
                Console.WriteLine($"{symbol.Key} -> {symbol.Value}");
            }
        }
    }
}
