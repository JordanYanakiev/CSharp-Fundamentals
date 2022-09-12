using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.TheAngryCat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> priceRatings = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
            int entryPoint = int.Parse(Console.ReadLine());
            string priority = Console.ReadLine();

            int leftThingPrice = 0;
            int rightThingPrice = 0;
            int entryPointPrice = 0;
            int totalPrice = 0;

            if (entryPoint < 1 || entryPoint >= priceRatings.Count - 1)
            {
                return;
            }

            if (priority == "cheap")
            {
                leftThingPrice = priceRatings[entryPoint - 1];
                rightThingPrice = priceRatings[entryPoint + 1];
                entryPointPrice = priceRatings[entryPoint];

                if (leftThingPrice < entryPointPrice && leftThingPrice != rightThingPrice && leftThingPrice < rightThingPrice)
                {
                    for (int i = 0; i < entryPoint; i++)
                    {
                        if (priceRatings[i] > int.MaxValue || priceRatings[i] < int.MinValue)
                        {
                            continue;
                        }
                        if (priceRatings[i] < priceRatings[entryPoint])
                        {
                            totalPrice += priceRatings[i];
                        }
                    }
                    Console.WriteLine("Left - " + totalPrice);
                }
                else if (entryPointPrice > rightThingPrice && rightThingPrice != leftThingPrice && rightThingPrice < leftThingPrice)
                {
                    for (int j = entryPoint; j < priceRatings.Count; j++)
                    {
                        if (priceRatings[j] > int.MaxValue || priceRatings[j] < int.MinValue)
                        {
                            return;
                        }
                        if (priceRatings[j] < priceRatings[entryPoint])
                        {
                            totalPrice += priceRatings[j];
                        }
                    }
                    Console.WriteLine("Right - " + totalPrice);
                }
                if (leftThingPrice < entryPointPrice && leftThingPrice == rightThingPrice)
                {
                    for (int i = 0; i < entryPoint; i++)
                    {
                        if (priceRatings[i] > int.MaxValue || priceRatings[i] < int.MinValue)
                        {
                            return;
                        }
                        if (priceRatings[i] < priceRatings[entryPoint])
                        {
                            totalPrice += priceRatings[i];
                        }
                    }
                    Console.WriteLine("Left - " + totalPrice);
                }
            }



            else if (priority == "expensive")
            {
                leftThingPrice = priceRatings[entryPoint - 1];
                rightThingPrice = priceRatings[entryPoint + 1];
                entryPointPrice = priceRatings[entryPoint];

                if (leftThingPrice > entryPointPrice && leftThingPrice != rightThingPrice && leftThingPrice > rightThingPrice)
                {
                    for (int k = 0; k < entryPoint; k++)
                    {
                        if (priceRatings[k] > int.MaxValue || priceRatings[k] < int.MinValue)
                        {
                            return;
                        }
                        if (priceRatings[k] >= priceRatings[entryPoint])
                        {
                            totalPrice += priceRatings[k];
                        }
                    }

                    Console.WriteLine("Left - " + totalPrice);
                }


                else if (entryPointPrice < rightThingPrice && rightThingPrice != leftThingPrice && rightThingPrice > leftThingPrice)
                {
                    for (int l = entryPoint; l < priceRatings.Count; l++)
                    {
                        if (priceRatings[l] > int.MaxValue || priceRatings[l] < int.MinValue)
                        {
                            return;
                        }

                        if (priceRatings[l] >= priceRatings[entryPoint])
                        {
                            totalPrice += priceRatings[l];
                        }
                    }

                    Console.WriteLine("Right - " + totalPrice);
                }
                if (leftThingPrice > entryPointPrice && leftThingPrice == rightThingPrice)
                {
                    for (int k = 0; k < entryPoint; k++)
                    {
                        if (priceRatings[k] > int.MaxValue || priceRatings[k] < int.MinValue)
                        {
                            return;
                        }
                        if (priceRatings[k] >= priceRatings[entryPoint])
                        {
                            totalPrice += priceRatings[k];
                        }
                    }

                    Console.WriteLine("Left - " + totalPrice);
                }
            }
        }
    }
}
