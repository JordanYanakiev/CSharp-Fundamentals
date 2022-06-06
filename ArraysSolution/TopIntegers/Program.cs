using System;

namespace TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            string[] stringArr = inputString.Split(' ');

            int[] intArr = new int[stringArr.Length];
            int[] greatInt = new int[intArr.Length];
            int posCount = 0;

            //Convert string to int
            for (int i = 0; i < intArr.Length; i++)
            {
                if (stringArr[i] == "")
                {
                    intArr[i] = 0;
                }
                else
                {
                    bool isNumeric = int.TryParse(stringArr[i], out intArr[i]);
                    //intArr[i] = int.Parse(stringArr[i]);
                }
            }

            if (intArr.Length == 1)
            {
                greatInt[posCount] = intArr[0];
                posCount++;
            }

            //Get the bigger ints
            for (int j = 0; j < intArr.Length - 1; j++)
            {
                if (intArr[j] > intArr[j + 1])
                {
                    greatInt[posCount] = intArr[j];
                    posCount++;
                }

                if ( j == intArr.Length - 2)
                {
                    greatInt[posCount] = intArr[intArr.Length - 1];
                    posCount++;
                }

                if (posCount >= 2 && j < greatInt.Length)
                {
                    if (greatInt[posCount - 1] > greatInt[posCount - 2])
                    greatInt[posCount - 2] = 0;
                }
            }

            for (int k = 0; k < greatInt.Length; k++)
            {
                if (greatInt[k] != 0)
                {
                    Console.Write(greatInt[k].ToString() + " ");
                }
            }
        }
    }
}
