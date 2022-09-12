using System;

namespace SmallestOfThreeNumbers
{
    class Program
    {

        public static void SmallestNumber(int number1, int number2, int number3)
        {
            if (number1 < number2 && number1 < number3)
            {
                Console.WriteLine(number1);
                return;
            }
            else if (number2 < number1 && number2 < number3)
            {
                Console.WriteLine(number2);
                return;
            }
            else if (number3 < number2 && number3 < number1)
            {
                Console.WriteLine(number3);
                return;
            }
        }

        
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            SmallestNumber(number1, number2, number3);
        }
    }
}
