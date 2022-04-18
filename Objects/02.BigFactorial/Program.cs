using System;
using System.Numerics;

namespace _02.BigFactorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger facotorial = 1;

            for (int i = 1; i <= n; i++)
            {
                facotorial *= i;
            }

            Console.WriteLine(facotorial);
        }
    }
}
