using System;
using System.Linq;

namespace Problem_10___Memory_game
{
    class Program
    {
        static void Main()
        {
            var sequenceOfElements = Console.ReadLine().Split().ToList();

            string input = string.Empty;
            int movesCounter = 0;

            while ((input = Console.ReadLine()) != "end")
            {

                string[] indexes = input.Split();
                int indexOne = int.Parse(indexes[0]);
                int indexTwo = int.Parse(indexes[1]);
                movesCounter++;

                if (indexOne >= 0 && indexTwo >= 0 && indexOne < sequenceOfElements.Count && indexTwo < sequenceOfElements.Count && indexOne != indexTwo)
                {
                    if (sequenceOfElements[indexOne] == sequenceOfElements[indexTwo])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {sequenceOfElements[indexOne]}!");

                        if (indexOne > indexTwo)
                        {
                            sequenceOfElements.RemoveAt(indexOne);
                            sequenceOfElements.RemoveAt(indexTwo);
                        }
                        else
                        {
                            sequenceOfElements.RemoveAt(indexTwo);
                            sequenceOfElements.RemoveAt(indexOne);
                        }
                    }
                    else if (sequenceOfElements[indexOne] != sequenceOfElements[indexTwo])
                    {
                        Console.WriteLine("Try again!");
                    }
                    if (sequenceOfElements.Count == 0)
                    {
                        Console.WriteLine($"You have won in {movesCounter} turns!");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    sequenceOfElements.Insert(sequenceOfElements.Count / 2 ,$"-{movesCounter}a");
                    sequenceOfElements.Insert(sequenceOfElements.Count / 2 ,$"-{movesCounter}a");
                }

            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ",sequenceOfElements));
        }
    }
}
