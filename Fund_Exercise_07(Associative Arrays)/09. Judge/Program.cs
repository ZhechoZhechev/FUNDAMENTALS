using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Judge
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> contestByUserByAndPoints = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, Dictionary<string, int>> userByContestByAndPoints = new Dictionary<string, Dictionary<string, int>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] info = input.Split(" -> ");
                string userName = info[0];
                string contest = info[1];
                int points = int.Parse(info[2]);

                if (!contestByUserByAndPoints.ContainsKey(contest))
                {
                    contestByUserByAndPoints[contest] = new Dictionary<string, int>();
                }
                if (contestByUserByAndPoints.ContainsKey(contest) && !contestByUserByAndPoints[contest].ContainsKey(userName))
                {
                    contestByUserByAndPoints[contest][userName] = 0;
                }
                if (contestByUserByAndPoints[contest][userName] < points)
                {
                    contestByUserByAndPoints[contest][userName] = points;
                }

                if (!userByContestByAndPoints.ContainsKey(userName))
                {
                    userByContestByAndPoints[userName] = new Dictionary<string, int>();
                }
                if (userByContestByAndPoints.ContainsKey(userName) && !userByContestByAndPoints[userName].ContainsKey(contest))
                {
                    userByContestByAndPoints[userName][contest] = 0;
                }
                if (userByContestByAndPoints[userName][contest] < points)
                {
                    userByContestByAndPoints[userName][contest] = points;
                }
            }
            
            foreach (var item in contestByUserByAndPoints)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count} participants");
                int counter = 0;
                
                var sortedCourses = item.Value.OrderByDescending(x => x.Value).ThenBy(u => u.Key);
                foreach (var value in sortedCourses)
                {
                    counter++;
                    Console.WriteLine($"{counter}. {value.Key} <::> {value.Value}");
                }
            }
            int count = 0;
            Console.WriteLine("Individual standings:");
            var sortedUsers = userByContestByAndPoints.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key);
            foreach (var item in sortedUsers)
            {
                count++;
                Console.WriteLine($"{count}. {item.Key} -> {item.Value.Values.Sum()}");
            }
        }
    }
}
