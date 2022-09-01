using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    class Catalogue
    {
        public Catalogue()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Catalogue catalogue = new Catalogue();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                var data = input.Split("/").ToList();

                string typeVehicle = data[0];

                switch (typeVehicle)
                {
                    case "Car":
                        Car car = new Car(data[1], data[2], int.Parse(data[3]));
                        catalogue.Cars.Add(car);
                        break;
                    case "Truck":
                        Truck truck = new Truck(data[1], data[2], int.Parse(data[3]));
                        catalogue.Trucks.Add(truck);
                        break;
                }
            }
            catalogue.Cars.Sort((x, y) => string.Compare(x.Brand, y.Brand));
            catalogue.Trucks.Sort((x, y) => string.Compare(x.Brand, y.Brand));
            //List<Car> orderedCars = catalogue.Cars.OrderBy(c => c.Brand).ToList();
            //List<Truck> orderedTrucks = catalogue.Trucks.OrderBy(c => c.Brand).ToList();

            if (catalogue.Cars.Count > 0)
            {
                Console.WriteLine($"Cars: ");
                foreach (var car in catalogue.Cars)
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalogue.Trucks.Count > 0)
            {
                Console.WriteLine($"Trucks: ");
                foreach (var truck in catalogue.Trucks)
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }
    }
}
