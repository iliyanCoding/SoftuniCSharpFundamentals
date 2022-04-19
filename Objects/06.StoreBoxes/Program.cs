using System;
using System.Linq;
using System.Collections.Generic;

namespace _06.StoreBoxes
{
    class Item
    {
        public string Name { get; set; }

        public double Price { get; set; }
    }

    class Box
    {
        public int SerialNumber { get; set; }

        public string ItemName { get; set; }

        public int ItemQuantity { get; set; }

        public double PriceForABox { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Item> items = new List<Item>();
            List<Box> boxes = new List<Box>();

            while (command != "end")
            {
                string[] boxArgs = command.Split(' ');
                int serialNumber = int.Parse(boxArgs[0]);
                string itemName = boxArgs[1];
                int itemQuantity = int.Parse(boxArgs[2]);
                double itemPrice = double.Parse(boxArgs[3]);

                Item item = new Item()
                {
                    Name = itemName,
                    Price = itemPrice,
                };
                items.Add(item);

                Box box = new Box()
                {
                    SerialNumber = serialNumber,
                    ItemName = itemName,
                    ItemQuantity = itemQuantity,
                    PriceForABox = itemPrice * itemQuantity
                };
                boxes.Add(box);

                
                command = Console.ReadLine();
            }
            List<Box> filteredBox = boxes.OrderByDescending(b => b.PriceForABox).ToList();
            foreach (Box box in filteredBox)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.ItemName} - ${(box.PriceForABox / box.ItemQuantity):f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }


        }
    }
}
