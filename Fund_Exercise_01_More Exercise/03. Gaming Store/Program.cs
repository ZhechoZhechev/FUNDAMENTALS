using System;

namespace _03._Gaming_Store
{
    class Program
    {
        static void Main()
        {
            double balance = double.Parse(Console.ReadLine());
            double moneySpend = 0;
            while (true)
            {
               string command = Console.ReadLine();
                if (command == "Game Time")
                {
                    break;
                }
                double gamePrice = 0;
                switch (command)
                {
                    case "OutFall 4": gamePrice = 39.99; break;
                    case "CS: OG": gamePrice = 15.99; break;
                    case "Zplinter Zell": gamePrice = 19.99; break;
                    case "Honored 2": gamePrice = 59.99; break;
                    case "RoverWatch": gamePrice = 29.99; break;
                    case "RoverWatch Origins Edition": gamePrice = 39.99; break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }
                if (gamePrice > balance)
                {
                    Console.WriteLine("Too Expensive");
                    continue;
                }
                Console.WriteLine($"Bought {command}");
                moneySpend += gamePrice;
                balance -= gamePrice;
                if (balance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }


            }
                Console.WriteLine($"Total spent: ${moneySpend:f2}. Remaining: ${balance:f2}");
        }
    }
}
