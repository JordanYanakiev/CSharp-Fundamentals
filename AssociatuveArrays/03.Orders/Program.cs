using System;
using System.Collections.Generic;

namespace _03.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productInput = Console.ReadLine().Split(" ");


            Dictionary<string, int> productQuantity = new Dictionary<string, int>();
            Dictionary<string, double> totalPrice = new Dictionary<string, double>();

            string product = productInput[0];
            double price = 0;
            double totalPriceSum = 0;
            int quantity = 0;


            while (product != "buy")
            {
                price = double.Parse(productInput[1]);
                quantity = int.Parse(productInput[2]);

                if (!productQuantity.ContainsKey(product))
                {
                    productQuantity.Add(product, 0);
                }

                productQuantity[product] += quantity;
                totalPriceSum = productQuantity[product] * price;
                totalPrice[product] = totalPriceSum;

                productInput = Console.ReadLine().Split(" ");
                product = productInput[0];
            }

            foreach (var productProd in totalPrice)
            {
                Console.WriteLine($"{productProd.Key} -> {productProd.Value:F2}");
            }


        }
    }
}
