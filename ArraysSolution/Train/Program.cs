using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int trainLength = int.Parse(Console.ReadLine());
            int[] train = new int[trainLength];
            int totalSum = 0;

            for (int i = 0; i < train.Length; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                totalSum += train[i];
            }

            for (int j = 0; j < train.Length; j++)
            {
                Console.Write(train[j] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(totalSum);

        }
    }
}
