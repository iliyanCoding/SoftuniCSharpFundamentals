using System;

namespace Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            int capacityOfPeople = int.Parse(Console.ReadLine());

            int fullcourses = numOfPeople / capacityOfPeople;
            if(numOfPeople % capacityOfPeople != 0)
            {
                fullcourses++;
            }
            Console.WriteLine(fullcourses);

        }
    }
}
