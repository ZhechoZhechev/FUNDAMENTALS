using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main()
        {

            string input = string.Empty;

            Dictionary<string, int> resourcesByQuantity = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "stop")
            {
                string resourceType = input;
                int quantity = int.Parse(Console.ReadLine());

                if (!resourcesByQuantity.ContainsKey(resourceType))
                {
                    resourcesByQuantity.Add(resourceType, quantity);
                }
                else
                {
                    resourcesByQuantity[resourceType] += quantity;
                }
            }
            foreach (var resource in resourcesByQuantity)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
