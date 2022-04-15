using System;

namespace MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            char opperator = char.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            double result = Calculate(firstNum, opperator, secondNum);
            Console.WriteLine(result);
        }
        static double Calculate(int firstNum, char opperator, int secondNum)
        {
            double result = 0;

            switch (opperator)
            {
                case '+':
                    result = firstNum + secondNum;
                    break;
                case '-':
                    result = firstNum - secondNum;
                    break;
                case '/':
                    result = firstNum / secondNum;
                    break;
                case '*':
                    result = firstNum * secondNum;
                    break;
            }
            return result;
        }
    }
}
