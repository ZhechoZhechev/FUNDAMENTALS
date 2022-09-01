using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_9___Numbers
{
    class Program
    {
        static void Main()
        {
            var listOfNums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            var listOfNumsAboveAverage = new List<int>();
            int sum = listOfNums.Sum();
            double averageNum = sum / (double)listOfNums.Count;
            
            for (int i = 0; i < listOfNums.Count; i++)
            {
                if (listOfNums[i] > averageNum)
                {
                    listOfNumsAboveAverage.Add(listOfNums[i]);
                }
            }
            listOfNumsAboveAverage.Sort((a, b) => b.CompareTo(a));
            listOfNumsAboveAverage = listOfNumsAboveAverage.Take(5).ToList();
            
            if (listOfNumsAboveAverage.Count <= 0)
            {
                Console.WriteLine("No");
                return;
            }
            Console.WriteLine(string.Join(" ", listOfNumsAboveAverage));
        }
    }
}
