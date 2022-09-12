using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombNumerArr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            BombList(bombNumerArr[0], bombNumerArr[1], intList);
            int sum = SumNumbers(intList);

            Console.WriteLine(sum);
        }

        private static int SumNumbers(List<int> listToSum)
        {
            int sum = 0;

            for (int i = 0; i < listToSum.Count; i++)
            {
                sum += listToSum[i];
            }

            return sum;
        }

        private static void BombList(int bombNumber, int powerOfBomb, List<int> listToBomb)
        {

            for (int i = 0; i < listToBomb.Count; i++)
            {
                if (listToBomb[i] == bombNumber)
                {
                    int indexToRemove = (i - 1) - powerOfBomb;
                    int start = i - powerOfBomb;
                    if (start < 0)
                    {
                        start = 0;
                    }
                    int end = i + powerOfBomb ;
                    for (int j = start; j <= end; j++)
                    {
                        
                        if (j > listToBomb.Count - 1)
                        {
                            return;
                        }
                        listToBomb[j] = 0;
                    }
                    
                }
            }
        }
    }
}
