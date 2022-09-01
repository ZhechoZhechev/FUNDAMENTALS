using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_8___Array_Modifier
{
    class Program
    {
        static void Main()
        {
            var integers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split();

                switch (commands[0])
                {
                    case "swap":
                        SwapIntegers(integers, commands);
                        break;
                    case "multiply":
                        MutiplyIntegers(integers, commands);
                        break;
                    case "decrease":
                        DecreaseWithOne(integers, commands);
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", integers));
        }

        private static void DecreaseWithOne(List<int> integers, string[] commands)
        {
            for (int i = 0; i < integers.Count; i++)
            {
                integers[i]--;
            }
        }

        private static void MutiplyIntegers(List<int> integers, string[] commands)
        {
            int numOne = integers[int.Parse(commands[1])];
            int numTwo = integers[int.Parse(commands[2])];
            int result = numOne * numTwo;
            integers[int.Parse(commands[1])] = result;
        }

        private static void SwapIntegers(List<int> integers, string[] commands)
        {
            int indexOne = int.Parse(commands[1]);
            int indexTwo = int.Parse(commands[2]);

            int temp = integers[indexOne];
            integers[indexOne] = integers[indexTwo];
            integers[indexTwo] = temp;
        }
    }
}
