using System;
using System.Linq;

namespace CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] array1 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] array2 = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
              
            var intersect = array2.Intersect(array1);

            foreach (string value in intersect)
            {
                Console.Write(value + " ");
            }

        }
    }
}
