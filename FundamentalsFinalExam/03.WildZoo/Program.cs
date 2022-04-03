using System;
using System.Collections.Generic;

namespace _03.WildZoo
{
    class Animal
    {
        public Animal(string name, int neededFoodQuantity, string area)
        {
            this.Name = name;
            this.NeededFoodQuantity = neededFoodQuantity;
            this.Area = area;
        }
        public string Name { get; set; }

        public int NeededFoodQuantity { get; set; }

        public string Area { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Animal> animalsList = new Dictionary<string, Animal>();
            Dictionary<string, int> areasWithHungryAnimal = new Dictionary<string, int>();
            while (input != "EndDay")
            {
                string[] command = input.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Add")
                {
                    string[] animalArgs = command[1].Split('-');
                    string animalName = animalArgs[0];
                    int neededFoodQuantity = int.Parse(animalArgs[1]);
                    string animalArea = animalArgs[2];

                    if (!animalsList.ContainsKey(animalName))
                    {
                        Animal animal = new Animal(animalName, neededFoodQuantity, animalArea);
                        animalsList.Add(animalName, animal);

                        if (!areasWithHungryAnimal.ContainsKey(animalArea))
                        {
                            areasWithHungryAnimal[animalArea] = 1;
                        }
                        else
                        {
                            areasWithHungryAnimal[animalArea]++;
                        }
                        
                        
                    }
                    else
                    {
                        animalsList[animalName].NeededFoodQuantity += neededFoodQuantity;
                    }

                    
                    
                    
                }
                else if(command[0] == "Feed")
                {
                    string[] animalArgs = command[1].Split('-');
                    string animalName = animalArgs[0];
                    int food = int.Parse(animalArgs[1]);

                    if(animalsList.ContainsKey(animalName))
                    {
                        animalsList[animalName].NeededFoodQuantity -= food;

                        if(animalsList[animalName].NeededFoodQuantity <= 0)
                        {
                            areasWithHungryAnimal[animalsList[animalName].Area] -= 1;
                            animalsList.Remove(animalName);
                            
                            Console.WriteLine($"{animalName} was successfully fed");
                        }
                    }
                    

                    
                }

                input = Console.ReadLine();

            }

            Console.WriteLine("Animals:");
            foreach (var animal in animalsList)
            {
                Console.WriteLine($" {animal.Key} -> {animal.Value.NeededFoodQuantity}g");
            }

            Console.WriteLine("Areas with hungry animals:");
            foreach (var area in areasWithHungryAnimal)
            {
                if (area.Value == 0)
                {
                    areasWithHungryAnimal.Remove(area.Key);
                }
                else
                {
                    Console.WriteLine($"{area.Key}: {area.Value}");
                }
                
            }

        }
    }
}
