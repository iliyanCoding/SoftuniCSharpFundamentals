using System;

namespace MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double theBase = double.Parse(Console.ReadLine());
            int thePower = int.Parse(Console.ReadLine());
            double result = RaiseToPower(theBase, thePower);
            Console.WriteLine(result);
        }
        static double RaiseToPower(double baza, int power)
        {
            double result = 0d;
            result = Math.Pow(baza, power);
            return result;
        }

    }
}
