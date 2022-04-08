using System;
using System.Linq;
namespace ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] target = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            string input = Console.ReadLine();
            int shotTargetsCount = 0;
            while (input != "End")
            {
                int index = int.Parse(input);
                for (int i = 0; i <= target.Length - 1; i++)
                {
                    if (target[i] != -1)
                    {
                        if (index > target.Length - 1)
                        {
                            break;
                        }
                        else
                        {
                            if (target[index] > target[i])
                            {
                                target[i] = target[i] + target[index];
                            }
                            else if (target[index] < target[i])
                            {
                                target[i] = target[i] - target[index];

                            }
                            //else if (target[index] == target[i])
                            //{
                            //    target[index] = target[i] + target[i];
                            //}
                        }

                    }

                }
                if (index <= target.Length - 1)
                {
                    target[index] = -1;
                    shotTargetsCount++;
                }
                
                
                input = Console.ReadLine();
            }
            Console.Write($"Shot targets: {shotTargetsCount} -> {string.Join(' ', target)}");
            
            
        }
    }
}
