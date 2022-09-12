using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regexPatern = @">>(?<furnitureName>[A-za-z\s]+)<<(?<furniturePrice>\d+(.\d+)?)!(?<furnitureAmount>\d+)";
            List<string> itemPrices = new List<string>();
            double totalSum = 0;

            while (input != "Purchase")
            {
                Match mtch = Regex.Match(input, regexPatern, RegexOptions.IgnoreCase);

                if (mtch.Success)
                {                    
                    itemPrices.Add(mtch.Groups["furnitureName"].Value);
                    int itemsAmount = int.Parse(mtch.Groups["furnitureAmount"].Value);
                    double itemsPrice = double.Parse(mtch.Groups["furniturePrice"].Value);
                    totalSum += itemsAmount * itemsPrice;
                }

                input = Console.ReadLine();
            }


            Console.WriteLine("Bought furniture:");
            foreach (var furniture in itemPrices)
            {
                Console.WriteLine(furniture);
            }

            Console.WriteLine($"Total money spend: {totalSum:F2}");
        }
    }
}