using System;
using System.Collections.Generic;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> listOfNames = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                if (listOfNames.Contains(command[0])&& command[2] == "going!")
                {
                    Console.WriteLine($"{command[0]} is already in the list!");
                }
                else if (listOfNames.Contains(command[0]) && command[2] == "not")
                {
                    listOfNames.Remove(command[0]);
                }
                else if (!listOfNames.Contains(command[0]) && command[2] == "not")
                {
                    Console.WriteLine($"{command[0]} is not in the list!");
                }
                else
                {
                    listOfNames.Add(command[0]);
                }
            }

            foreach (string name in listOfNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
