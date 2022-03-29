using System;

namespace VendingMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double moneyNeeded = 0;
            string product = string.Empty;
            const double Nuts = 2.0;
            const double Water = 0.7;
            const double Crisps = 1.5;
            const double Soda = 0.8;
            const double Coke = 1.0;
            string input = Console.ReadLine();
            while (input != "Start")
            {

                if (input == "0.1" || input == "0.2" || input == "0.5" || input == "1" || input == "2")
                {
                    sum += double.Parse(input);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {input}");

                }
                input = Console.ReadLine();

            }

            string food = Console.ReadLine();
            while (food != "End")
            {
                if (food == "Nuts" || food == "Water" || food == "Crisps" || food == "Soda" || food == "Coke")
                {
                    switch (food)
                    {
                        case "Nuts":
                            moneyNeeded = Nuts;
                            product = "nuts";
                            break;
                        case "Water":
                            moneyNeeded = Water;
                            product = "water";
                            break;
                        case "Crips":
                            moneyNeeded = Crisps;
                            product = "crisps";
                            break;
                        case "Soda":
                            moneyNeeded = Soda;
                            product = "soda";
                            break;
                        case "Coke":
                            moneyNeeded = Coke;
                            product = "coke";
                            break;
                    }

                    if (moneyNeeded <= sum && sum > 0)
                    {
                        Console.WriteLine($"Purchased {product}");
                        sum -= moneyNeeded;
                        moneyNeeded = 0;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                        moneyNeeded = 0;
                    }

                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                food = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}
