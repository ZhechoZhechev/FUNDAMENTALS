using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_6___Heart_Delivery
{
    class Program
    {
        static void Main()
        {
            var theNeighborhood = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            string input = string.Empty;
            int currIndex = 0;
            int housesWithValsDay = 0;
            

            while ((input = Console.ReadLine()) != "Love!")
            {
                string[] commands = input.Split();
                int jumpIndex = int.Parse(commands[1]);


                if (currIndex + jumpIndex > theNeighborhood.Count - 1)
                {
                    currIndex = 0;
                    if (theNeighborhood[currIndex] == 0)
                    {
                        Console.WriteLine($"Place {currIndex} already had Valentine's day.");
                        continue;
                    }
                    theNeighborhood[currIndex] -= 2;
                }
                else
                {
                    currIndex += jumpIndex;
                    if (theNeighborhood[currIndex] == 0)
                    {
                        Console.WriteLine($"Place {currIndex} already had Valentine's day.");
                        continue;
                    }
                    theNeighborhood[currIndex] -= 2;
                }
                

                if (theNeighborhood[currIndex] == 0)
                {
                    Console.WriteLine($"Place {currIndex} has Valentine's day.");
                    housesWithValsDay++;
                }

            }
            Console.WriteLine($"Cupid's last position was {currIndex}.");
            TheOutCome(theNeighborhood, housesWithValsDay);

        }

        private static void TheOutCome(List<int> theNeighborhood, int housesWithValsDay)
        {
            int housesWithoutValsDay = theNeighborhood.Count - housesWithValsDay;
            if (theNeighborhood.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {housesWithoutValsDay} places.");
            }
        }
    }
}
