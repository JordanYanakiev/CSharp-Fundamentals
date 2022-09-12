using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char startInput01 = char.Parse(Console.ReadLine());
            char startInput02 = char.Parse(Console.ReadLine());

            Range(startInput01, startInput02);


        }

        public static void Range (char start, char end)
        {
            int num1 = (int)start;
            int num2 = (int)end;


            if (start < end)
            {
                for (int i = start + 1; i < end; i++)
                {
                    Console.Write(Convert.ToChar(i) + " ");
                }
            }
            else
            {
                for (int i = end + 1; i < start; i++)
                {
                    Console.Write(Convert.ToChar(i) + " ");
                }
            }

        }
    }
}
