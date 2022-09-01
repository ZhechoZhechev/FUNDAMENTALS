using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_14___Treasure_Hunt
{
    class Program
    {
        static void Main()
        {
            var chestContains = Console.ReadLine().Split("|").ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Yohoho!")
            {
                var commands = input.Split().ToList();
                string action = commands[0];

                switch (action)
                {
                    case "Loot":
                        PickupTheLoot(chestContains, commands);
                        break;
                    case "Drop":
                        DropSomeLoot(chestContains, commands);
                        break;
                    case "Steal":
                        StealSomeLoot(chestContains, commands);
                        break;
                }
            }
            if (chestContains.Count != 0)
            {
                double sum = 0;
                foreach (var item in chestContains)
                {
                    sum += item.Length;
                }
                double averageGain = sum / chestContains.Count;
                Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }

        private static void StealSomeLoot(List<string> chestContains, List<string> commands)
        {
            int countToSteal = int.Parse(commands[1]);
            List<string> steal = new List<string>();
            if (countToSteal < chestContains.Count)
            {
                for (int i = chestContains.Count - countToSteal; i < chestContains.Count; i++)
                {
                    steal.Add(chestContains[i]);
                }
                Console.WriteLine(string.Join(", ", steal));

                chestContains.RemoveRange(chestContains.Count - countToSteal, countToSteal);
            }

            else
            {
                for (int i = 0; i < chestContains.Count; i++)
                {
                    steal.Add(chestContains[i]);
                }
                Console.WriteLine(string.Join(", ", steal));

                chestContains.RemoveRange(0, chestContains.Count);
            }

        }

        private static void DropSomeLoot(List<string> chestContains, List<string> commands)
        {
            int index = int.Parse(commands[1]);
            if (index >= 0 && index <= chestContains.Count - 1)
            {
                string temp = chestContains[index];
                chestContains.RemoveAt(index);
                chestContains.Add(temp);
            }
        }

        private static void PickupTheLoot(List<string> chestContains, List<string> commands)
        {
            for (int i = 1; i < commands.Count; i++)
            {
                if (!chestContains.Contains(commands[i]))
                {
                    chestContains.Insert(0, commands[i]);
                }
            }
        }
    }
}            //int startIndex = Math.Max(0, chestContains.Count - countToSteal);
            //int endIndex = Math.Min(chestContains.Count -1, startIndex + countToSteal);
            //List<string> steal = new List<string>();

            //for (int item = startIndex; item <= endIndex; item++)
            //{
            //    steal.Add(chestContains[item]);
            //}
            //chestContains.RemoveRange(startIndex, countToSteal);
            //Console.WriteLine(string.Join(", ", steal));
            //steal.Clear();
