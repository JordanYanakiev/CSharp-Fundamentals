using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string inputPassword = null;
            string password = null;
            int attempts = 0;

            char[] reverseUsername = username.ToCharArray();
            Array.Reverse(reverseUsername);
            password = new string(reverseUsername);

            while (true)
            {
                inputPassword = Console.ReadLine();
               
                if (inputPassword == password)
                {
                    Console.WriteLine("User {0} logged in.", username);
                    break;
                }

                attempts++;
                if (attempts == 4)
                {
                    Console.WriteLine("User {0} blocked!", username);
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
            }
        }
    }
}
