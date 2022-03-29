using System;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int counter = 0;
            string password = string.Empty;
            string passwordInput = string.Empty;
            for (int reverseIndex = username.Length - 1; reverseIndex >= 0; reverseIndex--)
            {
                password += (username[reverseIndex]);
            }
            for (int count = 1; count <= 4; count++)
            {
                passwordInput = Console.ReadLine();

                if (passwordInput == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else
                {
                    if (count == 4)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Incorrect password. Try again.");
                        continue; 
                    }
                }
            }
        }
    }
}
