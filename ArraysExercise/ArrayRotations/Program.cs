using System;
using System.Linq;

namespace ArrayRotations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rotationsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < rotationsCount; i++)
            {
                int firstEl = array[0];
                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = firstEl;
            }
            Console.WriteLine(string.Join(' ', array));
        }
    }
}
