using System;

namespace _01.TheHuntingGames
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfDays = int.Parse(Console.ReadLine());
            int numberOfPlayers = int.Parse(Console.ReadLine());
            float groupEnergy = float.Parse(Console.ReadLine());
            float waterPerDayForOne = float.Parse(Console.ReadLine());
            float foodPerDayForOne = float.Parse(Console.ReadLine());
            float dailyEnergyLoss = 0f;

            int daysCounter = 1;
            float totalFood = numberOfDays * numberOfPlayers * foodPerDayForOne;
            float totalWater = numberOfDays * numberOfPlayers * waterPerDayForOne;


            while (true)
            {
                    dailyEnergyLoss = float.Parse(Console.ReadLine());

                    groupEnergy -= dailyEnergyLoss;

                if (groupEnergy <= 0)
                {
                    Console.WriteLine($"You will run out of energy. You will be left with {totalFood:F2} food and {totalWater:F2} water.");
                    return;
                }

                //Drink watter
                if (daysCounter % 2 == 0)
                {
                    float waterReduce = totalWater * 0.30f;
                    totalWater -= waterReduce;
                    float addedEnergy = groupEnergy * 0.05f;
                    groupEnergy += addedEnergy;
                }

                //Eat Food
                if (daysCounter % 3 == 0 && daysCounter != 0)
                {
                    //groupEnergy -= dailyEnergyLoss;
                    float foodDenominator = totalFood / numberOfPlayers;
                    totalFood -= foodDenominator;
                    float addedEnergy = groupEnergy * 0.1f;
                    groupEnergy += addedEnergy;
                }

                if (daysCounter == numberOfDays)
                {
                    break;
                }

                daysCounter++;
            }

            Console.WriteLine($"You are ready for the quest. You will be left with - {groupEnergy:F2} energy!");
           


        }
    }
}
