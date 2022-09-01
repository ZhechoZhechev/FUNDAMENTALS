using System;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main()
        {
            var integers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var numPlusPower = Console.ReadLine().Split().Select(int.Parse).ToList();
            int theBomb = numPlusPower[0];
            int power = numPlusPower[1];

            for (int i = 0; i < integers.Count; i++)
            {
                if (integers[i] == theBomb)
                {
                    int start = Math.Max(0, i - power);
                    int end = Math.Min(integers.Count - 1, i + power);
                    for (int j = start; j <= end; j++)
                    {
                        integers[j] = 0;
                    }
                }
            }
            int sum = integers.Sum();
            Console.WriteLine(sum);
        }
    }
}
