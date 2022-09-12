using System;
using System.Collections.Generic;

namespace _01.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            Random random = new Random();
            Advertisement add;

            for (int i = 1; i <= input; i++)
            {
                add = new Advertisement();
                add.RandomTestimony();
            }


        }

    }
    class Advertisement 
    {
        Random rand = new Random();

        public List<string> phrases = new List<string> { "Excellent product. ", "Such a great product. ", "I always use that product. ", "Best product of its category. ", "Exceptional product. ", "I can't live without this product. " };
        public List<string> events = new List<string> { "Now I feel good. ", "I have succeeded with this product. ", "Makes miracles. I am happy of the results! ", "I cannot believe but now I feel awesome. ", "Try it yourself, I am very satisfied. ", "I feel great! " };
        public List<string> authors = new List<string> { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        public List<string> cities = new List<string> { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };


        public void RandomTestimony()
        {
            int randPhrase = rand.Next(0, phrases.Count-1);
            int randEvent = rand.Next(0, events.Count-1);
            int randAuthor = rand.Next(0, authors.Count-1);
            int randCity = rand.Next(0, cities.Count-1);

            Console.WriteLine(this.phrases[randPhrase] + this.events[randEvent] + this.authors[randAuthor] + " - " + this.cities[randCity]);
        }


    }
}
