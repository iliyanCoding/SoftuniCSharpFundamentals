using System;
using System.Text.RegularExpressions;

namespace _02.MirroWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pathern = new Regex(@"(@|#){1,2}\w{3,}\1(@|#){1,2}\w{3,}\1");
            string input = Console.ReadLine();
            
        }
    }
}
