using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Orders
{
    class Product
    {
        public double Price { get; set; }

        public int Quantity { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Product> productsDictionary = new Dictionary<string, Product>();
            while (input != "buy")
            {
                string[] productArgs = input.Split(' ');
                string productName = productArgs[0];
                Product product = new Product()
                {
                    Price = double.Parse(productArgs[1]),
                    Quantity = int.Parse(productArgs[2])
                    
                };
                if (!productsDictionary.ContainsKey(productName))
                {
                    productsDictionary.Add(productName, product);
                }
                else
                {
                    productsDictionary[productName].Quantity += product.Quantity;
                    if (productsDictionary[productName].Price != product.Price)
                    {
                        productsDictionary[productName].Price = product.Price;
                    }
                }

                input = Console.ReadLine();

            }

            foreach (var item in productsDictionary)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Price * item.Value.Quantity:f2}");
            }
        }
    }
}
