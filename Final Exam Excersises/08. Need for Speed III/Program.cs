using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Need_for_Speed_III
{
    class Program
    {
        class Cars 
        {
            public Cars(string name, int mileage, int fuel)
            {
                CarName = name;
                Mileage = mileage;
                Fuel = fuel;
            }
            public string CarName { get; set; }
            public int Mileage { get; set; }
            public int Fuel { get; set; }
        }
        static void Main()
        {
            int numOfCars = int.Parse(Console.ReadLine());

            List<Cars> carsCatalogue = new List<Cars>();

            for (int i = 0; i < numOfCars; i++)
            {
                var input = Console.ReadLine().Split("|");
                
                string carName = input[0];
                int mileage = int.Parse(input[1]);
                int fuel = int.Parse(input[2]);
                
                Cars car = new Cars(carName, mileage, fuel);
                carsCatalogue.Add(car);
            }

            string newInput = string.Empty;
            const int MILEAGE_TO_SELL = 100000;
            const int MAX_FUEL_IN_TANK = 75;
            
            while ((newInput = Console.ReadLine()) != "Stop")
            {
                var info = newInput.Split(" : ");
                string action = info[0];
                string car = info[1];

                var curCar = carsCatalogue.FirstOrDefault(x => x.CarName == car);

                switch (action)
                {
                    case "Drive":
                        int distance = int.Parse(info[2]);
                        int fuelNeeded = int.Parse(info[3]);

                        if (curCar.Fuel >= fuelNeeded)
                        {
                            curCar.Mileage += distance;
                            curCar.Fuel -= fuelNeeded;
                            Console.WriteLine($"{curCar.CarName} driven for {distance} kilometers. {fuelNeeded} liters of fuel consumed.");
                        }
                        else
                        {
                            Console.WriteLine("Not enough fuel to make that ride");
                        }
                        if (curCar.Mileage >= MILEAGE_TO_SELL)
                        {
                            Console.WriteLine($"Time to sell the {curCar.CarName}!");
                            carsCatalogue.Remove(curCar);
                        }
                        break;
                    case "Refuel":
                        int fuelToAdd = int.Parse(info[2]);
                        int fuelBeforeRefill = curCar.Fuel;
                        curCar.Fuel = Math.Min(curCar.Fuel + fuelToAdd, MAX_FUEL_IN_TANK);
                        int fuelAfterRefill = curCar.Fuel;
                        
                        Console.WriteLine($"{curCar.CarName} refueled with {fuelAfterRefill - fuelBeforeRefill} liters");
                        break;
                    case "Revert":
                        int killometersToRevert = int.Parse(info[2]);
                        curCar.Mileage = curCar.Mileage - killometersToRevert;
                        
                        if (curCar.Mileage <= 10000)
                        {
                            curCar.Mileage = 10000;
                        }
                        
                        else Console.WriteLine($"{car} mileage decreased by {killometersToRevert} kilometers");
                        break;
                }
            }
            foreach (var car in carsCatalogue)
            {
                Console.WriteLine($"{car.CarName} -> Mileage: {car.Mileage} kms, Fuel in the tank: {car.Fuel} lt.");
            }
        }
    }
}
