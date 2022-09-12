using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            string targetsInput = Console.ReadLine();
            List<int> targetsArr = targetsInput.Split(' ', StringSplitOptions.RemoveEmptyEntries)?.Select(Int32.Parse)?.ToList();
            string input = Console.ReadLine();
            string[] commandsArr = input.Split();

            while (commandsArr[0] != "End")
            {
                string command = commandsArr[0];
                switch (command)
                {
                    case "Shoot":
                        {
                            int index = int.Parse(commandsArr[1]);
                            int power = int.Parse(commandsArr[2]);

                            if (index >= 0 && index < targetsArr.Count - 1)
                            {
                                targetsArr[index] -= power;

                                if (targetsArr[index] <= 0)
                                {
                                    targetsArr.RemoveAt(index);
                                }
                            }
                            else if (index < 0 && index > targetsArr.Count - 1)
                            {
                                return;
                            }
                            break;
                        }

                    case "Add":
                        {
                            int index = int.Parse(commandsArr[1]);
                            int value = int.Parse(commandsArr[2]);

                            if (index >= 0 && index < targetsArr.Count)
                            {
                                //targetsArr[index] += value;
                                targetsArr.Insert(index, value);
                            }
                            else
                            {
                                Console.WriteLine("Invalid placement!");
                            }
                                break;
                        }

                    case "Strike":
                        {
                            int index = int.Parse(commandsArr[1]);
                            int radius = int.Parse(commandsArr[2]);

                            if (index - radius >= 0 && index + radius <= targetsArr.Count - 2)
                            {
                                int count = (radius * 2) + 1;
                                targetsArr.RemoveRange(index - radius, count);                              
                            }
                            else
                            {
                                Console.WriteLine("Strike missed!");
                            }
                            break;
                        }
                }

                input = Console.ReadLine();
                commandsArr = input.Split();
            }

            Console.WriteLine(string.Join("|", targetsArr));

        }
    }
}
