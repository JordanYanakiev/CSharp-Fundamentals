using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(", ").ToList();
            int numberOfOperations = int.Parse(Console.ReadLine());
            List<string> commands = new List<string>();


            int counter = 0;

            Article article = new Article(input[0], input[1], input[2]);

            while (counter < numberOfOperations)
            {
                commands = Console.ReadLine().Split(": ").ToList();

                string firstCommand = commands[0];
                string secondCommand = commands[1];

                switch (firstCommand)
                {
                    case "Edit":
                        article.Edit(secondCommand);
                        break;

                    case "ChangeAuthor":
                        article.ChangeAuthor(secondCommand);
                        break;

                    case "Rename":
                        article.Rename(secondCommand);
                        break;
                }

                counter++;
            }

           Console.WriteLine( article.ToString());

        }
    }


    class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author) 
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return Title + " - " + Content + ": " + Author;
        }

    }
}
