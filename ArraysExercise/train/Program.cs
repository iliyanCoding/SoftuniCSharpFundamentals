using System;

namespace train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagons = int.Parse(Console.ReadLine());
            int[] numOfPassengers = new int[wagons];
            int totalPassengers = 0;
            for (int i = 0; i < numOfPassengers.Length; i++)
            {
                numOfPassengers[i] = int.Parse(Console.ReadLine());
                totalPassengers += numOfPassengers[i];
            }
            Console.WriteLine(String.Join(' ', numOfPassengers));
            Console.WriteLine(totalPassengers);
        }
    }
}
