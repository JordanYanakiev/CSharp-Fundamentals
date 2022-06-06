using System;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            
            string[] firstArray = firstString.Split(' ');
            string[] secondArray = secondString.Split(' ');

            for (int k = 0; k < firstArray.Length; k++)
            {
                for (int l = 0; l < secondArray.Length; l++)
                {
                    if (firstArray[k] == secondArray[l])
                    {
                        Console.Write(firstArray[k] + " ");
                    }
                }
            }
        }
    }
}
