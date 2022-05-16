using System;

namespace _2zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ageOfLily = int.Parse(Console.ReadLine());
            double priceOfTheLaundry = double.Parse(Console.ReadLine());
            int priceOfSingleToy = int.Parse(Console.ReadLine());

            int toys = 0;
            int money = 0;
            int totalMoney = 0;
            for (int i = 1; i <= ageOfLily; i++)
            {
                money += 5;
                if (i % 2 == 0)
                {
                    totalMoney += money - 1;
                }
                else
                {
                    toys++;
                }
            }

            totalMoney += toys * priceOfSingleToy;
            if (totalMoney >= priceOfTheLaundry)
            {
                Console.WriteLine($"Yes! {totalMoney - priceOfTheLaundry:f2}");

            }
            else
            {
                Console.WriteLine($"No! {priceOfTheLaundry - totalMoney:f2}");
            }
        }
    }
}
