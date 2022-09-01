using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main()
        {
            List<int> ListOne = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
            List<int> ListTwo = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
            List<int> result = new List<int>();

            int BiggerListCount = Math.Max(ListOne.Count, ListTwo.Count);

            for (int i = 0; i < BiggerListCount; i++)
            {
                if (i < ListOne.Count)
                {
                    result.Add(ListOne[i]);
                }
                if (i < ListTwo.Count)
                {
                    result.Add(ListTwo[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
