using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main()
        {
            var intigers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split();
                string action = commands[0];
                
                if (action == "End") break;
               
                if (action == "Add") intigers.Add(int.Parse(commands[1]));

                if (action == "Insert") 
                {
                    if (int.Parse(commands[2]) > intigers.Count - 1 || int.Parse(commands[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    intigers.Insert(int.Parse(commands[2]), int.Parse(commands[1]));
                }

                if (action == "Remove") 
                {
                    if (int.Parse(commands[1]) > intigers.Count - 1 || int.Parse(commands[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    intigers.RemoveAt(int.Parse(commands[1]));
                } 

                if (action == "Shift")
                {
                    ShiftingTheNumbers(intigers, commands[1], commands[2]);
                }
            }
            Console.WriteLine(string.Join(" ", intigers));
        }

        private static void ShiftingTheNumbers(List<int> intigers, string direction, string count)
        {
            int countNum = int.Parse(count);
            if (direction == "left")
            {
                for (int i = 0; i < countNum; i++)
                {
                    intigers.Add(intigers[0]);
                    intigers.RemoveAt(0);
                }
            }
            else if (direction == "right")
            {
                for (int i = 0; i < countNum; i++)
                {
                    intigers.Insert(0, intigers[intigers.Count - 1]);
                    intigers.RemoveAt(intigers.Count - 1);
                }
            }
        }
    }
}
