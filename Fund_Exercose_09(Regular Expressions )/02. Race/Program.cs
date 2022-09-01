using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main()
        {
            var participants = Console.ReadLine().Split(", ");
            string namePattern = @"[A-Za-z]";
            string distancePattern = @"[0-9]";

            string input = string.Empty;

            Dictionary<string, int> racersInfo = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "end of race")
            {
                string info = input;
                MatchCollection nameAsLett = Regex.Matches(info, namePattern);
                MatchCollection distance = Regex.Matches(info, distancePattern);

                var name = string.Join("", nameAsLett);

                int totalDistance = 0;
                
                foreach (Match item in distance)
                {
                    totalDistance += int.Parse(item.Value);
                }
                
                if (participants.Contains(name))
                {
                    if (!racersInfo.ContainsKey(name))
                    {
                        racersInfo.Add(name, totalDistance);
                    }
                    else
                    {
                        racersInfo[name] += totalDistance;
                    }
                }

            }
            var racersSorted = racersInfo.OrderByDescending(x => x.Value);

            int counter = 0;

            foreach (var participant in racersSorted)
            {
                counter++;
                if (counter == 1) Console.WriteLine($"{counter}st place: {participant.Key}");
                else if (counter == 2) Console.WriteLine($"{counter}nd place: {participant.Key}");
                else if(counter == 3) Console.WriteLine($"{counter}rd place: {participant.Key}");

            }
        }
    }
}
