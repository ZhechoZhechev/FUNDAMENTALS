using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main()
        {
            List<VehicleCatalogue> catalogue = new List<VehicleCatalogue>();

            int trucksTotalHP = 0;
            int totalTrucksCount = 0;
            int carsTotalHP = 0;
            int totalCarsCount = 0;

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] carInfo = input.Split();

                VehicleCatalogue vehicle = new VehicleCatalogue(carInfo[0], carInfo[1], carInfo[2], int.Parse(carInfo[3]));

                if (carInfo[0] == "car")
                {
                    carsTotalHP += int.Parse(carInfo[3]);
                    totalCarsCount++;
                }
                else
                {
                    trucksTotalHP += int.Parse(carInfo[3]);
                    totalTrucksCount++;
                }

                catalogue.Add(vehicle);
            }

            while ((input = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (var veh in catalogue.Where(x => x.Model == input))
                {
                    Console.WriteLine(veh);
                }
            }

            if (totalCarsCount == 0) Console.WriteLine("Cars have average horsepower of: 0.00.");

            else 
            {
                double carsAverageHP = carsTotalHP / (double)totalCarsCount;
                Console.WriteLine($"Cars have average horsepower of: {carsAverageHP:f2}.");
            }

            if (totalTrucksCount == 0) Console.WriteLine("Trucks have average horsepower of: 0.00.");

            else 
            {
                double trucksAverageHP = trucksTotalHP / (double)totalTrucksCount;
                Console.WriteLine($"Trucks have average horsepower of: {trucksAverageHP:f2}.");
            } 

        }
    }

    class VehicleCatalogue
    {
        public VehicleCatalogue(string type, string model, string colour, int horsePower)
        {
            TypeOfVehicle = type;
            Model = model;
            Colour = colour;
            HorsePower = horsePower;

        }
        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public int HorsePower { get; set; }

        public override string ToString()
        {
            return $"Type: {char.ToUpper(TypeOfVehicle[0]) + TypeOfVehicle.Substring(1)}{Environment.NewLine}Model: {Model}{Environment.NewLine}" +
                $"Color: {Colour}{Environment.NewLine}Horsepower: {HorsePower}";


        }
    }
}
