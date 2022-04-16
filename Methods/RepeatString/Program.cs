using System;
using System.Text;

namespace RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string result = StringRepeat(input, n);
            Console.WriteLine(result);
        }

        private static string StringRepeat(string input, int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append(input);
            }
            return sb.ToString();
        }
    }
}
