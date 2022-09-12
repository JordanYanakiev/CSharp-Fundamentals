using System;
using System.Collections.Generic;

namespace _01.CountCharsinaString
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] charArr = Console.ReadLine().ToCharArray();
            Dictionary<char, int> charDiict = new Dictionary<char, int>();

            foreach (char character in charArr)
            {
                if (character != ' ')
                {
                    if (!charDiict.ContainsKey(character))
                    {
                        charDiict.Add(character, 0);
                    }

                    charDiict[character]++;
                }
            }


            foreach (var element in charDiict)
            {
                Console.WriteLine($"{element.Key} -> {element.Value}");
            }


        }
    }
}
