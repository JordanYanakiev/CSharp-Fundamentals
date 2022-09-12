using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfNames = Console.ReadLine().Split(", ").ToList();
            string input = Console.ReadLine();
            Regex namePattern = new Regex(@"(?<name>[A-Za-z]+)"); 
            Regex distancePattern = new Regex(@"(?<distance>[0-9])");
            Dictionary<string, int> namesAndDistances = new Dictionary<string, int>();
            int totalDistance = 0;

            while (input != "end of race")
            {

                MatchCollection matchedNames = namePattern.Matches(input);
                MatchCollection matchedDistance = distancePattern.Matches(input);
                string name = string.Join("", matchedNames);

                foreach (var distance in matchedDistance)
                {
                    int dist = int.Parse(distance.ToString());
                    totalDistance += dist;
                }

                if (listOfNames.Contains(name)) 
                {
                    if (!namesAndDistances.ContainsKey(name))
                    {
                        namesAndDistances.Add(name, totalDistance);
                    }
                    else
                    {
                        namesAndDistances[name] += totalDistance;
                    } 
                }

                input = Console.ReadLine();
                totalDistance = 0;
            }

            namesAndDistances = namesAndDistances.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("1st place: " + namesAndDistances.ElementAt(0).Key);
            Console.WriteLine("2nd place: " + namesAndDistances.ElementAt(1).Key);
            Console.WriteLine("3rd place: " + namesAndDistances.ElementAt(2).Key);

        }
    }
}
