using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _08.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            //THIS SOLUTION OF THE PROBLEM GIVES 40% IN JUDGE

            string pattern = @"\:\:(?<emoji>[A-Z]{1}[a-z]{2,})\:\:|\*\*(?<emoji2>[A-Z]{1}[a-z]{2,})\*\*|(?<numbers>[\d]+)";
            string input = Console.ReadLine();
            string[] inputArr = input.Split();
            List<string> emoticons = new List<string>();
            List<int> numbers = new List<int>();
            List<string> matchList = new List<string>();
            long digitsSum = 0;
            long coolThresholdSum = 1;
            long matchSize = 0;
            int counter = 0;

            for (int i = 0; i < inputArr.Length; i++)
            {
                string tempString = null;

                if (Regex.IsMatch(inputArr[i], pattern))
                {
                    Match match = Regex.Match(inputArr[i], pattern);
                    if (match.Groups[1].Value != "")
                    {
                        matchSize++;
                        tempString = match.Groups[1].Value;
                        emoticons.Add(tempString);
                        matchList.Add(match.Groups[0].Value);
                    }
                    else if (match.Groups[2].Value != "")
                    {
                        matchSize++;
                        tempString = match.Groups[2].Value;
                        emoticons.Add(tempString);
                        matchList.Add(match.Groups[0].Value);
                    }
                    else if (match.Groups[3].Value != "")
                    {
                        string midString = match.Groups[3].Value;

                        foreach (char ch in midString)
                        {
                            if (char.IsDigit(ch))
                            {
                                int number = int.Parse(ch.ToString());
                                numbers.Add(number);
                            }
                        }
                    }
                }
            }

            foreach (long num in numbers)
            {
                coolThresholdSum = coolThresholdSum * num;
            }

            Console.WriteLine($"Cool threshold: {coolThresholdSum}");
            Console.WriteLine($"{matchSize} emojis found in the text. The cool ones are:");

            foreach (string emoticon in emoticons)
            {

                foreach (char symbol in emoticon)
                {
                    digitsSum += symbol;
                }

                if (digitsSum >= coolThresholdSum)
                {
                    Console.WriteLine($"{matchList[counter]}");
                }
                digitsSum = 0;
                counter++;
            }
        }
    }
}
