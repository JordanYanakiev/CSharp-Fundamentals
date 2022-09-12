using System;
using System.Collections.Generic;

namespace _07.CtivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string commands = Console.ReadLine();
            string[] commandsArr = commands.Split(">>>");

            while (commandsArr[0] != "Generate")
            {

                switch (commandsArr[0])
                {
                    case "Contains":
                        {
                            string substring = commandsArr[1];

                            if (input.Contains(substring))
                            {
                                Console.WriteLine($"{input} contains {substring}");
                            }
                            else
                            {
                                Console.WriteLine("Substring not found!");
                            }

                            break;
                        }

                    case "Flip":
                        {
                            string upperLower = commandsArr[1];
                            int startIndex = int.Parse(commandsArr[2]);
                            int endIndex = int.Parse(commandsArr[3]);

                            if (upperLower == "Upper")
                            {
                                List<char> temp = new List<char>();

                                for (int i = startIndex; i < endIndex; i++)
                                {
                                    temp.Add(input[i]);
                                }
                                string tempString = string.Join("", temp);
                                tempString = tempString.ToUpper();

                                input = input.Remove(startIndex, endIndex - startIndex);
                                input = input.Insert(startIndex, tempString);

                            }
                            else if (upperLower == "Lower")
                            {
                                List<char> temp = new List<char>();

                                for (int i = startIndex; i < endIndex; i++)
                                {
                                    temp.Add(input[i]);
                                }
                                string tempString = string.Join("", temp);
                                tempString = tempString.ToLower();

                                input = input.Remove(startIndex, endIndex - startIndex);
                                input = input.Insert(startIndex, tempString);
                            }

                            Console.WriteLine(input);
                                break;
                        }

                    case "Slice":
                        {
                            int startIndex = int.Parse(commandsArr[1]);
                            int endIndex = int.Parse(commandsArr[2]);

                            input = input.Remove(startIndex, endIndex - startIndex);
                            Console.WriteLine(input);

                            break;
                        }
                }

                commands = Console.ReadLine();
                commandsArr = commands.Split(">>>");
            }

            Console.WriteLine($"Your activation key is: {input}");


        }
    }
}
