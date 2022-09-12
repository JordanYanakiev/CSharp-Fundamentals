using System;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputstring = Console.ReadLine();
            char[] newString = new char[inputstring.Length] ;


            for (int i = 0; i < inputstring.Length; i++)
            {
                int asciiCode = inputstring[i] + 3;
                newString[i] = Convert.ToChar(asciiCode);
            }

            Console.WriteLine(string.Join("", newString));

        }
    }
}
