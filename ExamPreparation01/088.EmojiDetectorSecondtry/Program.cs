using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _088.EmojiDetectorSecondtry
{
    class Program
    {
        static void Main(string[] args)
        {
            string emojisPattern = @"(\*{2}|:{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string numbersPattern = @"\d";
            string input = Console.ReadLine();

            MatchCollection emojiMatches = Regex.Matches(input, emojisPattern);
            MatchCollection numbersMatches = Regex.Matches(input, numbersPattern);

            long threshold = 1;

            foreach (Match match in numbersMatches)
            {
                threshold *= int.Parse(match.Value);
            }

            Console.WriteLine($"Cool threshold: {threshold}");
            Console.WriteLine($"{emojiMatches.Count} emojis found in the text. The cool ones are:");

            foreach (Match emoji in emojiMatches)
            {
                string emojiValue = emoji.Groups["emoji"].Value;
                long threshold2 = emojiValue.ToCharArray().Sum(c => c);

                if (threshold2 >= threshold)
                {
                    Console.WriteLine(emoji.Value);
                }
            }

        }
    }
}