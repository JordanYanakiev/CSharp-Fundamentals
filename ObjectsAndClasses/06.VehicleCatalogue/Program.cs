using System;
using System.Linq;
using System.Collections.Generic;


namespace _06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> commands = Console.ReadLine().Split(" ").ToList();
            List<Vehicle> vehicles = new List<Vehicle>();
            int trucksCounter = 0;
            int carsCounter = 0;
            double averageTrucksHorsePower = 0;
            double averageCarsHorsePower = 0;
            double totalTrucksHorsepower = 0;
            double totalCarsHorsepower = 0;
            string type = null;
            string model = null;
            string color = null;
            int horsePower = 0;

            //Create vehicles
            while (commands[0] != "End")
            {
                type = commands[0];
                model = commands[1];
                color = commands[2];
                horsePower = int.Parse(commands[3]);
                Vehicle newVehicle = new Vehicle((char.ToUpper(type[0]) + type.Substring(1)), model, color, horsePower);
                vehicles.Add(newVehicle);
                commands = Console.ReadLine().Split(" ").ToList();
            }

            //commands = Console.ReadLine().Split(" ").ToList();
            string input = Console.ReadLine();

            while (input != "Close the Catalogue")
            {


                var desiredVehicle = vehicles.FirstOrDefault(vehicle => vehicle.Model == input);


                foreach (Vehicle vehicle in vehicles)
                {
                    if (vehicle.Model == input && vehicle.Type == "Truck")
                    {
                        Console.WriteLine("Type: " + vehicle.Type);
                        Console.WriteLine("Model: " + vehicle.Model);
                        Console.WriteLine("Color: " + vehicle.Color);
                        Console.WriteLine("Horsepower: " + vehicle.Horsepower);
                    }
                    else if (vehicle.Model == input && vehicle.Type == "Car")
                    {
                        Console.WriteLine("Type: " + vehicle.Type);
                        Console.WriteLine("Model: " + vehicle.Model);
                        Console.WriteLine("Color: " + vehicle.Color);
                        Console.WriteLine("Horsepower: " + vehicle.Horsepower);
                    }

                    if (vehicle.Type == "Car")
                    {
                        carsCounter++;
                        totalCarsHorsepower += vehicle.Horsepower;
                    }

                    if (vehicle.Type == "Truck")
                    {
                        trucksCounter++;
                        totalTrucksHorsepower += vehicle.Horsepower;
                    }

                }
                //commands = Console.ReadLine().Split(" ").ToList();
                input = Console.ReadLine();
            }

            averageCarsHorsePower = totalCarsHorsepower / carsCounter;
            Console.WriteLine($"Cars have average horsepower of: {averageCarsHorsePower:F2}.");

            averageTrucksHorsePower = totalTrucksHorsepower / trucksCounter;
            Console.WriteLine($"Trucks have average horsepower of: {averageTrucksHorsePower:F2}.");

        }
    }


    class Vehicle
    {
        public string Type { get; set; }
        public string Model { get; set; }
        public string  Color { get; set; }
        public int Horsepower { get; set; }

        public Vehicle(string typeOfVehicle, string modelOfVehicle, string color, int horsepower)
        {
            Type = typeOfVehicle;
            Model = modelOfVehicle;
            Color = color;
            Horsepower = horsepower;
        }
    }
}
