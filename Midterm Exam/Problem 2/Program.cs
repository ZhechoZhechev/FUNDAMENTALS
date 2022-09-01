using System;
using System.Linq;

namespace Problem_2
{
    class Program
    {
        static void Main()
        {
            var routeToTitan = Console.ReadLine().Split("||").ToList();
            int startingFuel = int.Parse(Console.ReadLine());
            int amountOfAmmunitions = int.Parse(Console.ReadLine());

            while (true)
            {
                string action = string.Empty;
                int integer = 0;
                for (int i = 0; i < routeToTitan.Count; i++)
                {
                    string[] commands = routeToTitan[i].ToString().Split();
                    if (commands.Length == 2)
                    {
                        action = commands[0];
                        integer = int.Parse(commands[1]);
                    }
                    else
                    {
                        action = commands[0];
                    }

                    switch (action)
                    {
                        case "Travel":
                            int fuelConsumped = integer;
                            if (fuelConsumped <= startingFuel)
                            {
                                startingFuel -= fuelConsumped;
                                Console.WriteLine($"The spaceship travelled {fuelConsumped} light-years.");
                            }
                            else
                            {
                                Console.WriteLine("Mission failed.");
                                return;
                            }
                            break;
                        case "Enemy":
                            int enemyArmor = integer;
                            if (amountOfAmmunitions >= enemyArmor)
                            {
                                amountOfAmmunitions -= enemyArmor;
                                Console.WriteLine($"An enemy with {enemyArmor} armour is defeated.");
                            }
                            else
                            {
                                if (startingFuel >= enemyArmor * 2)
                                {
                                    startingFuel -= enemyArmor * 2;
                                    Console.WriteLine($"An enemy with {enemyArmor} armour is outmaneuvered.");
                                }
                                else
                                {
                                    Console.WriteLine("Mission failed.");
                                    return;
                                }
                            }
                            break;
                        case "Repair":
                            int fuelAdded = integer;
                            int AmmoAdded = integer * 2;
                            startingFuel += fuelAdded;
                            amountOfAmmunitions += AmmoAdded;
                            Console.WriteLine($"Ammunitions added: {AmmoAdded}.");
                            Console.WriteLine($"Fuel added: {fuelAdded}.");
                            break;
                    }


                }
                if (action == "Titan")
                {
                    break;
                }
            }
            Console.WriteLine($"You have reached Titan, all passengers are safe.");
        }
    }
}
