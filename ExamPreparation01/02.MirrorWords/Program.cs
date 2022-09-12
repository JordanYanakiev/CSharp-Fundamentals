using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string stringPattern = @"\#[A-Za-z]{3,}\#\#[A-Za-z]{3,}\#|\@[\w]{3,}\@\@[\w]{3,}\@";
            string stringPattern2 = @"\#[A-Za-z]{3,}\#|\@[\w]{3,}\@";
            int pairsCounter = 0;
            List<string> matchedWord = new List<string>();
            List<string> mirrorWords = new List<string>();
            List<string> sortedWords = new List<string>();

            MatchCollection matchList = Regex.Matches(inputString, stringPattern);
            matchedWord = matchList.Cast<Match>().Select(match => match.Value).ToList();

            for (int j = 0; j < matchedWord.Count; j++)
            {
                MatchCollection matchList2 = Regex.Matches(matchedWord[j], stringPattern2);
                var smth  = matchList2[0];
                var smth2  = matchList2[1];
                matchedWord = matchList.Cast<Match>().Select(match => match.Value).ToList();
                sortedWords.Add(smth.Value.ToString());
                sortedWords.Add(smth2.Value.ToString());
            }

            for (int i = 0; i < sortedWords.Count - 1; i++)
            {
                string word1 = sortedWords[i];
                char[] word2 = sortedWords[i + 1].ToCharArray();
                string tempWord = string.Join("", word2);
                word2 = word2.Reverse().ToArray();
                string word2FromChars = string.Join("", word2);

                if (sortedWords[i] == word2FromChars)
                {
                    mirrorWords.Add(word1);
                    mirrorWords.Add(tempWord);
                }
            }

            pairsCounter = sortedWords.Count / 2;

            if (pairsCounter > 0)
            {
                if (mirrorWords.Count > 0)
                {
                    Console.WriteLine(pairsCounter + " word pairs found!");
                    Console.WriteLine("The mirror words are:");

                    for (int j = 0; j < mirrorWords.Count; j++)
                    {
                        if (mirrorWords[j].Contains("#") || mirrorWords[j].Contains("@"))
                        {
                            mirrorWords[j] = mirrorWords[j].Remove(0, 1);
                            mirrorWords[j] = mirrorWords[j].Remove(mirrorWords[j].Length - 1);
                        }
                        Console.Write(mirrorWords[j]);
                        if (j % 2 == 0)
                        {
                            Console.Write(" <=> ");
                        }
                        if (j % 2 != 0 && j != mirrorWords.Count - 1)
                        {
                            Console.Write(", ");
                        }
                    }
                }
                else if (mirrorWords.Count == 0 && matchedWord.Count > 0)
                {
                    Console.WriteLine(pairsCounter + " word pairs found!");
                    Console.WriteLine("No mirror words!");
                }
            }
            else 
            {
                Console.WriteLine("No word pairs found!");
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
