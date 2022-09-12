using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int passengers = int.Parse(Console.ReadLine());
            int elevatorCapacity = int.Parse(Console.ReadLine());
            int leftOverPassengers = 0;

            int numberOfPasses = (int) Math.Ceiling((double) passengers / elevatorCapacity);
            leftOverPassengers = passengers % elevatorCapacity;

            Console.WriteLine(numberOfPasses);
        }
    }
}
