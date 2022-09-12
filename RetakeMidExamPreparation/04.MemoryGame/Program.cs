using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            string[] commandsArr = Console.ReadLine().Split();
            int movesCount = 0;

            while (commandsArr[0] != "end")
            {
                int index1 = int.Parse(commandsArr[0]);
                int index2 = int.Parse(commandsArr[1]);
                movesCount++;

                if (index1 == index2 || index1 < 0 || index2 < 0 || index1 > inputList.Count - 1 || index2 > inputList.Count - 1)
                {
                    inputList.Insert(inputList.Count / 2, $"-{movesCount}a");
                    inputList.Insert(inputList.Count / 2, $"-{movesCount}a");
                    Console.WriteLine($"Invalid input! Adding additional elements to the board");
                }
                else if (inputList[index1] == inputList[index2]/* && (index1 >= 0 && index2 >= 0 && index1 < inputList.Count - 1 && index2 < inputList.Count - 1)*/)
                {
                    string temp = inputList[index1];
                    inputList.RemoveAt(index1);
                    int secondIndex = inputList.IndexOf(temp);
                    inputList.RemoveAt(secondIndex);
                    Console.WriteLine($"Congrats! You have found matching elements - {temp}!");
                    if (inputList.Count == 0)
                    {
                        Console.WriteLine($"You have won in {movesCount} turns!");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine($"Try again!");
                }
                commandsArr = Console.ReadLine().Split();
            }

            Console.WriteLine($"Sorry you lose :(");
            Console.WriteLine(string.Join(" ", inputList));

        }
    }
}
