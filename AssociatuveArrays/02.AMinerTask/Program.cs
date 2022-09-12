using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string resourceName = Console.ReadLine();
            int resourceQuantity = 0;
            Dictionary<string, int> resources = new Dictionary<string, int>();

            while (resourceName != "stop")
            {
                resourceQuantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(resourceName))
                {
                    resources.Add(resourceName, 0);
                }

                resources[resourceName] += resourceQuantity;



                resourceName = Console.ReadLine();
            }



            foreach (var resource in resources)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }


        }
    }
}
