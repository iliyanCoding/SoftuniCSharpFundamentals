using System;
using System.Linq;

namespace TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();


            for (int i = 0; i <array.Length; i++)
            {
                bool isItTopInteger = true;

                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[i] <= array[j])
                    { 
                        isItTopInteger = false;
                    }
                }
                
                if(isItTopInteger)
                {
                    Console.Write(array[i] + " ");
                }
            }

        }
    }
}
