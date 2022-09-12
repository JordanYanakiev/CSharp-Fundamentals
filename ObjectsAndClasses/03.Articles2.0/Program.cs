using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            int counter = 0;

            while (counter < numberOfOperations)
            {
                List<string> input = Console.ReadLine().Split(", ").ToList();
                Article article = new Article(input[0], input[1], input[2]);

                Console.WriteLine(article.ToString());
                counter++;
            }
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
