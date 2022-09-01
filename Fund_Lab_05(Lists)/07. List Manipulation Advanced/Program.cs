using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Advanced
{
    class Program
    {
        static void Main()
        {
            List<int> ListOne = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
            bool isListOneChanged = false;

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
                        isListOneChanged = true;
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        ListOne.Remove(numberToRemove);
                        isListOneChanged = true;
                        break;
                    case "RemoveAt":
                        int index = int.Parse(tokens[1]);
                        ListOne.RemoveAt(index);
                        isListOneChanged = true;
                        break;
                    case "Insert":
                        int numToInsert = int.Parse(tokens[1]);
                        int insertIndex = int.Parse(tokens[2]);
                        ListOne.Insert(insertIndex, numToInsert);
                        isListOneChanged = true;
                        break;
                    case "Contains":
                        int numIfContain = int.Parse(tokens[1]);
                        CheckIfcontainNumber(numIfContain, ListOne);
                        break;
                    case "PrintEven":
                        PrintEvenNums(ListOne);
                        break;
                    case "PrintOdd":
                        PrinOddNums(ListOne);
                        break;
                    case "GetSum":
                        int sum = ListOne.Sum();
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = tokens[1];
                        int numToCheck = int.Parse(tokens[2]);
                        CheckTheNumbers(condition, numToCheck, ListOne);
                        break;
                }
            }
            if(isListOneChanged) Console.WriteLine(string.Join(" ", ListOne));
        }

        private static void CheckTheNumbers(string condition, int numToCheck, List<int> listOne)
        {
            switch (condition)
            {
                case "<":
                    foreach (int number in listOne)
                    {
                        if (number < numToCheck) Console.Write($"{number} ");
                    }
                    break;
                case ">":
                    foreach (int number in listOne)
                    {
                        if (number > numToCheck) Console.Write($"{number} ");
                    }
                    break;
                case ">=":
                    foreach (int number in listOne)
                    {
                        if (number >= numToCheck) Console.Write($"{number} ");
                    }
                    break;
                case "<=":
                    foreach (int number in listOne)
                    {
                        if (number <= numToCheck) Console.Write($"{number} ");
                    }
                    break;
            }
            Console.WriteLine();
        }

        private static void PrinOddNums(List<int> listOne)
        {
            foreach (int number in listOne)
            {
                if (number % 2 != 0) Console.Write($"{number} ");

            }
            Console.WriteLine();
        }

        private static void PrintEvenNums(List<int> listOne)
        {
            foreach (int number in listOne)
            {
                if (number % 2 == 0) Console.Write($"{number} ");

            }
            Console.WriteLine();
        }

        private static void CheckIfcontainNumber(int numIfContain, List<int> ListOne)
        {
            if (ListOne.Contains(numIfContain))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
    }
}
