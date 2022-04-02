using System;

namespace _02.Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededXP = double.Parse(Console.ReadLine());
            int countOfBatles = int.Parse(Console.ReadLine());
            double gatheredXP = 0;
            for (int i = 1; i <= countOfBatles; i++)
            {
                double earnedXPInBatle = double.Parse(Console.ReadLine());
                if(i % 3 == 0)
                {
                    gatheredXP += earnedXPInBatle + earnedXPInBatle * 0.15;
                }
                else if(i % 5 == 0)
                {
                    gatheredXP += earnedXPInBatle - earnedXPInBatle * 0.10;
                }
                else if(i % 15 == 0)
                {
                    gatheredXP += earnedXPInBatle + earnedXPInBatle * 0.05;
                }
                else
                {
                    gatheredXP += earnedXPInBatle;
                }

                if(gatheredXP >= neededXP)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {i} battles.");
                    break;
                }

            }
            if(gatheredXP < neededXP)
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {(neededXP - gatheredXP):f2} more needed.");
            }
        }
    }
}
