using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string character = Console.ReadLine();

            DrawMatrix(character);
        }

        private static void DrawMatrix(string character)
        {
            int number = int.Parse(character);

                for (int i = 0; i < number; i++)
                {
                    for (int j = 0; j < number; j++)
                    {
                        Console.Write(character + " ");
                    }
                    Console.WriteLine();
                }
        }

    }
}
