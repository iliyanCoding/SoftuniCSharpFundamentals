using System;

namespace CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = AreaOfRectangle(width, height);
            Console.WriteLine(area);
        }

       static double AreaOfRectangle(double width, double height)
        {
            return width * height;
        }
    }
}
