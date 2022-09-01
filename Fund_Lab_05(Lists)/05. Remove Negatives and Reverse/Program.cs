using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main()
        {
            List<int> ListOne = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

            for (int i = 0; i < ListOne.Count; i++)
            {
                if (ListOne[i] < 0)
                {
                    ListOne.Remove(ListOne[i]);
                    i--;
                }
            }
            ListOne.Reverse();
            if (ListOne.Count == 0)
            {
                Console.WriteLine("empty");

            }
            Console.WriteLine(string.Join(" ", ListOne));
        }
    }
}
