using System;

namespace _01.DecryptingCommands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Finish")
            {
                string[] decryptingCommand = command.Split(' ');
                if(decryptingCommand[0] == "Replace")
                {
                    if (input.Contains(decryptingCommand[1]))
                    {
                        input = input.Replace(decryptingCommand[1], decryptingCommand[2]);
                        Console.WriteLine(input);
                    }

                    
                }
                else if (decryptingCommand[0] == "Cut")
                {
                    int startIndex = int.Parse(decryptingCommand[1]);
                    int endIndex = int.Parse(decryptingCommand[2]);
                    if(startIndex >= 0 && startIndex > input.Length && endIndex >= 0 && endIndex < input.Length)
                    {
                        input = input.Remove(startIndex, endIndex - startIndex + 1);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                    
                }
                else if (decryptingCommand[0] == "Make")
                {
                    if(decryptingCommand[1] == "Upper")
                    {
                        input = input.ToUpper();
                        Console.WriteLine(input);
                    }
                    else
                    {
                        input = input.ToLower();
                        Console.WriteLine(input);
                    }
                }
                else if (decryptingCommand[0] == "Check")
                {
                    if(input.Contains(decryptingCommand[1]))
                    {
                        Console.WriteLine($"Mesage contains {decryptingCommand[1]}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {decryptingCommand[1]}");
                    }
                }
                else if (decryptingCommand[0] == "Sum")
                {
                    int startIndex = int.Parse(decryptingCommand[1]);
                    int endIndex = int.Parse(decryptingCommand[2]);
                    if(startIndex < 0 || endIndex > input.Length - 1)
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                    else
                    {
                        int asciiSum = 0;
                        string substring = input.Substring(startIndex, endIndex - startIndex + 1);
                        foreach (var symbol in substring)
                        {
                            asciiSum += (int)symbol;
                        }
                        Console.WriteLine(asciiSum);
                    }
                }
                command = Console.ReadLine();
            }
        }
    }
}
