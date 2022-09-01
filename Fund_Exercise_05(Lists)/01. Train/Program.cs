using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main()
        {
            var wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacityOfaWagon = int.Parse(Console.ReadLine());
            while (true)
            {
                string[] commands = Console.ReadLine().Split();
                if (commands[0] == "end")
                {
                    break;
                }
                if (commands[0] == "Add")
                {
                    int numberToAdd = int.Parse(commands[1]);
                    wagons.Add(numberToAdd);
                }
                if (commands.Length == 1)
                {
                    int PeopleToAdd = int.Parse(commands[0]);
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + PeopleToAdd <= maxCapacityOfaWagon)
                        {
                            wagons[i] += PeopleToAdd;
                            break;
                        }
                    }

                }
            }
                Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
