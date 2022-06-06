using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            uint startingYeild = uint.Parse(Console.ReadLine());
            uint currentYield = startingYeild;
            int workingDaysCounter = 0;

            uint yieldVolume = 0;

            while (currentYield>=100)
            {
                yieldVolume += currentYield - 26;
                workingDaysCounter++;
                currentYield -= 10;
            }

            if (yieldVolume < 26)
            {
                Console.WriteLine(workingDaysCounter);
                Console.WriteLine(yieldVolume);
                return;

            }
            else
            {
                yieldVolume -= 26;

            }
            Console.WriteLine(workingDaysCounter);
            Console.WriteLine(yieldVolume);
        }
    }
}
