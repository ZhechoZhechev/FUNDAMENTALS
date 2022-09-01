using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main()
        {
            string dates = Console.ReadLine();

            string regex = @"\b(?<day>\d{2})(?<separator>[/\-.])(?<month>[A-Z]{1}[a-z]{2})\k<separator>(?<year>\d{4})\b";

            MatchCollection trueDates = Regex.Matches(dates, regex);

            foreach (Match date in trueDates)
            {
                Console.WriteLine($"Day: {date.Groups["day"]}, Month: {date.Groups["month"]}, Year: {date.Groups["year"]}");
            }
        }
    }
}
