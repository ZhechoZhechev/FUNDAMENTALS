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

                MatchCollection furnitureAndPrice = Regex.Matches(furnitureToBuy, regex);
                if (furnitureAndPrice.Count > 0)
                {
                    string furType = string.Empty;
                    double price = 0;
                    int quantity = 0;
                    double totalPrice = 0;
                    foreach (Match item in furnitureAndPrice)
                    {
                        furType = item.Groups["furType"].ToString();
                        price = double.Parse(item.Groups["price"].ToString());
                        quantity = int.Parse(item.Groups["quantity"].ToString());
                    }
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
