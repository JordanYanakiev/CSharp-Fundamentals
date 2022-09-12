using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            int tempNum = 0;
            int numSum = 0;

            while (inputNum > 0)
            {
                tempNum = inputNum % 10;
                inputNum = inputNum / 10;
                numSum += tempNum;
            }

            Console.WriteLine(numSum);

        }
    }
}
