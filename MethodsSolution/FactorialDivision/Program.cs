using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = int.Parse(Console.ReadLine());
            int divider = int.Parse(Console.ReadLine());

            FactorialDivide(factorial, divider);
        }

        public static void FactorialDivide(int factorial, int divider)
        {
            decimal factoralResult1 = (decimal)factorial;
            decimal factoralResult2 = (decimal)divider;
            decimal endResult = 0;

            for (int i = factorial - 1; i >= 1; i--)
            {
                factoralResult1 = factoralResult1 * i;
            }
            
            for (int j = divider - 1; j >= 1; j--)
            {
                factoralResult2 = factoralResult2 * j;
            }

            endResult = factoralResult1 / factoralResult2;

            Console.WriteLine(String.Format("{0:F2}", endResult));
        }
    }
}
