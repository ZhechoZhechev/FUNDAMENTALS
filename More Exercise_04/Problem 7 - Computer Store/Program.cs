using System;

namespace Problem_7___Computer_Store
{
    class Program
    {
        static void Main()
        {
            double totalPriceWithoutTaxes = 0;
            string client = "";

            while (true)
            {
                client = Console.ReadLine();
                if (client == "regular" || client == "special") break;

                double prices = double.Parse(client);
                
                if (prices < 0)
                {
                    Console.WriteLine("Invalid price!");
                }
                else
                {
                    totalPriceWithoutTaxes += prices;
                }
            }
            
            if (totalPriceWithoutTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            
            double taxes = totalPriceWithoutTaxes * 0.20;
            double totalPriceWithTaxes = taxes + totalPriceWithoutTaxes;

            if (client == "special")
            {
               totalPriceWithTaxes *= 0.9;
            }
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPriceWithoutTaxes:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            Console.WriteLine($"Total price: {totalPriceWithTaxes:f2}$");
        }
    }
}
