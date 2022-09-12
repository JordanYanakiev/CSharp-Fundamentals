using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace _06.Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();


            while (true)
            {
                string[] inputArgs = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);

                if (inputArgs[0] == "End")
                {
                    break;
                }

                VehicleType vehicleType;
                bool isVehicleTypeParseSuccessful = Enum.TryParse(inputArgs[0], true, out vehicleType);

                if (isVehicleTypeParseSuccessful)
                {
                    string vehicleModel = inputArgs[1];
                    string vehicleColor = inputArgs[2];
                    int vehicleHorsepower = int.Parse(inputArgs[3]);

                    var curVehicle = new Vehicle(vehicleType, vehicleModel, vehicleColor, vehicleHorsepower);
                    vehicles.Add(curVehicle);
                }
            }



            while (true)
            {
                string cmds = Console.ReadLine();
                if (cmds == "Close the Catalogue")
                {
                    break;
                }

                var desiredVehicle = vehicles.FirstOrDefault(vehicle => vehicle.Model == cmds);
                Console.WriteLine(desiredVehicle);
            }

            var cars = vehicles.Where(vehicle => vehicle.Type == VehicleType.Car).ToList();
            var trucks = vehicles.Where(vehicle => vehicle.Type == VehicleType.Truck).ToList();

            double carsAvgHorsepower = cars.Count > 0 ? cars.Average(car => car.Horsepower) : 0.00;
            double trucksAvgHorsepower = trucks.Count > 0 ? trucks.Average(truck => truck.Horsepower) : 0.00;

            Console.WriteLine($"Cars have average horsepower of: {carsAvgHorsepower:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHorsepower:F2}.");

        }
    }


    enum VehicleType
    {
        Car,
        Truck
    }

    class Vehicle
    {
        public VehicleType Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public Vehicle(VehicleType type, string model, string color, int horsepower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsepower;
        }


        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Type: {Type}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Color: {Color}");
            sb.AppendLine($"Horsepower: {Horsepower}");

            return sb.ToString().TrimEnd();
        }
    }
}
