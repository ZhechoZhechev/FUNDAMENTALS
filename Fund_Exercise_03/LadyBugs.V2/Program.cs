using System;
using System.Linq;

namespace LadyBugs.V2
{
    class Program
    {
        static void Main()
        {
            int sizeOfField = int.Parse(Console.ReadLine());
            int[] initialIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] field = new int[sizeOfField];

            for (int i = 0; i < initialIndexes.Length; i++)
            {
                int currentIndex = initialIndexes[i];
                if (currentIndex >= 0 && currentIndex < sizeOfField)
                {
                    field[currentIndex] = 1;
                }
            }

            string command = string.Empty;
                while ((command = Console.ReadLine()) != "end")
            {
                string[] elements = command.Split().ToArray();
                int ladybugIndex = int.Parse(elements[0]);
                string direction = elements[1];
                int flightLenght = int.Parse(elements[2]);

                if (ladybugIndex < 0 || ladybugIndex > field.Length - 1 || field[ladybugIndex] == 0) // 0 right 1
                {
                    continue;
                }

                field[ladybugIndex] = 0;

                if (direction == "right")
                {
                    int landingIndex = ladybugIndex + flightLenght;
                    if (landingIndex > field.Length - 1)
                    {
                        continue;
                    }
                    if (field[landingIndex] == 1)
                    {
                        while (field[landingIndex] == 1)
                        {
                            landingIndex += flightLenght;
                            if (landingIndex > field.Length - 1)
                            {
                                break;
                            }
                        }
                    }
                    if (landingIndex >= 0 && landingIndex <= field.Length -1)
                    {
                        field[landingIndex] = 1;
                    }
                }
                else if (direction == "left")
                {
                    int landingIndex = ladybugIndex - flightLenght;
                    if (landingIndex < 0)
                    {
                        continue;
                    } 
                    if (field[landingIndex] == 1)
                    {
                        while (field[landingIndex] == 1)
                        {
                            landingIndex -= flightLenght;
                            if (landingIndex < 0)
                            {
                                break;
                            }
                        }
                    }
                    if (landingIndex >= 0 && landingIndex <= field.Length - 1)
                    {
                        field[landingIndex] = 1;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", field));
        }
    }
}
