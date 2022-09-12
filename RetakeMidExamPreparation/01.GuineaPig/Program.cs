using System;

namespace _01.GuineaPig
{
    class Program
    {
        static void Main(string[] args)
        {
            double startFood = double.Parse(Console.ReadLine()) * 1000;
            double startHay = double.Parse(Console.ReadLine()) * 1000;
            double startCover = double.Parse(Console.ReadLine()) * 1000;
            double guineaPigWeight = double.Parse(Console.ReadLine()) * 1000;
            double food = startFood;
            double hay = startHay;
            double cover = startCover;
            double coverAmount = guineaPigWeight / 3;

            for (int i = 1; i <= 30; i++)
            {
                food -= 300d;

                if (i % 2 == 0)
                {
                    hay -= food * 0.05;
                }

                if (i % 3 == 0)
                {
                    cover -= coverAmount;
                }
            }

            if (food > 0 && hay > 0 && cover > 0)
            {
                double excessFood = (food)/1000;
                double excessHay = (hay)/1000;
                double excessCover = (cover)/1000;
                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {excessFood:F2}, Hay: {excessHay:F2}, Cover: {excessCover:F2}.");
            }
            else
            {
                Console.WriteLine($"Merry must go to the pet store!");
            }

        }
    }
}
