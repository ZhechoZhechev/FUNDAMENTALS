using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            double moneyAccumulated = 0;

            while (command != "Start")
            {
                double moneyInput = double.Parse(command);
                if (moneyInput == 0.1 || moneyInput == 0.2 || moneyInput == 0.5
                    || moneyInput == 1 || moneyInput == 2)
                {
                    moneyAccumulated += moneyInput;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {moneyInput}");
                }
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            double priceAccumulated = 0;
            while (command != "End")
            {
                switch (command)
                {
                    case "Nuts":
                        priceAccumulated = 2.0;
                        break;
                    case "Water":
                        priceAccumulated = 0.7;
                        break;
                    case "Crisps":
                        priceAccumulated = 1.5;
                        break;
                    case "Soda":
                        priceAccumulated = 0.8;
                        break;
                    case "Coke":
                        priceAccumulated = 1.0;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        command = Console.ReadLine();
                        continue;
                }
                if (moneyAccumulated >= priceAccumulated)
                {
                    moneyAccumulated -= priceAccumulated;
                    Console.WriteLine($"Purchased {command.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {moneyAccumulated:f2}");
        }
    }
}
