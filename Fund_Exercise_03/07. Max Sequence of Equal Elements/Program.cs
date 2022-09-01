using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int sameIntCount = 0;
            int startOfSameInt = 0;
            int maxIntNum = 0;
            for (int i = 0; i < array.Length -1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    sameIntCount++;
                    if (sameIntCount > maxIntNum)
                    {
                        startOfSameInt = i - sameIntCount;
                        maxIntNum = sameIntCount;
                    }
                }
                else
                {
                    sameIntCount = 0;
                }
            }
            for (int i = startOfSameInt +1; i <= startOfSameInt + maxIntNum +1; i++)
            {
                Console.Write($"{array[i]} ");
            }
        }
    }
}
