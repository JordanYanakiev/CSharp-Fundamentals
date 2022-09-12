using System;
using System.Collections.Generic;
using System.Linq;


namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var smth = Console.ReadLine().Split('|').Reverse().ToList();
            var numbers = new List<int>();
            foreach (var number in smth)
            {
                numbers.AddRange(number.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
