using System;

namespace SumofChars
{
    class Program
    {
        static void Main(string[] args)
        {

            int amount = int.Parse(Console.ReadLine());
            int asciiSum = 0;

            for (int i = 1; i <= amount; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                asciiSum = asciiSum + (int)letter;

            }

            Console.WriteLine("The sum equals: " + asciiSum);
        }
    }
}
