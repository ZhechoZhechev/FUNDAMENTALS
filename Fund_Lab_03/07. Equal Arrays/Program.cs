using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main()
        {
            int[] arrayOne = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] arrayTwo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sum = 0;

            for (int i = 0; i < arrayOne.Length; i++)
            {
                if (arrayOne[i] != arrayTwo[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
                
                sum += arrayOne[i];
                    
                if (i == arrayOne.Length - 1)
                {
                    Console.WriteLine($"Arrays are identical. Sum: {sum}");
                }
            }
        }
    }
}
