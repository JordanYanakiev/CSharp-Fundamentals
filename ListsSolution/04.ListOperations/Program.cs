using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string inputCommand = Console.ReadLine();

            while (inputCommand != "End")
            {
                string[] commandsArr = inputCommand.Split(' ');
                string firstCommand = commandsArr[0];
                string secondCommand = commandsArr[1];

                if (firstCommand == "Add")
                {
                    intList.Add(int.Parse(secondCommand));
                }
                else if (firstCommand == "Insert")
                {

                    int index = int.Parse(commandsArr[2]);
                    int value = int.Parse(commandsArr[1]);

                    if (index > intList.Count - 1 || index < 0)
                    {
                        Console.WriteLine("Invalid index");
                        goto ContinueHere;
                    }

                    intList.Insert(index, value);
                }
                else if (firstCommand == "Remove")
                {
                    if (int.Parse(commandsArr[1]) > intList.Count - 1 || int.Parse(commandsArr[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        goto ContinueHere;
                    }
                    else
                    {
                      intList.RemoveAt(int.Parse(commandsArr[1]));
                    }
                }
                else if (secondCommand == "left")
                {
                    for (int i = 0; i < int.Parse(commandsArr[2]); i++)
                    {
                        intList.Add(intList[0]);
                        intList.RemoveAt(0);
                    }
                }
                else if (secondCommand == "right")
                {
                    for (int i = 0; i < int.Parse(commandsArr[2]); i++)
                    {
                        intList.Insert(0, intList[intList.Count - 1]);
                        intList.RemoveAt(intList.Count - 1);
                    }
                }

                ContinueHere:
                inputCommand = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", intList));

        }
    }
}
