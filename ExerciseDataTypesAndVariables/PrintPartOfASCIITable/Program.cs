using System;

namespace PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startIndex = int.Parse(Console.ReadLine());
            int endIndex = int.Parse(Console.ReadLine());
            for (int i = startIndex; i <= endIndex; i++)
            {
                char currChar = (char)i;
                Console.Write(currChar + " ");
            }
        }
    }
}
