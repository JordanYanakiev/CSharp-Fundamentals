using System;
using System.Linq;

namespace _01.SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string concealedMessage = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Reveal")
            {
                string[] cmdTokens = command.Split(":|:");

                switch (cmdTokens[0])
                {
                    case "InsertSpace":
                        {
                            int index = int.Parse(cmdTokens[1]);
                            concealedMessage = concealedMessage.Insert(index, " ");
                            Console.WriteLine(concealedMessage);
                            break;
                        }

                    case "Reverse":
                        {
                            string comapareString = cmdTokens[1];

                            if (concealedMessage.Contains(comapareString))
                            {
                                int startIndex = concealedMessage.IndexOf(comapareString);
                                concealedMessage = concealedMessage.Remove(concealedMessage.IndexOf(comapareString), comapareString.Length);
                                //comapareString.Reverse();
                                concealedMessage = concealedMessage + string.Join("", comapareString.Reverse());
                                Console.WriteLine(concealedMessage);
                            }
                            else if (!concealedMessage.Contains(comapareString))
                            {
                                Console.WriteLine("error");
                                break;
                            }
                            break;
                        }

                    case "ChangeAll":
                        {
                            string sampleString = cmdTokens[1];
                            string replacement = cmdTokens[2];

                            concealedMessage = concealedMessage.Replace(sampleString, replacement);
                            Console.WriteLine(concealedMessage);
                            break;
                        }
                }
                //Console.WriteLine(concealedMessage);
                command = Console.ReadLine();
            }

            Console.WriteLine("You have a new text message: " + concealedMessage);

        }
    }
}
