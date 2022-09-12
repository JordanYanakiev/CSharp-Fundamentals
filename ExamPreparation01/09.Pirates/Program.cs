using System;
using System.Collections.Generic;

namespace _09.Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] commandsArr = input.Split("||");
            Dictionary<string, int> townPopulation = new Dictionary<string, int>();
            Dictionary<string, int> townGold = new Dictionary<string, int>();

            while (commandsArr[0] != "Sail")
            {
                string townNameStr = commandsArr[0];
                int townPopulationInt = Math.Abs(int.Parse(commandsArr[1]));
                int townGoldInt = Math.Abs(int.Parse(commandsArr[2]));

                if (!townPopulation.ContainsKey(townNameStr))
                {
                    townPopulation.Add(townNameStr, townPopulationInt);
                    townGold.Add(townNameStr, townGoldInt);
                }
                else if (townPopulation.ContainsKey(townNameStr))
                {
                    townPopulation[townNameStr] += townPopulationInt;
                    townGold[townNameStr] += townGoldInt;
                }

                input = Console.ReadLine();
                commandsArr = input.Split("||");
            }

            input = Console.ReadLine();
            commandsArr = input.Split("=>");

            while (commandsArr[0] != "End")
            {
                if (commandsArr[0] == "Plunder")
                {
                    string townNameStr = commandsArr[1];
                    int townPopulationInt = int.Parse(commandsArr[2]);
                    int townGoldInt = int.Parse(commandsArr[3]);

                    townPopulation[townNameStr] -= townPopulationInt;
                    townGold[townNameStr] -= townGoldInt;

                    if (townPopulation[townNameStr] <= 0 || townGold[townNameStr] <= 0)
                    {
                        Console.WriteLine($"{townNameStr} plundered! {townGoldInt} gold stolen, {townPopulationInt} citizens killed.");
                        Console.WriteLine($"{townNameStr} has been wiped off the map!");
                        townPopulation.Remove(townNameStr);
                        townGold.Remove(townNameStr);
                    }
                    else
                    {
                        Console.WriteLine($"{townNameStr} plundered! {townGoldInt} gold stolen, {townPopulationInt} citizens killed.");
                    }
                }
                else if (commandsArr[0] == "Prosper")
                {
                    string townNameStr = commandsArr[1];
                    int townGoldInt = int.Parse(commandsArr[2]);

                    if (townGoldInt <= 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                    else if (townGoldInt >= 0)
                    {
                        townGold[townNameStr] += townGoldInt;
                        Console.WriteLine($"{townGoldInt} gold added to the city treasury. {townNameStr} now has {townGold[townNameStr]} gold.");
                    }
                }

                input = Console.ReadLine();
                commandsArr = input.Split("=>");
            }

            Console.WriteLine($"Ahoy, Captain! There are {townGold.Count} wealthy settlements to go to:");


            if (townPopulation.Count > 0)
            {
                foreach (var settlement in townPopulation)
                {
                    Console.WriteLine($"{settlement.Key} -> Population: {settlement.Value} citizens, Gold: {townGold[settlement.Key]} kg");
                }
            }
            else if (townPopulation.Count <= 0 || townGold.Count <= 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}

