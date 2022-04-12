using System;

namespace SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalExtractedSpices = 0;
            const int consumedSpices = 26;
            int daysMined = 0;
            int startingYield = int.Parse(Console.ReadLine());
            for (int i = startingYield; i >= 100 ; i -= 10)
            {
                int extractedSpices = i;
                totalExtractedSpices += extractedSpices;
                if(totalExtractedSpices >= consumedSpices)
                {
                    totalExtractedSpices -= consumedSpices;
                }
                
                daysMined++;
                
            }

            if (totalExtractedSpices >= consumedSpices)
            {
                totalExtractedSpices -= consumedSpices;
            }
            Console.WriteLine(daysMined);
            Console.WriteLine(totalExtractedSpices);
            

        }
    }
}
