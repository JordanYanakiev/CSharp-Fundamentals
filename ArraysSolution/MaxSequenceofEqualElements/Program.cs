using System;

namespace MaxSequenceofEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] inputArr = input.Split(' ');
            int counter = 1;
            int positionInArr = 0;
            int posGet = 0;
            int tempNum = 0;
            string tempStr = " ";
            
            string[] charArr = new string[inputArr.Length];
            int[] positionsArr = new int[inputArr.Length];

            for (int i = 0; i < inputArr.Length - 1; i++)
            {
                if (inputArr[i] == inputArr[i + 1])
                {
                    counter++;
                    tempStr = inputArr[i];
                }
                else if (inputArr[i] != inputArr[i + 1])
                {
                    charArr[positionInArr] = tempStr;
                    positionsArr[positionInArr] = counter;
                    positionInArr++;
                    counter = 1;
                }
            }

            charArr[positionInArr] = tempStr;
            positionsArr[positionInArr] = counter;

            for (int j = 0; j < positionsArr.Length - 1; j++)
            {
                if (tempNum < positionsArr[j])
                {
                    posGet = j;
                    tempNum = positionsArr[j];
                }
            }

            string temp = charArr[posGet];

            for (int k = 0; k < tempNum; k++)
            {
                Console.Write(temp + " ");
            }


        }
    }
}
