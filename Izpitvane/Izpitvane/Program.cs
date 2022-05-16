using System;

namespace Izpitvane
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            double n = int.Parse(Console.ReadLine());
            double maxN = double.MinValue;
            double minN = double.MaxValue;
            double sum = 0;
            double avg = 0;
               
            while(n >= 0 && n <= 50)
            {
                for (int i = 0; i < n; i++)
                {
                    double num = double.Parse(Console.ReadLine());
                    if (num > maxN)
                    {
                        maxN = num;
                    }

                    if (num < minN)
                    {
                        minN = num;
                    }

                    sum += num;

                }

                avg = sum / n;

                Console.WriteLine($"Max: {maxN:f2}");
                Console.WriteLine($"Min: {minN:f2}");
                Console.WriteLine($"Avg: {avg:f2}");
            }
        }
    }
}
