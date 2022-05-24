using System;

namespace StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToCheck = int.Parse(Console.ReadLine());
            int magicNumber = numberToCheck;
            int tempNumber = 0;
            int factorial = 1;
            int sum = 0;


            while (numberToCheck > 0)
            {
                tempNumber = numberToCheck % 10;
                numberToCheck = numberToCheck / 10;

                for (int i = 2; i <= tempNumber; i++)
                {
                    factorial *= i;
                }

                sum += factorial;
                factorial = 1;
            }

            if (magicNumber == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
