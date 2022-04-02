using System;

namespace _01.Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vehicles = Console.ReadLine().Split(">>");
            const int familyCarInitialTax = 50;
            const int heavyDutyCarInitialTax = 80;
            const int sportsCarInitialTax = 100;
            int nationalRevenueAgencyTaxes = 0;
            for (int i = 0; i < vehicles.Length; i++)
            {
                string[] currVehicle = vehicles[i].Split(' ');
                string currCarType = currVehicle[0];
                int yearsTheTaxShouldBePaid = int.Parse(currVehicle[1]);
                int kilometersTraveled = int.Parse(currVehicle[2]);


                int taxes = 0;

                switch (currCarType)
                {
                    case "family":
                        taxes = familyCarInitialTax - (yearsTheTaxShouldBePaid * 5) + (kilometersTraveled / 3000 * 12);
                        Console.WriteLine($"A {currCarType} car will pay {taxes:f2} euros in taxes.");
                        break;
                    case "heavyDuty":
                        taxes = heavyDutyCarInitialTax - (yearsTheTaxShouldBePaid * 8) + (kilometersTraveled / 9000 * 14);
                        Console.WriteLine($"A {currCarType} car will pay {taxes:f2} euros in taxes.");
                        break;
                    case "sports":
                        taxes = sportsCarInitialTax - (yearsTheTaxShouldBePaid * 9) + (kilometersTraveled / 2000 * 18);
                        Console.WriteLine($"A {currCarType} car will pay {taxes:f2} euros in taxes.");
                        break;
                    default:
                        Console.WriteLine("Invalid car type.");
                        break;
                }

                

                nationalRevenueAgencyTaxes += taxes;
            }
            Console.WriteLine($"The National Revenue Agency will collect {nationalRevenueAgencyTaxes:f2} euros in taxes.");

        }
    }
}
