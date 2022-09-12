using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string regexPattern1 = @"[starSTAR]";
            string regexPattern2 = @"@(?<planet>[A-Z][a-z]+)[^@\-!:]*\:(?<population>[\d]+)[^@\-!:]*!(?<attacktype>[AD])![^@\-!:]*->(?<soldierCount>[\d]+)";
            int inputNumber = int.Parse(Console.ReadLine());
            int attackedPlanetsCount = 0;
            int destroyedPlanetsCount = 0;
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < inputNumber; i++)
            {
                string input = Console.ReadLine();
                MatchCollection matchCol = Regex.Matches(input, regexPattern1);

                List<char> tempChars = new List<char>();

                foreach (char ch in input)
                {
                    int ascii = ch;
                    ascii -= matchCol.Count;
                    char newChar = (char)ascii;
                    tempChars.Add(newChar);
                }

                string decodedString = string.Join("", tempChars);

                Match mtch = Regex.Match(decodedString, regexPattern2);

                if (mtch.Success)
                {
                    string planet = mtch.Groups["planet"].Value;
                    int population = int.Parse(mtch.Groups["population"].Value);
                    string attackType = mtch.Groups["attacktype"].Value;
                    int attackingArmy = int.Parse(mtch.Groups["soldierCount"].Value);

                    if (attackType == "A" && attackingArmy > 0 && population > 0)
                    {
                        attackedPlanets.Add(planet);
                    }
                    else if (attackType == "D" && attackingArmy > 0 && population > 0)
                    {
                        destroyedPlanets.Add(planet);
                    }
                }
            }

            if (attackedPlanets.Count == 0) 
            {
                Console.WriteLine($"Attacked planets: {attackedPlanets.Count}"); 
            }
            else if (attackedPlanets.Count > 0)
            {
                Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
                attackedPlanets.Reverse();
                foreach (var planet in attackedPlanets)
                {
                    Console.WriteLine($"-> {planet}");
                }
            }

            if (destroyedPlanets.Count == 0)
            {
                Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            }
            else if (destroyedPlanets.Count > 0)
            {
                Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
                destroyedPlanets.Reverse();
                foreach (var planet in destroyedPlanets)
                {
                    Console.WriteLine($"-> {planet}");
                }
            }


        }
    }
}
