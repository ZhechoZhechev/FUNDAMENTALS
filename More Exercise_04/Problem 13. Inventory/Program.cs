using System;
using System.Linq;

namespace Problem_13._Inventory
{
    class Program
    {
        static void Main()
        {
            var inventory = Console.ReadLine().Split(", ").ToList();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Craft!")
            {
                string[] commands = input.Split(" - ");
                string action = commands[0];

                switch (action)
                {
                    case "Collect":
                        string item = commands[1];
                        
                        if (inventory.Contains(item)) continue;
                        else inventory.Add(item);
                        break;
                    case "Drop":
                        string itemToDrop = commands[1];

                        if (inventory.Contains(itemToDrop)) inventory.Remove(itemToDrop); ;
                        break;
                    case "Combine Items":
                        string[] items = commands[1].Split(":");
                        string oldItem = items[0];
                        string newItem = items[1];

                        if (inventory.Contains(oldItem)) 
                        {
                            int indexOfOldItem = inventory.IndexOf(oldItem);
                            
                            if (indexOfOldItem < inventory.Count - 1)
                            {
                                inventory.Insert(indexOfOldItem + 1, newItem);
                            }
                            else
                            {
                                inventory.Add(newItem);
                            }
                        }
                        break;
                    case "Renew":
                        string itemToRnew = commands[1];
                        
                        if (inventory.Contains(itemToRnew))
                        {
                            inventory.Remove(itemToRnew);
                            inventory.Add(itemToRnew);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
