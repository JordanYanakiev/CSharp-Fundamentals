using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int inputNumber = 0;
            int sum = 0;


            for (int i = 0; i < number; i++)
            {
                inputNumber = int.Parse(Console.ReadLine());
                sum += inputNumber;

                if (sum > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    sum -= inputNumber;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
