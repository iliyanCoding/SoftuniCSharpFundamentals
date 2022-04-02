using System;

namespace _03.Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] travelRoute = Console.ReadLine().Split("||");
            int amountOfFuel = int.Parse(Console.ReadLine());
            int amountOfAmmo = int.Parse(Console.ReadLine());
            int amountOfAmmoOrFuel = 0;

            for (int i = 0; i < travelRoute.Length; i++)
            {
                string[] currRoute = travelRoute[i].Split(' ');
                string currCommand = currRoute[0];
                if (currCommand != "Titan")
                {
                    amountOfAmmoOrFuel = int.Parse(currRoute[1]);
                }


                switch (currCommand)
                {
                    case "Travel":
                        if (amountOfFuel >= amountOfAmmoOrFuel)
                        {
                            Console.WriteLine($"The spaceship travelled {amountOfAmmoOrFuel} light-years.");
                            amountOfFuel -= amountOfAmmoOrFuel;
                        }
                        else
                        {
                            Console.WriteLine("Mission failed.");
                            return;
                        }
                        break;
                    case "Enemy":
                        if (amountOfAmmo >= amountOfAmmoOrFuel)
                        {
                            Console.WriteLine($"An enemy with {amountOfAmmoOrFuel} armour is defeated.");
                            amountOfAmmo -= amountOfAmmoOrFuel;
                        }
                        else
                        {
                            if (amountOfAmmoOrFuel * 2 <= amountOfFuel)
                            {
                                Console.WriteLine($"An enemy with {amountOfAmmoOrFuel} armour is outmaneuvered.");
                                amountOfFuel -= amountOfAmmoOrFuel * 2;
                            }
                            else
                            {
                                Console.WriteLine("Mission failed.");
                                return;
                            }
                        }
                        break;
                    case "Repair":
                        amountOfFuel += amountOfAmmoOrFuel;
                        amountOfAmmo += amountOfAmmoOrFuel * 2;
                        Console.WriteLine($"Ammunitions added: {amountOfAmmoOrFuel * 2}.");
                        Console.WriteLine($"Fuel added: {amountOfAmmoOrFuel}.");
                        break;
                    case "Titan":
                        Console.WriteLine("You have reached Titan, all passengers are safe.");
                        break;
                }
            }

        }
    }
}
