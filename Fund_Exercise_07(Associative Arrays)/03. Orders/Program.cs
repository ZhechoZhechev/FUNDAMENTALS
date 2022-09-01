using System;
using System.Collections.Generic;

namespace _03._Orders
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, double> productByPrice = new Dictionary<string, double>();
            Dictionary<string, double> productByQuntity = new Dictionary<string, double>();

            string input = string.Empty;
            
            while ((input = Console.ReadLine()) != "buy")
            {
                string[] productInfo = input.Split();
                string product = productInfo[0];
                double price = double.Parse(productInfo[1]);
                double quantity = double.Parse(productInfo[2]);
                
                if (!productByPrice.ContainsKey(product))
                {
                    productByPrice.Add(product, price);
                    productByQuntity.Add(product, quantity);
                }
                else
                {
                    productByPrice[product] = price;
                    productByQuntity[product] += quantity;
                }
            }
            foreach (var (product, quantity) in productByQuntity)
            {
                double price = productByPrice[product];
                double totalPrice = price * quantity;

                Console.WriteLine($"{product} -> {totalPrice:f2}");
            }
        }
    }
}
