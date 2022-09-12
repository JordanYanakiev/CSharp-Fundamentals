using System;
using System.Text.RegularExpressions;

namespace _11.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
            Regex regex = new Regex(pattern);
            string input = "Bethany Taylor, Oliver miller, sophia Johnson, SARah Wilson, John Smith, Sam      Smith";
            MatchCollection validNames = regex.Matches(input);

            foreach (Match m in validNames)
            {
                Console.WriteLine("{0}", m.Value);
            }
        }
    }
}
