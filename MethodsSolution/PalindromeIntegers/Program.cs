using System;

namespace PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            Palindrome(inputString);
        }

        private static void Palindrome(string inputString)
        {
            string inputStr = inputString;
            bool state = false;

            while (inputStr != "END")
            {
                char[] charArr = inputStr.ToCharArray();

                

                for (int i = 0; i < charArr.Length / 2; i++)
                {
                    
                    int mirrorInt = (charArr.Length - 1) - i;
                    
                    if (charArr[i] == charArr[mirrorInt])
                    {
                        state = true;
                    }
                    else
                    {
                        state = false;
                    }

                    if (state == false)
                    {
                        Console.WriteLine("false");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("true");
                        break;
                    }
                }

                if (charArr.Length == 1)
                {
                    state = true;
                    Console.WriteLine("true");
                }

                inputStr = Console.ReadLine();

            }
        }
    }
}
