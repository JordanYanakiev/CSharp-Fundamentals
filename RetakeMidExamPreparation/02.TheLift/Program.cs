using System;
using System.Linq;

namespace _02.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int lineWaitingForTheLift = int.Parse(Console.ReadLine());
            int[] stateOfTheWagons = Console.ReadLine().Split().Select(token => int.Parse(token)).ToArray();

            for (int i = 0; i < stateOfTheWagons.Length; i++)
            {
                if (stateOfTheWagons[i] < 4 && lineWaitingForTheLift > 0)
                {

                    int temp = 4 - stateOfTheWagons[i];

                    if (lineWaitingForTheLift - 4 < 0)
                    {
                        stateOfTheWagons[i] += lineWaitingForTheLift;
                        lineWaitingForTheLift = 0;
                    }
                    else if (lineWaitingForTheLift - 4 >= 0)
                    {
                        stateOfTheWagons[i] += temp;
                        lineWaitingForTheLift -= temp;
                    }
                }
            }

            if (lineWaitingForTheLift > 0)
            {
                Console.WriteLine($"There isn't enough space! {lineWaitingForTheLift} people in a queue!");
                Console.WriteLine($"{string.Join(" ", stateOfTheWagons)}");
            }
            else if (lineWaitingForTheLift == 0)
            {
                bool isEmptySpot = false;
                foreach (var wagon in stateOfTheWagons)
                {
                    if (wagon < 4)
                    {
                        isEmptySpot = true;
                    }
                }

                Console.WriteLine($"The lift has empty spots!");
                Console.WriteLine($"{string.Join(" ", stateOfTheWagons)}");
            }
        }
    }
}
