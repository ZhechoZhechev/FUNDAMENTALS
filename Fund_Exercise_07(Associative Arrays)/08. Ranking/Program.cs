using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> contestAndPassword = new Dictionary<string, string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of contests")
            {
                string[] info = input.Split(":");
                string contest = info[0];
                string paswword = info[1];

                contestAndPassword.Add(contest, paswword);
            }

            Dictionary<string, Dictionary<string, int>> userContesPoints = new Dictionary<string, Dictionary<string, int>>();

            string secondaryInput = string.Empty;

            while ((secondaryInput = Console.ReadLine()) != "end of submissions")
            {
                string[] secondInfo = secondaryInput.Split("=>");
                string contest = secondInfo[0];
                string password = secondInfo[1];
                string user = secondInfo[2];
                int points = int.Parse(secondInfo[3]);

                //Save the user with the contest they take part in (a user can take part in many contests)
                //and the points the user has in the given contest.If you receive the same contest and the same user, update the points,
                //only if the new ones are more than the older ones.
                if (contestAndPassword.ContainsKey(contest) && contestAndPassword[contest] == password)
                {
                    if (!userContesPoints.ContainsKey(user))
                    {
                        userContesPoints[user] = new Dictionary<string, int>();
                    }
                    if (userContesPoints.ContainsKey(user) && !userContesPoints[user].ContainsKey(contest))
                    {
                        userContesPoints[user][contest] = 0;
                    }
                    if (userContesPoints[user][contest] < points)
                    {
                        userContesPoints[user][contest] = points;
                    }
                }
            }
            string winner = userContesPoints.OrderBy(x => x.Value.Values.Sum()).Last().Key;
            int topPoints = userContesPoints.OrderBy(x => x.Value.Values.Sum()).Last().Value.Values.Sum();

            Console.WriteLine($"Best candidate is {winner} with total {topPoints} points.");
            Console.WriteLine("Ranking:");

            foreach (var item in userContesPoints.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var contest in item.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}
