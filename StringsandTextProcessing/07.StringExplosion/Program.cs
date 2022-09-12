using System;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            int power = 0;
            char ch = ' ';


            for (int i = 0; i < inputString.Length; i++)
            {
                ch = inputString[i];

                if (power == 0 && ch != '>')
                {
                    if (!char.IsDigit(ch))
                    {
                        sb.Append(ch);
                    }
                    if (char.IsDigit(ch) && inputString[i - 1] != '>')
                    { sb.Append(ch); }
                }
                else if (power > 0 && ch != '>' && inputString[i - 1] != '>')
                {
                    power--;
                }

                if (ch == '>')
                {
                    sb.Append(ch);
                }
                else if (char.IsDigit(ch) && inputString[i - 1] == '>')
                {
                    power += int.Parse(ch.ToString());
                    power--;
                }

            }

            Console.WriteLine(sb);


        }
    }
}
