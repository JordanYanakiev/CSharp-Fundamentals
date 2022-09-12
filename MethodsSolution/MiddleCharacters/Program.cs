using System;

namespace MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            MiddleSymbol(inputString);
        }

        private static void MiddleSymbol(string _inputStr)
        {
            char[] charArr = _inputStr.ToCharArray();
            int middle = charArr.Length / 2;

            if (charArr.Length % 2 != 0)
            {
                Console.Write(charArr[middle]);
            }
            else if (charArr.Length % 2 == 0)
            {
                middle -= 1;
                Console.Write(charArr[middle] + "" + charArr[middle + 1]);
            }

        }
    }
}
