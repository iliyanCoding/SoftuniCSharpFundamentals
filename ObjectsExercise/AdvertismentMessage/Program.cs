using System;
using System.Collections.Generic;

namespace AdvertismentMessage
{
    class AdvertismentMessage
    {
        public string Phrases { get; set; }

        public string Events { get; set; }

        public string Author { get; set; }

        public string City { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> phrasesList = new List<string>()
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            List<string> eventsList = new List<string>()
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            List<string> authorsList = new List<string>()
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            List<string> citiesList = new List<string>()
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                
                int phraseIndex = r.Next(0, phrasesList.Count);
                int eventIndex = r.Next(0, eventsList.Count);
                int authorIndex = r.Next(0, authorsList.Count);
                int cityIndex = r.Next(0, citiesList.Count);

                AdvertismentMessage advertismentMessage = new AdvertismentMessage();
                advertismentMessage.Phrases = phrasesList[phraseIndex];
                advertismentMessage.Events = eventsList[eventIndex];
                advertismentMessage.Author = authorsList[authorIndex];
                advertismentMessage.City = citiesList[cityIndex];
                Console.WriteLine($"{advertismentMessage.Phrases} {advertismentMessage.Events} {advertismentMessage.Author} - {advertismentMessage.City}");
            }
        }
    }
}
