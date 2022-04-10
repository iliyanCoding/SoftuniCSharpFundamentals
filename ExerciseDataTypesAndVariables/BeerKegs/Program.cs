using System;

namespace BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfKegs = int.Parse(Console.ReadLine());
            decimal biggestKeg = decimal.MinValue;
            string biggestKegModel = string.Empty;
            for (int i = 0; i < numOfKegs; i++)
            {
                string kegModel = Console.ReadLine();
                decimal kegRadius = decimal.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());
                decimal kegVolume = (decimal)Math.PI * kegRadius * kegRadius * kegHeight; 
                if(kegVolume > biggestKeg)
                {
                    biggestKeg = kegVolume;
                    biggestKegModel = kegModel;
                }
            }
            Console.WriteLine(biggestKegModel);
        }
    }
}
