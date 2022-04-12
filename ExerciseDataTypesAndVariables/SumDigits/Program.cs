using System;

namespace SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            do
            {
                sum += (number % 10);
                number /= 10;
            } while (number > 0);
            Console.WriteLine(sum);
        }
    }
}
