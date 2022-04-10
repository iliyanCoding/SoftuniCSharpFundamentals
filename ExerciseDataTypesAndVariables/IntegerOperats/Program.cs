using System;
using System.Numerics;

namespace IntegerOperats
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long firstN = long.Parse(Console.ReadLine());
            long secondN = long.Parse(Console.ReadLine());
            long thirdN = long.Parse(Console.ReadLine());
            long fourthN = long.Parse(Console.ReadLine());
            long sum = firstN + secondN;
            long devide = sum / thirdN;
            long multiply = devide * fourthN;
            Console.WriteLine(multiply);
        }
    }
}
