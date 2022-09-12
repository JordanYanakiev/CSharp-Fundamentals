using System;
using System.Collections.Generic;

namespace _03.NeedForSpeed3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            string carInput = null;
            string commands = null;
            string[] cmndTokens = null;
            string[] carArr = null;
            Dictionary<string, int> carMileage = new Dictionary<string, int>();
            Dictionary<string, int> carFuel = new Dictionary<string, int>();

            for (int i = 1; i <= numberOfCars; i++)
            {
                carInput = Console.ReadLine();
                carArr = carInput.Split("|");
                string carModel = carArr[0];
                int carMiles = int.Parse(carArr[1]);
                int carFuelTank = int.Parse(carArr[2]);

                if (!carMileage.ContainsKey(carModel) && !carFuel.ContainsKey(carModel))
                {
                    carMileage.Add(carModel, carMiles);
                    carFuel.Add(carModel, carFuelTank);
                }
            }

            commands = Console.ReadLine();
            cmndTokens = commands.Split(" : ");

            while (cmndTokens[0] != "Stop")
            {
                string command01 = cmndTokens[0];

                switch(command01)
                {
                    case "Drive":
                        {
                            string carModel = cmndTokens[1];
                            int distance = int.Parse(cmndTokens[2]);
                            int fuel = int.Parse(cmndTokens[3]);


                            if (carFuel[carModel] >= fuel)
                            {
                                carMileage[carModel] += distance;
                                carFuel[carModel] -= fuel;
                                Console.WriteLine($"{carModel} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                            }
                            else
                            {
                                Console.WriteLine("Not enough fuel to make that ride");
                            }

                            if (carMileage[carModel] >= 100000)
                            {
                                Console.WriteLine($"Time to sell the {carModel}!");
                                carMileage.Remove(carModel);
                                carFuel.Remove(carModel);
                            }

                            break;
                        }

                    case "Refuel":
                        {
                            string carModel = cmndTokens[1];
                            int fuel = int.Parse(cmndTokens[2]);

                            if (carFuel[carModel] < 75)
                            {
                                int tempNum = 75 - carFuel[carModel];

                                if (tempNum < fuel)
                                {
                                    carFuel[carModel] += tempNum;
                                    Console.WriteLine($"{carModel} refueled with {tempNum} liters");
                                }
                                else if (tempNum >= fuel)
                                {
                                    carFuel[carModel] += fuel;
                                    Console.WriteLine($"{carModel} refueled with {fuel} liters");
                                }
                            }
                            break;
                        }

                    case "Revert":
                        {
                            string carModel = cmndTokens[1];
                            int distanceReverted = int.Parse(cmndTokens[2]);


                            int tempNum = carMileage[carModel] - distanceReverted;

                            if (tempNum >= 10000)
                            {
                                carMileage[carModel] -= distanceReverted;
                                Console.WriteLine($"{carModel} mileage decreased by {distanceReverted} kilometers");
                            }

                            if (tempNum < 10000)
                            {
                                carMileage[carModel] = 10000;
                            }
                                break;
                        }
                }
                commands = Console.ReadLine();
                cmndTokens = commands.Split(" : ");
            }

            //"{car} -> Mileage: {mileage} kms, Fuel in the tank: {fuel} lt."

            foreach (var car in carMileage)
            {
                string key = car.Key;
                var carFuelPrint = carFuel[key];
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value} kms, Fuel in the tank: {carFuelPrint} lt.");
            }


        }
    }
}
