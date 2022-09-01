using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Gauss__Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> justAList = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

            if (justAList.Count == 1)
            {
                Console.WriteLine(justAList[0]);
                return;
            }
            else if (justAList.Count <= 3 && justAList.Count > 1)
            {
                justAList[0] += justAList[justAList.Count - 1];
                justAList.RemoveAt(justAList.Count - 1);
            }
            else
            {
                for (int i = 0; i <= justAList.Count / 2; i++)
                {
                    justAList[i] += justAList[justAList.Count - 1];
                    justAList.RemoveAt(justAList.Count - 1);
                }

            }
            {
                Console.WriteLine(string.Join(" ", justAList));
            }
        }
    }
}
