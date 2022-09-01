using System;
using System.Text.RegularExpressions;

namespace _18.Ad_Astra
{
    class Program
    {
        static void Main()
        {
            string info = Console.ReadLine();
            string foodPattern = @"(\||#)(?<item>[A-z]+\s?[A-z]+)\1(?<expdate>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1";

            const int CAL_NEEDED_PER_DAY = 2000;
                
            int totalCal = 0;

            MatchCollection foodAndCals = Regex.Matches(info, foodPattern);

            if (foodAndCals.Count > 0)
            {

                foreach (Match item in foodAndCals)
                {
                    int CalForItem = int.Parse(item.Groups["calories"].Value);
                    totalCal += CalForItem;
                }

                int calsForHowManyDays = totalCal / CAL_NEEDED_PER_DAY;
                Console.WriteLine($"You have food to last you for: {calsForHowManyDays} days!");
            }
            else
            {
            Console.WriteLine("You have food to last you for: 0 days!");
            }

            if (true)
            {
                foreach (Match item in foodAndCals)
                {
                    Console.WriteLine($"Item: {item.Groups["item"].Value}, Best before: {item.Groups["expdate"].Value}, Nutrition: {item.Groups["calories"].Value}");
                }
            }


        }
    }
}
