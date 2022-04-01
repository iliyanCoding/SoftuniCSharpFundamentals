using System;
using System.Linq;
using System.Collections.Generic;


namespace _02.MinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resource = Console.ReadLine();
            
            Dictionary<string, long> resourcesDictionary = new Dictionary<string, long>();
            while (resource != "stop")
            {
                long quantityOfResource = long.Parse(Console.ReadLine());

                if (resourcesDictionary.ContainsKey(resource))
                {
                    resourcesDictionary[resource] += quantityOfResource;
                }
                else
                {
                    resourcesDictionary.Add(resource, quantityOfResource);
                }

                resource = Console.ReadLine();
                //quantityOfResource = long.Parse(Console.ReadLine());
            }

            foreach (var resourse in resourcesDictionary)
            {
                Console.WriteLine($"{resourse.Key} -> {resourse.Value}");
            }
                
            
        }
    }
}
