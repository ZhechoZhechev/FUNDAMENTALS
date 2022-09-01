using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_3___Moving_Target
{
    class Program
    {
        static void Main()
        {
            var sequenceOfTargets = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = "";

            while ((input = Console.ReadLine()) != "End")
            {
                string[] commands = input.Split();
                string action = commands[0];

                switch (action)
                {
                    case "Shoot":
                        ShootTheTarget(commands, sequenceOfTargets);
                        break;
                    case "Add":
                        AddAtraget(commands, sequenceOfTargets);
                        break;
                    case "Strike":
                        StrikeTheTarget(commands, sequenceOfTargets);
                        break;
                }
            }
            Console.WriteLine(string.Join("|", sequenceOfTargets));
        }

        private static void StrikeTheTarget(string[] commands, List<int> sequenceOfTargets)
        {
            int index = int.Parse(commands[1]);
            int radius = int.Parse(commands[2]);
            int startOfBlast = index - radius;
            int endOfBlast = index + radius;
            if (startOfBlast < 0 || endOfBlast > sequenceOfTargets.Count - 1)
            {
                Console.WriteLine("Strike missed!");
            }
            else
            {
                sequenceOfTargets.RemoveRange(startOfBlast, (radius * 2) + 1);
            }
        }

        private static void AddAtraget(string[] commands, List<int> sequenceOfTargets)
        {
            int index = int.Parse(commands[1]);
            int value = int.Parse(commands[2]);
            if (index >= 0 && index <= sequenceOfTargets.Count - 1)
            {
                sequenceOfTargets.Insert(index, value);
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }
        }

        private static void ShootTheTarget(string[] commands, List<int> sequenceOfTargets)
        {
            int index = int.Parse(commands[1]);
            int power = int.Parse(commands[2]);
            if (index <= sequenceOfTargets.Count - 1 && index >= 0)
            {
                sequenceOfTargets[index] -= power;
                if (sequenceOfTargets[index] <= 0)
                {
                    sequenceOfTargets.RemoveAt(index);
                }
            }
        }
    }
}
