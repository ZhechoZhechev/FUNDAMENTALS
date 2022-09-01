﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main()
        {
            var numbersAsStrings = Console.ReadLine().Split('|').Reverse().ToList();

            var numbers = new List<int>();
            foreach (var number in numbersAsStrings)
            {
                numbers.AddRange(number.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
