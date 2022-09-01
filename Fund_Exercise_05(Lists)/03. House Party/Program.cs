using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    class Program
    {
        static void Main()
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            var listOfNames = new List<string>();

            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commands = Console.ReadLine().Split();
                string currentName = commands[0];
                if (!listOfNames.Contains(currentName) && commands[2] == "going!" )
                {
                    listOfNames.Add(currentName);
                }
                else if (listOfNames.Contains(currentName) && commands[2] == "going!")
                {
                    Console.WriteLine($"{currentName} is already in the list!");
                }
                else if (commands[2] == "not" && listOfNames.Contains(currentName))
                {
                    listOfNames.Remove(currentName);
                }
                else if (commands[2] == "not" && !listOfNames.Contains(currentName))
                {
                    Console.WriteLine($"{currentName} is not in the list!");
                }
            }
            foreach (var name in listOfNames)
            {
                Console.WriteLine($"{name}");
            }
        }
    }
}
