using System;

namespace _01.Hogwarts
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] commandStringArr = Console.ReadLine().Split();

            while (commandStringArr[0] != "Abracadabra")
            {
                string command = commandStringArr[0];

                switch (command)
                {
                    case "Abjuration":
                        {
                            input = input.ToUpper();
                            Console.WriteLine(input);
                            break;
                        }

                    case "Necromancy":
                        {
                            input = input.ToLower();
                            Console.WriteLine(input);
                            break;
                        }

                    case "Illusion":
                        {
                            int index = int.Parse(commandStringArr[1]);
                            string replacementChar = commandStringArr[2];

                            if (index < 0 || index >= input.Length)
                            {
                                Console.WriteLine("The spell was too weak.");
                            }
                            else if (index >= 0 && index < input.Length)
                            { 
                            input = input.Remove(index, 1);
                            input = input.Insert(index, replacementChar);
                            Console.WriteLine("Done!");
                            }
                            break;
                        }

                    case "Divination":
                        {
                            string firstSubstring = commandStringArr[1];
                            string secondSubstring = commandStringArr[2];


                            if (input.Contains(firstSubstring))
                            {
                                while (input.Contains(firstSubstring))
                                {
                                    input = input.Replace(firstSubstring, secondSubstring);
                                }
                                Console.WriteLine(input);
                            }
                            break;
                        }

                    case "Alteration":
                        {
                            string stringToRemove = commandStringArr[1];

                            if (input.Contains(stringToRemove))
                            {
                                input = input.Remove(input.IndexOf(stringToRemove), stringToRemove.Length);
                                Console.WriteLine(input);
                            }
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("The spell did not work!");
                            break;
                        }
                }




                commandStringArr = Console.ReadLine().Split();
            }
        }
    }
}
