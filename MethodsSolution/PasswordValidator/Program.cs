using System;

namespace PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string passwordInput = Console.ReadLine();

            /*The password validation rules are:

            · It should contain 6 – 10 characters (inclusive)

            · It should contain only letters and digits

            · It should contain at least 2 digits

            If it is not valid, for any unfulfilled rule print the corresponding message:

            · "Password must be between 6 and 10 characters"

            · "Password must consist only of letters and digits"

            · "Password must have at least 2 digits" */


            bool check1 = LengthCheck(passwordInput);
            bool check2 = LettersAndNumbersCheck(passwordInput);
            bool check3 = DigitCounter(passwordInput);



            if (check1 == true && check2 == true && check3 == true)
            {
                Console.WriteLine("Password is valid");
            }
        }


        private static bool LengthCheck(string inputPassword)
        {
            char[] charPass = inputPassword.ToCharArray();

            if (charPass.Length < 6 || charPass.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }

            return true;
        }

        private static bool LettersAndNumbersCheck(string inputPassword)
        {
            char[] charPass = inputPassword.ToCharArray();

            foreach (char character in charPass)
            {
                if (!Char.IsDigit(character))
                {
                    if (!Char.IsLetter(character))
                    {
                        Console.WriteLine("Password must consist only of letters and digits");
                        return false;
                    }
                }
            }

            return true;
        }

        private static bool DigitCounter(string inputPassword)
        {
            char[] charPass = inputPassword.ToCharArray();
            int digitCounter = 0;

            foreach (char character in charPass)
            {
                if (Char.IsDigit(character))
                {
                    digitCounter++;
                }
            }

            if (digitCounter < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
