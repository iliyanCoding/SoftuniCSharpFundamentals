using System;
using System.Linq;

namespace EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool isTrue = false;

            if(input.Length == 1)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                leftSum = input.Take(i).Sum();
                rightSum = input.Skip(i + 1).Sum();

                if(leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    isTrue = true;
                    break;
                }
            }
            if(!isTrue)
            {
                Console.WriteLine("no");
            }
        }
    }
}
