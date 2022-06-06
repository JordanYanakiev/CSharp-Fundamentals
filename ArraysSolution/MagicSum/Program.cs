using System;
using System.Linq;

namespace MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int compareNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputArr.Length; i++)
            {
                for (int j = 1; j < inputArr.Length; j++)
                {
                    if (inputArr[i] + inputArr[j] == compareNum)
                    {
                        Console.WriteLine(inputArr[i] + " " + inputArr[j]);
                        inputArr[i] = 0;
                        inputArr[j] = 0;
                    }
                }
            }
        }
    }
}
