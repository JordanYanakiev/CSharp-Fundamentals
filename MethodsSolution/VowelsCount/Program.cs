using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();

            CountVowels(inputString);

        }

        public static void CountVowels(string input)
        {
            int counter = 0;
            char[] charArr = input.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == 'a' || charArr[i] == 'e' || charArr[i] == 'i' || charArr[i] == 'o' || charArr[i] == 'u' || charArr[i] == 'w' || charArr[i] == 'y' ||
                    charArr[i] == 'A' || charArr[i] == 'E' || charArr[i] == 'I' || charArr[i] == 'O' || charArr[i] == 'U' || charArr[i] == 'W' || charArr[i] == 'Y')
                {
                    counter++;
                }
            }
            

            Console.WriteLine(counter);
            return;
        }
    }
}
