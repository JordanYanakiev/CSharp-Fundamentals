using System;

namespace _02.CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputString = Console.ReadLine().Split();
            string arg01 = inputString[0];
            string arg02 = inputString[1];
            int result = 0;
            CalculateASCIICodes(arg01, arg02, result);
        }

        private static void CalculateASCIICodes(string str1, string str2, int result)
        {
            int value1 = 0;
            int value2 = 0;


            if (str1.Length < str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    value1 += str1[i] * str2[i];
                }

                for (int j = str1.Length; j < str2.Length; j++)
                {
                    value1 += str2[j];
                }

            }

            if (str1.Length == str2.Length)
            {
                for (int i = 0; i < str1.Length; i++)
                {
                    value1 += str1[i] * str2[i];
                }
            }

            if (str1.Length > str2.Length)
            {
                for (int i = 0; i < str2.Length; i++)
                {
                    int num1 = str1[i];
                    int num2 = str2[i];
                    value1 += num1 * num2;
                }

                for (int j = str2.Length; j < str1.Length; j++)
                {
                    value1 += str1[j];
                }

            }

            result = value1 + value2;

            Console.WriteLine(result);

        }
    }
}
