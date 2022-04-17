using System;

namespace SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int result = MinNumber(a, b, c);
            Console.WriteLine(result);
            
        }
        static int MinNumber(int a, int b, int c)
        {
            int[] array = { a, b, c };
            int small = int.MaxValue;
            foreach(int x in array)
            {
                if(x < small)
                {
                    small = x;
                }
            }
            return small;
        }
    }
}
