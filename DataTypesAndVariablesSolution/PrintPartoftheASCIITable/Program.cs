using System;

namespace PrintPartoftheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = startNumber; i <= endNumber; i++)
            {
                char letter = (char)i;
                Console.Write(letter + " ");
            }
        }
    }
}
