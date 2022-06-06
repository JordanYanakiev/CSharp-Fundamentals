using System;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputArray = Console.ReadLine();
            int swaps = int.Parse(Console.ReadLine());

            string[] inputString = inputArray.Split(' ');
            int[] intArr = new int[inputString.Length];

            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = int.Parse(inputString[i]);
            }

            for (int j = 0; j < swaps; j++)
            {
                int firstNum = intArr[0];
                
                for (int k = 0; k < intArr.Length - 1; k++)
                {
                    intArr[k] = intArr[k + 1];
                }
                intArr[intArr.Length - 1] = firstNum;
            }

            for (int l = 0; l < intArr.Length; l++)
            {
                Console.Write(intArr[l].ToString() + " ");
            }
        }
    }
}
