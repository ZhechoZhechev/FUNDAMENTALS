using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_16___Man_O_War
{
    class Program
    {
        static void Main()
        {
            var pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            var warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHealthPerSection = int.Parse(Console.ReadLine());

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Retire")
            {
                var commands = input.Split();
                string action = commands[0];

                switch (action)
                {
                    case "Fire":
                        if (IsWarShipSunken(warShip, commands)) 
                        {
                            Console.WriteLine("You won! The enemy ship has sunken.");
                            return;
                        }
                        break;
                    case "Defend":
                        if (IsPirateShipSunken(pirateShip, commands)) 
                        {
                            Console.WriteLine("You lost! The pirate ship has sunken.");
                            return;
                        }
                        break;
                    case "Repair":
                        RepairThePirateShip(pirateShip, commands, maxHealthPerSection);
                        break;
                    case "Status":
                        StatusOfPirateShipSections(pirateShip, commands, maxHealthPerSection);
                        break;
                }
            }
            Console.WriteLine($"Pirate ship status: {pirateShip.Sum()}");
            Console.WriteLine($"Warship status: {warShip.Sum()}");
        }

        private static void StatusOfPirateShipSections(List<int> pirateShip, string[] commands, int maxHealthPerSection)
        {
            double bellow20Percentage = (double)maxHealthPerSection / 5;
            int countOfSectionsThatNeedsRep = 0;
            for (int i = 0; i < pirateShip.Count; i++)
            {
                if (pirateShip[i] < bellow20Percentage) countOfSectionsThatNeedsRep++;
            }
                Console.WriteLine($"{countOfSectionsThatNeedsRep} sections need repair.");
        }

        private static void RepairThePirateShip(List<int> pirateShip, string[] commands, int maxHealthPerSection)
        {
            int indexToRep = int.Parse(commands[1]);
            int healtToAdd = int.Parse(commands[2]);
            if (indexToRep >= 0 && indexToRep <= pirateShip.Count - 1)
            {
                int sectionCurrHealth = pirateShip[indexToRep];
                int currHealthToAdd = Math.Min(maxHealthPerSection, sectionCurrHealth + healtToAdd);
                pirateShip[indexToRep] = currHealthToAdd;
            }
        }

        private static bool IsWarShipSunken(List<int> warShip, string[] commands)
        {
            int index = int.Parse(commands[1]);
            int damadge = int.Parse(commands[2]);
            if (index >= 0 && index <= warShip.Count - 1)
            {
                warShip[index] -= damadge;
                if (warShip[index] <= 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool IsPirateShipSunken(List<int> pirateShip, string[] commands)
        {
            int startIndex = int.Parse(commands[1]);
            int endIndex = int.Parse(commands[2]);
            int damage = int.Parse(commands[3]);

            if (startIndex >= 0 && endIndex >= 0 && startIndex <= pirateShip.Count - 1 && endIndex <= pirateShip.Count - 1)
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    pirateShip[i] -= damage;
                    if (pirateShip[i] <= 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
