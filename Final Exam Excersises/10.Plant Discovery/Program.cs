using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Plant_Discovery
{
    class Program
    {
        class Plants
        {
            public string Name { get; set; }
            public int Rarity { get; set; }
            public List<int> Rating { get; set; }
        }
        static void Main()
        {
            int plantsNum = int.Parse(Console.ReadLine());

            List<Plants> plants = new List<Plants>();

            for (int i = 0; i < plantsNum; i++)
            {
                var info = Console.ReadLine().Split("<->");

                string plantName = info[0];
                int rarity = int.Parse(info[1]);
                Plants plant = new Plants()
                {
                    Name = plantName,
                    Rarity = rarity,
                    Rating = new List<int>()
                };

                plants.Add(plant);
            }

            string newInput = string.Empty;
            //string separator = ": " + " - ";
            while ((newInput = Console.ReadLine()) != "Exhibition")
            {
                var newInfo = newInput.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string action = newInfo[0];

                var commands = newInfo[1].Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string plant = commands[0];
                
                var curPlant = plants.FirstOrDefault(x => x.Name == plant);

                if (!plants.Any(x => x.Name == plant))
                {
                    Console.WriteLine("error");
                    continue;
                }
                switch (action)
                {
                    case "Rate":
                        int rating = int.Parse(commands[1]);
                        curPlant.Rating.Add(rating);
                        break;
                    case "Update":
                        int newRarity = int.Parse(commands[1]);
                        curPlant.Rarity = newRarity;
                        break;
                    case "Reset":
                        curPlant.Rating.Clear();
                        break;
                }
            }
            Console.WriteLine("Plants for the exhibition:");
            
            foreach (var plant in plants)
            {
                
                if (plant.Rating.Count > 0)
                {
                Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: {plant.Rating.Average():f2}");
                }
                else
                {
                    Console.WriteLine($"- {plant.Name}; Rarity: {plant.Rarity}; Rating: 0.00");
                }
            }
        }
    }
}
