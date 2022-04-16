using System;

namespace MultiplyEvenByOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = MultiplyEvenByOdds(number);
            Console.WriteLine(result);

        }
        static int MultiplyEvenByOdds(int number)
        {
            int evenSum = 0;
            int oddSum = 0;
            int multipliedNum = 0;
            int lengthOfNum = number.ToString().Length;
            for (int i = 0; i < lengthOfNum; i++)
            {
                int leftover = Math.Abs(number % 10);
                if(leftover % 2 == 0)
                {
                    evenSum += leftover;
                }
                else
                {
                    oddSum += leftover;
                }
                number /= 10;
            }
            return multipliedNum = evenSum * oddSum;
        }
    }
}
