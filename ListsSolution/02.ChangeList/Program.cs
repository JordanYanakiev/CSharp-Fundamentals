using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "Insert")
                {
                    AddElements(tokens[1], tokens[2], intList);
                }
                else if (tokens[0] == "Delete")
                {
                    DeleteElements(tokens[1], intList);
                }

                command = Console.ReadLine();

            }

            Console.WriteLine(string.Join(" ", intList));

        }

        private static void DeleteElements(string number, List<int> intList)
        {
            int intNumber = int.Parse(number);

            for (int i = 0; i < intList.Count; i++)
            {
                if (intList[i] == intNumber)
                {
                    intList.RemoveAt(i);
                    i = 0;
                }
            }
        }

        private static void AddElements(string number, string position, List<int> intList)
        {
            int intNumber = int.Parse(number);
            int intPosition = int.Parse(position);

            intList.Insert(intPosition, intNumber);
        }
    }
}
