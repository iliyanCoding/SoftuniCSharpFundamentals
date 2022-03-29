using System;

namespace Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();
            double priceForOne = 0;
            double totalPrice = 0;
            switch(group)
            {
                case "Students":
                    switch(day)
                    {
                        case "Friday":
                            priceForOne = 8.45;
                            break;
                        case "Saturday":
                            priceForOne = 9.80;
                            break;
                        case "Sunday":
                            priceForOne = 10.46;
                            break;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday":
                            priceForOne = 10.90;
                            break;
                        case "Saturday":
                            priceForOne = 15.60;
                            break;
                        case "Sunday":
                            priceForOne = 16;
                            break;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday":
                            priceForOne = 15;
                            break;
                        case "Saturday":
                            priceForOne = 20;
                            break;
                        case "Sunday":
                            priceForOne = 22.50;
                            break;
                    }
                    break;
                    
                    

            }
            totalPrice = priceForOne * numOfPeople;
            if (group == "Students" && numOfPeople >= 30)
            {
                totalPrice -= totalPrice * 0.15;
            }

            if (group == "Business" && numOfPeople >= 100)
            {
                totalPrice -= 10 * priceForOne;
            }

            if (group == "Regular" && numOfPeople >= 10 && numOfPeople <= 20)
            {
                totalPrice -= totalPrice * 0.05;
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");

        }
    }
}
