using System;
using System.Linq;
using System.Collections.Generic;

namespace _03.LegendaryFarming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string legendaryItem = string.Empty;
            Dictionary<string, int> materials = new Dictionary<string, int>();
            materials.Add("motes", 0);
            materials.Add("fragments", 0);
            materials.Add("shards", 0);
            Dictionary<string, int> junk = new Dictionary<string, int>();

            while (materials["motes"] < 250 && materials["fragments"] < 250 && materials["shards"] < 250)
            {
                string[] input = Console.ReadLine().Split(' ');
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1].ToLower();

                    switch (material)
                    {
                        case "motes":
                            materials["motes"] += quantity;
                            break;
                        case "fragments":
                            materials["fragments"] += quantity;
                            break;
                        case "shards":
                            materials["shards"] += quantity;
                            break;
                        default:
                            if (!junk.ContainsKey(material))
                            {
                                junk.Add(material, 0);
                            }
                            junk[material] += quantity;
                            break;

                    }
                }


            }
            if (materials["shards"] >= 250)
            {
                legendaryItem = "Shadowmourne";
            }
            else if (materials["fragments"] >= 250)
            {
                legendaryItem = "Valanyr";
            }
            else if (materials["motes"] >= 250)
            {
                legendaryItem = "Dragonwrath";
            }

            Console.WriteLine($"{legendaryItem} obtained!");

            foreach (var item in materials.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key.ToLower()}: {item.Value}");
            }

            foreach (var item in junk.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{item.Key.ToLower()}: {item.Value}");
            }


        }
    }
}
