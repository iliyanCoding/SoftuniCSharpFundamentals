using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex pathern = new Regex(@"@#+[A-Z][A-Za-z\d]{4,}[A-Z]@#+");
            int numOfBarcodes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfBarcodes; i++)
            {
                string barcode = Console.ReadLine();

                if(pathern.IsMatch(barcode))
                {
                    char[] digits = barcode.Where(x => char.IsDigit(x)).ToArray();

                    if(digits.Length == 0)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {string.Join("", digits)}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
            
        }
    }
}
