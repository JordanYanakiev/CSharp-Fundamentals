using System;
using System.Collections.Generic;

namespace _04.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());
            Dictionary<string, string> registeredCars = new Dictionary<string, string>();
            string[] commands = new string[] { };
            string name = null;
            string carPlate = null;

            for (int i = 0; i < numberOfOperations; i++)
            {
                commands = Console.ReadLine().Split();

                if (commands[0] == "register")
                {
                    name = commands[1];
                    carPlate = commands[2];
                    if (!registeredCars.ContainsKey(name))
                    {
                        registeredCars.Add(name, carPlate);
                        Console.WriteLine($"{name} registered {carPlate} successfully");
                    }
                    else if (registeredCars.ContainsKey(name))
                    {
                        string tempString;
                        registeredCars.TryGetValue(name, out tempString);
                        Console.WriteLine($"ERROR: already registered with plate number {tempString}");
                    }
                }
                else if (commands[0] == "unregister")
                {
                    name = commands[1];
                    if (registeredCars.ContainsKey(name))
                    {
                        registeredCars.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }
                    else if (!registeredCars.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                }
            }


            //Print Dictionary

            foreach (var carRegistration in registeredCars)
            {
                Console.WriteLine($"{carRegistration.Key} => {carRegistration.Value}");
            }



        }
    }
}
