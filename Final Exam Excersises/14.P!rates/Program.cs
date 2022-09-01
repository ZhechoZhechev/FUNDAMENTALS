using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.P_rates
{
    class Cities 
    {
        public Cities(string name, int population, int gold )
        {
            Name = name;
            Population = population;
            Gold = gold;
        }
        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }
    }
    class Program
    {
        static void Main()
        {
            string cityInput = string.Empty;

            List<Cities> cities = new List<Cities>();

            while ((cityInput = Console.ReadLine()) != "Sail")
            {
                var citiesInfo = cityInput.Split("||");
                
                string cityName = citiesInfo[0];
                int cityPopulation = int.Parse(citiesInfo[1]);
                int cityGold = int.Parse(citiesInfo[2]);
                
                if (!cities.Any(x => x.Name == cityName))
                {
                    Cities city = new Cities(cityName, cityPopulation, cityGold);
                    cities.Add(city);
                }
                else if (cities.Any(x => x.Name == cityName))
                {
                    var curCity = cities.FirstOrDefault(x => x.Name == cityName);
                    
                    curCity.Population += cityPopulation;
                    curCity.Gold += cityGold;
                }
            }

            string actionInput = string.Empty;

            while ((actionInput = Console.ReadLine()) != "End")
            {
                var actionInfo = actionInput.Split("=>");
                
                string action = actionInfo[0];
                string town = actionInfo[1];

                var curTown = cities.FirstOrDefault(x => x.Name == town);

                switch (action)
                {
                   case "Plunder":
                        int peopleNum = int.Parse(actionInfo[2]);
                        int gold = int.Parse(actionInfo[3]);

                        curTown.Population -= peopleNum;
                        curTown.Gold -= gold;

                        Console.WriteLine($"{town} plundered! {gold} gold stolen, {peopleNum} citizens killed.");
                        
                        if (curTown.Population == 0 || curTown.Gold == 0)
                        {
                            Console.WriteLine($"{town} has been wiped off the map!");
                            cities.Remove(curTown);
                        }
                        break;
                    case "Prosper":
                        int goldToAdd = int.Parse(actionInfo[2]);

                        if (goldToAdd < 0)
                        {
                            Console.WriteLine("Gold added cannot be a negative number!");
                            continue;
                        }

                        curTown.Gold += goldToAdd;

                        Console.WriteLine($"{goldToAdd} gold added to the city treasury. {town} now has {curTown.Gold} gold.");
                        break;
                }
            }
            if (cities.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var city in cities)
                {
                    Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
        }
    }
}
