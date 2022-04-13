using System;

namespace WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int buckets = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < buckets; i++)
            {
                int poured = int.Parse(Console.ReadLine());
                sum += poured;
                if(sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= poured;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
