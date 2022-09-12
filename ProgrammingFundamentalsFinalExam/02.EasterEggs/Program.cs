using System;
using System.Text.RegularExpressions;

namespace _02.EasterEggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string validPattern = @"[@|#]{1,}(?<color>[a-z]{3,})[@|#]{1,}[!\(\)\+\-*\/%&$^]*?\/{1,}(?<number>[\d]+)\/{1,}";
            string input = Console.ReadLine();

            MatchCollection colorMatch = Regex.Matches(input, validPattern);

            foreach (var match in colorMatch)
            {
                string tempStr = match.ToString();
                Match color = Regex.Match(tempStr, validPattern);
                Console.WriteLine($"You found {color.Groups["number"].Value} {color.Groups["color"].Value} eggs!");
            }

        }
    }
}
