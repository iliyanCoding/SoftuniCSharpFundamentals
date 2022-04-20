using System;
using System.Linq;

namespace Articles
{
    class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string EditArticle(string content)
        {
            this.Content = content;
            return this.Content;
        }

        public string ChangeAuthor(string content)
        {
            this.Author = content;
            return this.Author;
        }

        public string Rename(string content)
        {
            this.Title = content;
            return this.Title;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            string[] articleContent = Console.ReadLine().Split(", ").ToArray();
            Article article = new Article(articleContent[0], articleContent[1], articleContent[2]);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(": ");
                string command = input[0];
                string textToEdit = input[1];
                if (command == "Edit")
                {
                    article.EditArticle(textToEdit);
                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(textToEdit);
                }
                else if (command == "Rename")
                {
                    article.Rename(textToEdit);
                }

            }
            Console.WriteLine(article);
        }
        
    }
}
