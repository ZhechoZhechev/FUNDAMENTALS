using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main()
        {
            List<double> justAList = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToList();
            for (int i = 0; i < justAList.Count -1; i++)
            {
                if (justAList[i] == justAList[i + 1])
                {
                    justAList[i] += justAList[i + 1];
                    justAList.RemoveAt(i + 1);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", justAList));
        }
    }
}
