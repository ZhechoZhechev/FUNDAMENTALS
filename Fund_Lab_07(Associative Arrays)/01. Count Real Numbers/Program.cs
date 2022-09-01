using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main()
        {
            var integers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SortedDictionary<int, int> numsByAppearance = new SortedDictionary<int, int>();

            foreach (var integer in integers)
            {
                if (!numsByAppearance.ContainsKey(integer))
                {
                    numsByAppearance.Add(integer, 0);
                }
                numsByAppearance[integer]++;
            }

            foreach (var num in numsByAppearance)
            {
                Console.WriteLine($"{num.Key} -> {num.Value}");
            }
        }
    }
}
