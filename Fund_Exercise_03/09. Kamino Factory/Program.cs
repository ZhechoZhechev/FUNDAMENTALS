using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {

        //You will receive the DNA length and until you receive the command "Clone them!", 
        //you will be receiving a DNA sequence of ones and zeroes, split by '!' (one or several).
        //You should select the sequence with the longest subsequence of ones.
        //If there are several sequences with the same length of the subsequence of ones,
        //print the one with the leftmost starting index, if there are several sequences with the same length and starting index, 
        //select the sequence with the greater sum of its elements.
        //After you receive the last command "Clone them!" you should print the collected information in the following format:
        static void Main()
        {
            int sequenceLength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int[] DNA = new int[sequenceLength];
            int bestSequenceLenght = 0;
            int bestStartingIndex = 0;
            int bestDnaSum = 0;
            int dnasCounter = 0;
            int bestDnaCounter = 0;


            while (input != "Clone them!")
            {
                int[] currentDna = input.Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                dnasCounter++;
                int currentLenght = 1;
                int currentStartingIndex = 0;
                int currentDnaSum = 0;
                int bestLenght = 1;
                bool isTheBestDNA = false;

                for (int i = 0; i < currentDna.Length - 1; i++)
                {
                    if (currentDna[i] == currentDna[i + 1])
                    {
                        currentLenght++;
                    }
                    if (currentLenght > bestLenght)
                    {
                        bestLenght = currentLenght;
                        currentStartingIndex = i;
                    }
                    if (currentDna[i] != currentDna[i + 1])
                    {
                        currentLenght = 1;
                    }

                }
                currentDnaSum = currentDna.Sum();

                if (bestLenght > bestSequenceLenght)
                {
                    isTheBestDNA = true;
                }
                else if (bestLenght == bestSequenceLenght)
                {
                    if (currentStartingIndex < bestStartingIndex)
                    {
                        isTheBestDNA = true;
                    }
                    else if (currentStartingIndex == bestStartingIndex)
                    {
                        if (currentDnaSum > bestDnaSum)
                        {
                            isTheBestDNA = true;
                        }
                    }
                }
                if (isTheBestDNA)
                {
                    DNA = currentDna.ToArray();
                    bestSequenceLenght = bestLenght;
                    bestStartingIndex = currentStartingIndex;
                    bestDnaSum = currentDnaSum;
                    bestDnaCounter = dnasCounter;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {bestDnaCounter} with sum: {bestDnaSum}.");
            Console.WriteLine(String.Join(" ", DNA));
        }
    }
}
