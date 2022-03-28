using System;

namespace Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            string age = string.Empty;
            if(years >= 0 && years <= 2)
            {
                age = "baby";
            }
            else if(years >= 3 && years <= 13)
            {
                age = "child";
            }
            else if(years >= 14 && years <= 19)
            {
                age = "teenager";
            }
            else if(years >= 20 && years <= 65)
            {
                age = "adult";
            }
            else
            {
                age = "elder";
            }

            Console.WriteLine(age);

        }
    }
}
