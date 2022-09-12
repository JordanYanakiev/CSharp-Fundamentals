using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputArr = Console.ReadLine().Split("\\");
            string[] word = inputArr[inputArr.Length - 1].Split(".");

            Console.WriteLine($"File name: {word[0]}");
            Console.WriteLine($"File extension: {word[1]}");
        }
    }
}
