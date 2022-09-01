using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
        static void Main()
        {
            string regex = @">>(?<furType>[A-Za-z]+)<<(?<price>\d+\.?\d+)!(?<quantity>\d+)";

            string input = string.Empty;

            double totalSumSpent = 0;

            var furniture = new List<string>();

            while ((input = Console.ReadLine()) != "Purchase")
            {
                string furnitureToBuy = input;

                Match furnitureAndPrice = Regex.Match(furnitureToBuy, regex, RegexOptions.IgnoreCase);
                if (furnitureAndPrice.Success)
                {
                    string furType = string.Empty;
                    double price = 0;
                    int quantity = 0;
                    double totalPrice = 0;

                    furType = furnitureAndPrice.Groups["furType"].Value;
                    price = double.Parse(furnitureAndPrice.Groups["price"].Value);
                    quantity = int.Parse(furnitureAndPrice.Groups["quantity"].Value);

                    furniture.Add(furType);
                    totalPrice = quantity * price;
                    totalSumSpent += totalPrice;
                }
            }
            Console.WriteLine($"Bought furniture:");
            if (furniture.Count > 0)
            {
                Console.WriteLine($"{string.Join(Environment.NewLine, furniture)}");
            }
            Console.WriteLine($"Total money spend: {totalSumSpent:F2}");
        }
    }
}
