using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.WordSynomyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var words = new Dictionary<string, List<string>>();
            for (int i = 0; i < n; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                if(words.ContainsKey(key) == false)
                {
                    words.Add(key, new List<string>());
                    
                }
                words[key].Add(value);
            }
            foreach (var word in words)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }


        }
    }
}
