using System;
using System.Text;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            StringBuilder sb = new StringBuilder();


            for (int i = 0; i < inputString.Length; i++)
            {
                if (i == 0)
                {
                    sb.Append(inputString[i]);
                }

                if (i <= inputString.Length - 3)
                {
                    if (inputString[i] != inputString[i + 1])
                    {
                        sb.Append(inputString[i + 1]);
                    }
                }

                if (i == inputString.Length - 1)
                {
                    if (inputString[inputString.Length - 2] != inputString[inputString.Length - 1])
                    {
                        sb.Append(inputString[inputString.Length - 1]);
                    }
                }
            }

            Console.WriteLine(sb);
        }
    }
}
