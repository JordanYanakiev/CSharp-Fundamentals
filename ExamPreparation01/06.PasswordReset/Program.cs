using System;
using System.Collections.Generic;

namespace _06.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();
            string[] cmndTokens = command.Split();
            List<char> tempList = new List<char>();

            while (cmndTokens[0] != "Done")
            {
                switch (cmndTokens[0])
                {
                    case "TakeOdd":
                        {
                            for (int i = 0; i < input.Length; i++)
                            {
                                if (i % 2 != 0)
                                {
                                    tempList.Add(input[i]);
                                }
                            }

                            input = string.Join("", tempList);
                            Console.WriteLine(input);

                            break;
                        }

                    case "Cut":
                        {

                            int index = int.Parse(cmndTokens[1]);
                            int length = int.Parse(cmndTokens[2]);

                            input = input.Remove(index, length);
                            Console.WriteLine(input);

                            break;
                        }

                    case "Substitute":
                        {
                            string subString = cmndTokens[1];
                            string substitute = cmndTokens[2];

                            if (input.Contains(subString))
                            {
                                input = input.Replace(subString, substitute);
                                Console.WriteLine(input);
                            }
                            else
                            {
                                Console.WriteLine("Nothing to replace!");
                            }
                            

                            break;
                        }
                }


                command = Console.ReadLine();
                cmndTokens = command.Split();
            }

            Console.WriteLine($"Your password is: {input}");

        }
    }
}
