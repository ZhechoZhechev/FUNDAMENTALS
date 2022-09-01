using System;
using System.Linq;

namespace Problem_15___Shopping_List
{
    class Program
    {
        static void Main()
        {
            var shopingList = Console.ReadLine().Split("!").ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Go Shopping!")
            {
                var commands = input.Split();
                string action = commands[0];

                switch (action)
                {
                    case "Urgent":
                        string itemToAdd = commands[1];
                        
                        if (!shopingList.Contains(itemToAdd)) shopingList.Insert(0, itemToAdd);
                        break;
                    case "Unnecessary":
                        string itemToRemove = commands[1];

                        if (shopingList.Contains(itemToRemove)) shopingList.Remove(itemToRemove);
                        break;
                    case "Correct":
                        string oldItem = commands[1];
                        string newItem = commands[2];

                        if (shopingList.Contains(oldItem))
                        {
                            int oldItemIndex =  shopingList.IndexOf(oldItem);
                            shopingList.RemoveAt(oldItemIndex);
                            shopingList.Insert(oldItemIndex, newItem);
                        }
                        break;
                    case "Rearrange":
                        string itemToRearrange = commands[1];
                        if (shopingList.Contains(itemToRearrange))
                        {
                            shopingList.Remove(itemToRearrange);
                            shopingList.Add(itemToRearrange);
                        }
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", shopingList));
        }
    }
}
