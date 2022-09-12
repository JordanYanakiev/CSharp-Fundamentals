using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+[A-Z][A-Za-z\d]{4,}[A-Z]@#+";
            int numberOfLines = int.Parse(Console.ReadLine());
            string input = null;

            for (int i = 0; i < numberOfLines; i++)
            {
                input = Console.ReadLine();

                Match match = Regex.Match(input, pattern);

                if (Regex.IsMatch(input, pattern))
                {
                    string barcode = string.Join("", match);
                    List<char> barcodeGroup = new List<char>();

                    foreach (char symbol in barcode)
                    {
                        if (char.IsDigit(symbol))
                        {
                            barcodeGroup.Add(symbol);
                        }
                    }

                    if (barcodeGroup.Count == 0)
                    {
                        Console.WriteLine($"Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: " + string.Join("", barcodeGroup));
                    }

                }
                else if (!Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("Invalid barcode");
                }

            }


        }
    }
}
