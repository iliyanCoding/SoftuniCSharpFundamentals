using System;
using System.Linq;
using System.Collections.Generic;

namespace MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> allElements = Console.ReadLine().Split(' ').ToList();
            int movesCounter = 0;
            bool outOfRange = false;
            bool gameIsWon = false;

            string input = Console.ReadLine();
            while(input != "end")
            {
                int[] currElements = input.Split(' ').Select(int.Parse).ToArray();
                //if(currElements[1] > currElements[0])
                //{
                //    currElements.Reverse();
                //}
                movesCounter++;
                if(currElements[0] == currElements[1] || currElements[0] > allElements.Count || currElements[1] > allElements.Count || currElements[0] < 0 || currElements[1] < 0)
                {
                    string cheatElements = - + movesCounter + "a";
                    allElements.Insert(allElements.Count / 2, cheatElements);
                    allElements.Insert(allElements.Count / 2, cheatElements);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    outOfRange = true;
                    
                }
                if(outOfRange == false)
                {
                    if (allElements[currElements[0]] == allElements[currElements[1]])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {allElements[currElements[0]]}!");
                        allElements.RemoveAt(currElements[1]);
                        allElements.RemoveAt(currElements[0]);
                        

                    }
                    else
                    {
                        Console.WriteLine("Try again!");

                    }
                }
                

                if(allElements.Count == 0)
                {
                    Console.WriteLine($"You have won in {movesCounter} turns!");
                    gameIsWon = true;
                    break;

                    
                }  
                input = Console.ReadLine();
                outOfRange = false;
            }
            if(gameIsWon == false)
            {
                Console.WriteLine("Sorry you lose :(");
                Console.WriteLine(string.Join(' ', allElements));
            }
            
            
        }
    }
}
