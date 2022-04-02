using System;
using System.Linq;
using System.Collections.Generic;

namespace _04.Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cardsList = Console.ReadLine().Split(", ").ToList();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                List<string> currSelection = Console.ReadLine().Split(", ").ToList();
                string currCommand = currSelection[0];
                switch(currCommand)
                {
                    case "Add":
                        string cardName = currSelection[1];
                        if(cardsList.Contains(cardName))
                        {
                            Console.WriteLine("Card is already in the deck");
                        }
                        else
                        {
                            cardsList.Add(cardName);
                            Console.WriteLine("Card successfully added");
                        }
                        break;
                    case "Remove":
                        string cardName1 = currSelection[1];
                        if (cardsList.Contains(cardName1))
                        {
                            Console.WriteLine("Card successfully removed");
                            cardsList.Remove(cardName1);
                        }
                        else
                        {
                            Console.WriteLine("Card not found");
                        }
                        break;
                    case "Remove At":
                        int index = int.Parse(currSelection[1]);
                        if(index > cardsList.Count || index < 0)
                        {
                            Console.WriteLine("Index out of range");
                        }
                        else
                        {
                            cardsList.RemoveAt(index);
                            Console.WriteLine("Card successfully removed");
                        }
                        break;
                    case "Insert":
                        int index1 = int.Parse(currSelection[1]);
                        string cardName2 = currSelection[2];
                        if (index1 > cardsList.Count || index1 < 0)
                        {
                            Console.WriteLine("Index out of range");
                        }
                        else if (cardsList.Contains(cardName2))
                        {
                            Console.WriteLine("Card is already added");
                        }
                        else
                        {
                            Console.WriteLine("Card successfully added");
                            cardsList.Insert(index1, cardName2);
                        }
                        break;
                }
                
            }
            Console.WriteLine(string.Join(", ", cardsList));
        }
    }
}
