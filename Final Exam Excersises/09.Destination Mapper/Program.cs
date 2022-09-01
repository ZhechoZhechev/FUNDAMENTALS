using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _09.Destination_Mapper
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string destPattern = @"(=|\/)(?<lettosum>[A-Z]{1}[A-ZA-z]{2,})\1";

            MatchCollection destinations = Regex.Matches(input, destPattern);

            List<string> places = new List<string>();
            //int summedLenght = 0;
            
            foreach (Match place in destinations)
            
            {
                string validPlace = place.Groups["lettosum"].Value;
                //int curSum = validPlace.Length;
                places.Add(validPlace);
                //summedLenght += curSum; 
            }
            int summedLenght = places.Select(x => x.Length).ToArray().Sum();
            
            Console.WriteLine($"Destinations: {string.Join(", ", places)}");
            Console.WriteLine($"Travel Points: {summedLenght}");
        }
    }
}
