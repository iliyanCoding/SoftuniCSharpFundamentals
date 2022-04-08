using System;

namespace ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double taxes = 0.2;
            double sum = 0;
            string input = Console.ReadLine();
            bool special = false;
            while (input != "regular" && input != "special")
            {

                double price = double.Parse(input);
                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");

                }

                if (price > 0)
                {
                    sum += price;
                }
                input = Console.ReadLine();
                if (input == "special")
                {
                    special = true;
                }



            }
            double sumTaxes = sum * taxes;
            double totalSum = 0;
            if (special == true)
            {
                totalSum = (sum + sumTaxes) * 0.9;
            }
            else
            {
                totalSum = sum + sumTaxes;
            }
            if (totalSum == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {sum:f2}$");
                Console.WriteLine($"Taxes: {sumTaxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalSum:f2}$");
            }


        }
    }
}
