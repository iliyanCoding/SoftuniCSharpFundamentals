using System;

namespace _01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Reveal")
            {
                string[] command = input.Split(":|:");
                if (command[0] == "InsertSpace")
                {
                    int index = int.Parse(command[1]);
                    message = message.Insert(index, " ");
                    Console.WriteLine(message);
                }
                else if (command[0] == "Reverse")
                {
                    string substring = command[1];
                    if (message.Contains(substring))
                    {
                        int firstIndexOfSubstring = message.IndexOf(substring[0]);
                        message = message.Remove(firstIndexOfSubstring, substring.Length);
                        string reversedSubstring = string.Empty;
                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            
                            reversedSubstring += substring[i];
                        }
                        message += reversedSubstring;
                        Console.WriteLine(message);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (command[0] == "ChangeAll")
                {
                    string substring = command[1];
                    string replacement = command[2];
                    message = message.Replace(substring, replacement);
                    Console.WriteLine(message);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
