using System;
using System.Linq;
using System.Collections.Generic;

namespace _01.ValidUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputUsernames = Console.ReadLine().Split(", ");
            string username01 = inputUsernames[0];
            bool isValid = false;

            foreach (string name in inputUsernames)
            {
                if (name.Length >= 3 && name.Length <= 16)
                {
                    foreach (char letter in name)
                    {
                        if (!char.IsLetterOrDigit(letter) && letter != '-' && letter != '_')
                        {
                            isValid = false;
                            break;
                        }
                        else
                        {
                            isValid = true;
                        }
                    }

                    if (isValid)
                    {
                        Console.WriteLine(name);
                    }
                }
            }


        }
    }
}
