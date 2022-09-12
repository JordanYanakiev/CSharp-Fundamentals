using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagonsList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();

                if (tokens.Length == 2)
                {
                    int wagon = int.Parse(tokens[1]);
                    wagonsList.Add(wagon);
                }
                else
                {
                    int passangers = int.Parse(tokens[0]);
                    FindWagon(wagonsList, wagonCapacity, passangers);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", wagonsList));
        }

        private static void FindWagon(List<int> wagonsList, int wagonCapacity, int passangers)
        {
            for (int i = 0; i < wagonsList.Count; i++)
            {
                int currentWagon = wagonsList[i];
                if (currentWagon + passangers <= wagonCapacity)
                {
                    wagonsList[i] += passangers;
                    break;
                }
            }
        }
    }
}
