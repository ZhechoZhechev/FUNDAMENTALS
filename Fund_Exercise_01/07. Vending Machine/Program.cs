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
            while (command != "End")
            {
                switch (command)
                {
                    case "Nuts":
                        moneyAccumulated -= 2.0;
                        Console.WriteLine("Purchased Nuts");
                        break;
                    case "Water":
                        moneyAccumulated -= 0.7;
                        Console.WriteLine("Purchased Water");
                        break;
                    case "Crisps":
                        moneyAccumulated -= 1.5;
                        Console.WriteLine("Purchased Crisps");
                        break;
                    case "Soda":
                        moneyAccumulated -= 0.8;
                        Console.WriteLine("Purchased Soda");
                        break;
                    case "Coke":
                        moneyAccumulated -= 1.0;
                        Console.WriteLine("Purchased Coke");
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        continue;
                }
                command = Console.ReadLine();
                if (moneyAccumulated < 0.7)
                {
                    Console.WriteLine("Sorry, not enough money");
                    continue;
                }
            }
                Console.WriteLine($"Change: {moneyAccumulated}");
        }
    }
}
