using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<string> inputList = new List<string>();
            //double priceForAll = 0.0;
            //string pathern = @">>(?<furniture>\w+)<<(?<price>\d+.\d+|\d+)!(?<quantity>\d+)";
            //string input = Console.ReadLine();

            //while (input != "Purchase")
            //{
            //    Match match = Regex.Match(input, pathern);
            //    if (match.Success)
            //    {
            //        string furniture = match.Groups["furniture"].Value;
            //        double price = double.Parse(match.Groups["price"].Value);
            //        int quantity = int.Parse(match.Groups["quantity"].Value);

            //        priceForAll += price * quantity;
            //        inputList.Add(furniture);
            //    }

            //    input = Console.ReadLine();
            //}
            //Console.WriteLine("Bought furniture:");
            //if
            //foreach (var item in inputList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine($"Total money spend: {priceForAll:f2}");

            string regex = @">>(?<name>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quant>\d+)";

            string input = Console.ReadLine();
            var items = new List<string>();
            double totalPrice = 0.0;

            while (input != "Purchase")
            {
                Match m = Regex.Match(input, regex, RegexOptions.IgnoreCase);
                if (m.Success)
                {
                    var name = m.Groups["name"].Value;
                    var price = double.Parse(m.Groups["price"].Value);
                    var quant = int.Parse(m.Groups["quant"].Value);
                    items.Add(name);
                    totalPrice += price * quant;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Bought furniture:");
            if (items.Count > 0)
            {
                Console.WriteLine($"{string.Join(Environment.NewLine, items)}");
            }
            Console.WriteLine($"Total money spend: {totalPrice:F2}");


        }
    }
}
