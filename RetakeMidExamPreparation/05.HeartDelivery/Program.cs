using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> neighbourhoodList = Console.ReadLine().Split("@").Select(x => int.Parse(x)).ToList();
            string[] cmdArr = Console.ReadLine().Split();
            int currIndex = 0;
            bool hasValentinesDay = false;
            int housesThatDoesNotHaveValentinesDay = 0;

            while (cmdArr[0] != "Love!")
            {
                int indexuu = int.Parse(cmdArr[1]);
                currIndex += indexuu;
                if ((currIndex >= 0 && currIndex <= neighbourhoodList.Count - 1))
                {
                    if (neighbourhoodList[currIndex] > 0)
                    {
                        neighbourhoodList[currIndex] -= 2; 
                        
                        if (neighbourhoodList[currIndex] <= 0)
                        {
                            Console.WriteLine($"Place {currIndex} has Valentine's day.");
                            neighbourhoodList[currIndex] = 0;
                        }
                    }else if (neighbourhoodList[currIndex] <= 0)
                    {
                        Console.WriteLine($"Place {currIndex} already had Valentine's day.");
                        neighbourhoodList[currIndex] = 0;
                    }
                }
                //else if ((currIndex > 0 && currIndex <= neighbourhoodList.Count - 1))
                //{
                //    if (neighbourhoodList[currIndex] == 0)
                //    {
                //        Console.WriteLine($"Place {currIndex} already had Valentine's day.");
                //    }
                //}
                else if (currIndex < 0 || currIndex > neighbourhoodList.Count - 1)
                {
                    currIndex = 0;

                    if (neighbourhoodList[currIndex] == 0)
                    {
                        Console.WriteLine($"Place {currIndex} already had Valentine's day.");
                    }
                    else if (neighbourhoodList[currIndex] > 0)
                    {
                        neighbourhoodList[currIndex] -= 2;
                        
                        if (neighbourhoodList[currIndex] <= 0)
                        {
                            neighbourhoodList[currIndex] = 0;
                            Console.WriteLine($"Place {currIndex} has Valentine's day.");
                        }
                    }

                }
                    cmdArr = Console.ReadLine().Split();
            }

            Console.WriteLine($"Cupid's last position was {currIndex}.");

            foreach (var house in neighbourhoodList)
            {
                if (house != 0)
                {
                    hasValentinesDay = false;
                    housesThatDoesNotHaveValentinesDay++;
                }
                else if (house == 0)
                {
                    hasValentinesDay = true;
                }
            }

            if (housesThatDoesNotHaveValentinesDay > 0)
            {
                Console.WriteLine($"Cupid has failed {housesThatDoesNotHaveValentinesDay} places.");
            }
            else if (housesThatDoesNotHaveValentinesDay == 0)
            {
                Console.WriteLine($"Mission was successful.");
            }

        }
    }
}
