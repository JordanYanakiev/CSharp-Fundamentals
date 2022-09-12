using System;

namespace TriplesofLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            char firstChar = 'a';
            char secondChar = 'a';
            char thirdChar = 'a';

            for (int i = 0; i < input; i++)
            {
                firstChar = (char)('a' + i);
                for (int j = 0; j < input; j++)
                {
                    secondChar = (char)('a' + j);
                    for (int k = 0; k < input; k++)
                    {
                        thirdChar = (char)('a' + k);
                        Console.WriteLine(firstChar + "" + secondChar + "" + thirdChar);
                    }
                }
            }
        }
    }
}
