using System;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArr = input.Split(' ');
            int[] intArr = new int[inputArr.Length];

            int halfSize = intArr.Length / 2;
            int sum1 = 0;
            int sum2 = 0;
            int leftSideCounter = 0;

            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = int.Parse(inputArr[i]);
            }

            for (int j = 0; j < intArr.Length; j++)
            {
                for (int k = 0; k < j; k++)
                {
                    sum1 += intArr[k];
                    leftSideCounter++;
                }

                for (int l = j+1; l < intArr.Length; l++)
                {
                    sum2 += intArr[l];
                }

                if (sum1 == sum2)
                {
                    Console.WriteLine(leftSideCounter);
                    return;
                }

                sum1 = 0;
                sum2 = 0;
                leftSideCounter = 0;
            }

            if(intArr.Length == 1)
            {
                Console.WriteLine("0");
            }

            Console.WriteLine("no");

        }
    }
}
