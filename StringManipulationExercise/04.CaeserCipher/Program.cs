using System;

namespace _04.CaeserCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string cipher = string.Empty;
            foreach (var symbol in text)
            {
                char decryptedSymbol = (char)(symbol + 3);
                cipher += decryptedSymbol;
            }
            Console.WriteLine(cipher);
        }
    }
}
