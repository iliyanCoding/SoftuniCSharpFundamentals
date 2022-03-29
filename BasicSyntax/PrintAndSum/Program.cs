using System;

namespace PrintAndSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                if (i == end)
                {
                    Console.WriteLine(i + " ");
                    sum += i; 
                }
                else
                {
                    Console.Write(i + " ");
                    sum += i;
                }


            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
