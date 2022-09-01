using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main()
        {
            List<int> ListOne = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

            while (true)
            {
                string commands = Console.ReadLine();
                if (commands == "end")
                {
                    break;
                }
                string[] tokens = commands.Split();
                switch (tokens[0])
                {
                    case "Add":
                        int numberToAdd = int.Parse(tokens[1]);
                        ListOne.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        ListOne.Remove(numberToRemove);
                        break;
                    case"RemoveAt":
                        int index = int.Parse(tokens[1]);
                        ListOne.RemoveAt(index);
                            break;
                    case"Insert":
                        int numToInsert = int.Parse(tokens[1]);
                        int insertIndex = int.Parse(tokens[2]);
                        ListOne.Insert(insertIndex, numToInsert);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", ListOne));
        }
    }
}
