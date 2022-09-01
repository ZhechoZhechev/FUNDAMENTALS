using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main()
        {
            int[] initArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                if (commands[0] == "exchange")
                {
                    int givenIndex = int.Parse(commands[1]);
                    initArray = ArrayExchager(initArray, givenIndex);
                }
                else if (commands[0] == "max" || commands[0] == "min")
                {
                    FindMinMax(initArray, commands[0], commands[1]);
                }
                else
                {
                    FindTheNumbers(initArray, commands[0], int.Parse(commands[1]), commands[2]);
                }
                commands = Console.ReadLine().Split();
            }
            Console.WriteLine($"[{string.Join(", ", initArray)}]");
        }

        private static void FindTheNumbers(int[] initArray, string possition, int numberCount, string evenOrOdd)
        {
            if (numberCount > initArray.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            if (numberCount == 0)
            {
                Console.WriteLine($"[]");
                return;
            }

            int resultOddEven = 1;
            if (evenOrOdd == "even") resultOddEven = 0;
            int count = 0;
            List<int> nums = new List<int>();
            
            if (possition == "first")
            {
                foreach (int num in initArray)
                {
                    if (num % 2 == resultOddEven)
                    {
                        count++;
                        nums.Add(num);
                    }
                    if (count == numberCount) break;
                }
            }
            else
            {
                for (int currentIndex = initArray.Length - 1; currentIndex >= 0; currentIndex--)
                {
                    if (initArray[currentIndex] % 2 == resultOddEven)
                    {
                        count++;
                        nums.Add(initArray[currentIndex]);
                    }
                    if (count == numberCount) break;
                }
                nums.Reverse();
            }
            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }

        private static void FindMinMax(int[] initArray, string minOrMax, string evenOrOdd)
        {
            int index = -1;
            int min = int.MaxValue;
            int max = int.MinValue;
            int resultOddEven = 1;

            if (evenOrOdd == "even") resultOddEven = 0;
            
            for (int currentIndex = 0; currentIndex <= initArray.Length - 1; currentIndex++)
            {
                if (initArray[currentIndex] % 2 == resultOddEven)
                {
                    if (minOrMax == "max" && max <= initArray[currentIndex])
                    {
                        max = initArray[currentIndex];
                        index = currentIndex;
                    }
                    else if (minOrMax == "min" && min >= initArray[currentIndex])
                    {
                        min = initArray[currentIndex];
                        index = currentIndex;
                    }
                }

            }
            if (index > -1)
            {
                Console.WriteLine(index.ToString());
            }
            else
            {
                Console.WriteLine("No matches");
            }

        }

        private static int[] ArrayExchager(int[] initArray, int givenIndex)
        {
            if (givenIndex >= initArray.Length || givenIndex < 0)
            {
                Console.WriteLine("Invalid index");
                return initArray;
            }

            int[] exchangedArr = new int[initArray.Length];
            int index = 0;
            for (int i = givenIndex +1; i <= initArray.Length -1; i++)
            {
                exchangedArr[index] = initArray[i];
                index++;
            }

            for (int i = 0; i <= givenIndex; i++)
            {
                exchangedArr[index] = initArray[i];
                index++;
            }
            return exchangedArr;
        }
    }
}
