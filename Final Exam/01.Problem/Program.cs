using System;
using System.Text.RegularExpressions;

namespace _01.Problem
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"([@|#]+)(?<colour>[a-z]{3,})([@|#]+)([^A-Za-z0-9]?)+(/+)(?<number>\d+)(/+)";

            MatchCollection eggsAndColours = Regex.Matches(input, pattern);

            foreach (Match egg in eggsAndColours)
            {
                Console.WriteLine($"You found {egg.Groups["number"].Value} {egg.Groups["colour"].Value} eggs!");
            }
        }
    }
}
