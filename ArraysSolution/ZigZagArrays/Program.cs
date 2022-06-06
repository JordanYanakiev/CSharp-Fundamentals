using System;
using System.Collections.Generic;

namespace ZigZagArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int arrOneCount = 0;
            int arrTwoCount = 0;
            int[] arrOne = new int[rows];
            int[] arrTwo = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                string tempString = Console.ReadLine();
                
                string[] tempArr = tempString.Split(' ');

                for (int j = 0; j < 2; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        arrOne[arrOneCount] =int.Parse(tempArr[j]);
                        arrOneCount++;
                    }
                    else if (i % 2 != 0 && j % 2 != 0)
                    {
                        arrOne[arrOneCount] = int.Parse(tempArr[j]);
                        arrOneCount++;
                    }
                    else
                    {
                        arrTwo[arrTwoCount] = int.Parse(tempArr[j]);
                        arrTwoCount++;
                    }
                }
            }

            for (int k = 0; k < arrOne.Length; k++)
            {
                Console.Write(arrOne[k].ToString() + ' ');
            }

            Console.WriteLine();

            for (int l = 0; l < arrTwo.Length; l++)
            {
                Console.Write(arrTwo[l].ToString() + ' ');
            }
        }
    }
}

