using System;

namespace AddAndSubtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());

            int addedNum = AddNumbers(firstNum, secondNum);
            int total = SubtractNum(addedNum, thirdNum);

            Console.WriteLine(total);
        }


        private static int AddNumbers(int firstNum, int secondNum)
        {
            int result = firstNum + secondNum;
            return result;
        }

        private static int SubtractNum(int result, int thirdNum)
        {
            int total = result - thirdNum;
            return total;
        }

    }
}
