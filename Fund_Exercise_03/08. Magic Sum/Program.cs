using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int magicNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.Length -1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == magicNum)
                    {
                        Console.WriteLine($"{array[i]} {array[j]}");
                    }
                }
            }
        }
    }
}
