using System;
using System.IO;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string coinsInput = null;
            string itemsInput = null;

            float coins = 0;
            float coinsSum = 0;
            float price = 0;
            float change = 0;
            int operationCounter = 0;

            while (coinsInput != "Start" && operationCounter == 0)
            {
                coinsInput = Console.ReadLine();

                if (coinsInput == "Start")
                {
                    operationCounter++;
                }

                char[] cArray = coinsInput.ToCharArray();
                bool isNumber = Char.IsDigit(cArray[0]);

                if (isNumber)
                {
                    coins = float.Parse(coinsInput);

                    if (coins == 0.1f || coins == 0.2f || coins == 0.5f || coins == 1f || coins == 2f)
                    {
                        coinsSum += coins;
                    }
                    else
                    {
                        Console.WriteLine(String.Format("Cannot accept {0:F2}", coins));
                    }
                }
            }

            coinsInput = Console.ReadLine();

            while (coinsInput != "End")
            {

                if (coinsInput == "Nuts" && coinsSum >= 2f)
                {
                    coinsSum -= 2f;
                    Console.WriteLine("Purchased nuts");
                }
                else if (coinsInput == "Water" && coinsSum >= 0.7f)
                {
                    coinsSum -= 0.7f;
                    Console.WriteLine("Purchased water");
                }
                else if (coinsInput == "Crisps" && coinsSum >= 1.5f)
                {
                    coinsSum -= 1.5f;
                    Console.WriteLine("Purchased crisps");
                }
                else if (coinsInput == "Soda" && coinsSum >= 0.8f)
                {
                    coinsSum -= 0.8f;
                    Console.WriteLine("Purchased soda");
                }
                else if (coinsInput == "Coke" && coinsSum >= 1.0f)
                {
                    coinsSum -= 1.0f;
                    Console.WriteLine("Purchased coke");
                }
                else if ((coinsInput == "Nuts" && coinsSum < 2.0f) || (coinsInput == "Water" && coinsSum < 0.7f) 
                    || (coinsInput == "Crisps" && coinsSum < 1.5f) || (coinsInput == "Soda" && coinsSum < 0.8f) 
                    || (coinsInput == "Coke" && coinsSum < 1.0f))
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                else if (coinsInput != "Nuts" || coinsInput != "Water" || coinsInput != "Crisps" || coinsInput != "Soda" || coinsInput != "Coke")
                {
                    Console.WriteLine("Invalid product");
                }
                coinsInput = Console.ReadLine();
            }
            Console.WriteLine(String.Format("Change: {0:F2}", coinsSum));

        }
    }
}
