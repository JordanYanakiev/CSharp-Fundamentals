using System;
using System.Collections.Generic;

namespace _03.DegustationParty
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cmdArr = Console.ReadLine().Split("-");
            Dictionary<string, List<string>> likedMeals = new Dictionary<string, List<string>>();
            Dictionary<string, List<string>> dislikedMeals = new Dictionary<string, List<string>>();
            int dislikedMealsCounter = 0;

            while (cmdArr[0] != "Stop")
            {
                string likeDislike = cmdArr[0];
                string guest = cmdArr[1];
                string meal = cmdArr[2];

                if (likeDislike == "Like")
                {
                    if (!likedMeals.ContainsKey(guest))
                    {
                        likedMeals.Add(guest, new List<string> {meal});
                        dislikedMeals.Add(guest, new List<string>());
                    }
                    else if (likedMeals.ContainsKey(guest) && !likedMeals[guest].Contains(meal))
                    {
                        likedMeals[guest].Add(meal);
                    }
                }
                else if (likeDislike == "Dislike")
                {
                    if (likedMeals.ContainsKey(guest))
                    {
                        if (!likedMeals[guest].Contains(meal))
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }
                        else if (likedMeals[guest].Contains(meal))
                        {
                            dislikedMeals[guest].Add(meal);
                            likedMeals[guest].Remove(meal);
                            dislikedMealsCounter++;
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                        }
                    }
                    else if (!likedMeals.ContainsKey(guest))
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                }

                cmdArr = Console.ReadLine().Split("-");
            }

            foreach (var guest in likedMeals)
            {
                Console.WriteLine($"{guest.Key}: {string.Join(", ", guest.Value)}");
            }

            Console.WriteLine($"Unliked meals: {dislikedMealsCounter}");
        }
    }
}
