using System;
using System.Linq;

namespace ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] currArray = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if(i % 2 == 0)
                {
                    firstArray[i] = currArray[0];
                    secondArray[i] = currArray[1];
                }
                else
                {
                    secondArray[i] = currArray[0];
                    firstArray[i] = currArray[1];
                }

            }
            Console.WriteLine(String.Join(' ', firstArray));
            Console.WriteLine(String.Join(' ', secondArray));
        }
    }
}
