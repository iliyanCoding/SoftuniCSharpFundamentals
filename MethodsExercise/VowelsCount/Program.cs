using System;

namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            input = input.ToLower();
            int result = VowelsCount(input);
            Console.WriteLine(result);
        }
        static int VowelsCount(string input)
        {
            char[] chars = input.ToCharArray();

            int count = 0;
            foreach (char x in chars)
            {
                switch (x)
                {
                    case 'a':
                        count++;
                        break;
                    case 'e':
                        count++;
                        break;
                    case 'o':
                        count++;
                        break;
                    case 'u':
                        count++;
                        break;
                    case 'i':
                        count++;
                        break;
                }
            }
            return count;
        }
    }
}
