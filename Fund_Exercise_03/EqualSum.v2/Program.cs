using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();


            for (int i = 0; i < array.Length; i++)
            {
                if (array.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }
                int rightSum = 0;
                int leftSum = 0;
                //1 2 3 3

                for (int j = i + 1; j < array.Length; j++)
                {
                    rightSum += array[j];
                }

                for (int k = i - 1; k >= 0; k--)
                {
                    leftSum += array[k];
                }
                
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}
