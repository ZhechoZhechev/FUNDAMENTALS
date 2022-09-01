﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            string pattern = @"(^|(?<=\s))[A-Za-z0-9]+[\.\-_]?[A-Za-z0-9]+@[A-Za-z+\-?]+.[A-Za-z+\-?]+\.?([A-Za-z+\-?]+)?(\b|(?=\s))";

            MatchCollection collection = Regex.Matches(input, pattern);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

        }
    }
}