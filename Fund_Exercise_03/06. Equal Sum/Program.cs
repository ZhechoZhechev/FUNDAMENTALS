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

            bool isFound = false;
                
   
            for (int i = 0; i < array.Length; i++)
            {
                if (array.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }
                //1 2 3 3
                int rightSum = 0;
                for (int j = array.Length - 1; j > i; j--)
                {
                    rightSum += array[j];
                }

                int leftSum = 0;
                for (int k = 0; k < i; k++)
                {
                    leftSum += array[k];
                    if (leftSum == rightSum && !isFound)
                    {
                        Console.WriteLine(i);
                        isFound = true;
                    }
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
