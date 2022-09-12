using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex mainPatternRgx = new Regex(@"%(?<name>[A-Z][a-z]+)%[^|$%.]*?<(?<order>[\w]+)>[^|$%.]*?\|(?<quantity>[\d]+)\|[^|$%.]*?(?<price>[\d]+.?[\d]+?)\$");
            double endOfShiftBallance = 0;

            while (input != "end of shift")
            {
                Match matchPattern = mainPatternRgx.Match(input);

                if (matchPattern.Success)
                {
                    MatchCollection match = mainPatternRgx.Matches(input);
                    int quantity = int.Parse(matchPattern.Groups["quantity"].Value);
                    double price = double.Parse(matchPattern.Groups["price"].Value.ToString());
                    double totalSum = quantity * price;
                    endOfShiftBallance += totalSum;
                    string name = matchPattern.Groups["name"].Value;
                    string order = matchPattern.Groups["order"].Value;
                    Console.WriteLine($"{name}: {order} - {totalSum:F2}");

                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {endOfShiftBallance:F2}");

        }
    }
}
