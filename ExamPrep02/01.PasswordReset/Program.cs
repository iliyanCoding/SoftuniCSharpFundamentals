using System;
using System.Linq;

namespace _01.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    string password = Console.ReadLine();
            //    string input = Console.ReadLine();
            //    while (input != "Done")
            //    {
            //        if(input.Contains("TakeOdd"))
            //        {
            //            string newPassword = string.Empty;
            //            for (int i = 0; i < password.Length; i++)
            //            {
            //                if(i % 2 == 1)
            //                {
            //                   newPassword += password[i]; 
            //                }
            //            }

            //            password = newPassword;
            //            Console.WriteLine(password);
            //        }
            //        else if(input.Contains("Cut"))
            //        {
            //            string[] command = input.Split(' ');
            //            password = password.Remove(int.Parse(command[1]), int.Parse(command[2]));
            //            Console.WriteLine(password);
            //        }
            //        else if(input.Contains("Substitute"))
            //        {
            //            string[] command = input.Split(' ');
            //            if(password.Contains(command[1]))
            //            {
            //                password = password.Replace(command[1], command[2]);
            //                Console.WriteLine(password);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Nothing to replace!");
            //            }

            //        }
            //        input = Console.ReadLine();
            //    }

            //    Console.WriteLine($"Your password is: {password}");
            int a = 5;
            int b = a++;
            int c = ++a;
            Console.WriteLine(c);
        }

        
    }
}
