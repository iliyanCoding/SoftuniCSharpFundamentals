using System;

namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");
            bool neededLenght = false;
            bool charactersNeeded = true;
            foreach (var username in usernames)
            {
                if(username.Length >= 3 && username.Length <= 16)
                {
                    neededLenght = true;
                }

                foreach (var symbol in username)
                {
                    //if (!char.IsDigit(symbol) && !char.IsLetter(symbol) && symbol != '-' && symbol != '_')
                    //{
                    //    charactersNeeded = false;
                    //}
                    if (char.IsLetterOrDigit(symbol) || symbol == '-' || symbol == '_')
                    {
                        continue;
                    }
                    else
                    {
                        charactersNeeded = false;
                    }
                }

                if (neededLenght == true && charactersNeeded == true)
                {
                    Console.WriteLine(username);
                }
            }
        }
    }
}
