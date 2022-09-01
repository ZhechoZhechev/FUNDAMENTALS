using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._MOBA_Challenger
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, Dictionary<string, int>> playerByPossAndSkill = new Dictionary<string, Dictionary<string, int>>();
            //Dictionary<string, List<string>> playerPositions = new Dictionary<string, List<string>>();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Season end")
            {

                if (input.Contains(" -> "))
                {
                    string[] info = input.Split(" -> ");
                    string player = info[0];
                    string possition = info[1];
                    int skill = int.Parse(info[2]);

                    if (!playerByPossAndSkill.ContainsKey(player))
                    {
                        playerByPossAndSkill[player] = new Dictionary<string, int>();
                    }
                    if (playerByPossAndSkill.ContainsKey(player) && !playerByPossAndSkill[player].ContainsKey(possition))
                    {
                        playerByPossAndSkill[player][possition] = 0;
                        //playerPositions[player].Add(possition);
                    }
                    if (playerByPossAndSkill[player][possition] < skill)
                    {
                        playerByPossAndSkill[player][possition] = skill;
                    }
                }
                if (input.Contains(" vs "))
                {
                    string[] info = input.Split(" vs ");
                    string playerOne = info[0];
                    string playerTwo = info[1];

                    bool playersExists = playerByPossAndSkill.ContainsKey(playerOne) && playerByPossAndSkill.ContainsKey(playerTwo);

                    if (playersExists)
                    {
                        string playerToRemove = "";
                        foreach (var item in playerByPossAndSkill[playerOne])
                        {
                            foreach (var value in playerByPossAndSkill[playerTwo])
                            {
                                if (item.Key == value.Key)
                                {
                                    if (playerByPossAndSkill[playerOne].Values.Sum() > playerByPossAndSkill[playerTwo].Values.Sum())
                                    {
                                        playerToRemove = playerTwo;
                                        //playerPositions.Remove(playerTwo);
                                    }
                                    else if (playerByPossAndSkill[playerOne].Values.Sum() < playerByPossAndSkill[playerTwo].Values.Sum())
                                    {
                                        playerToRemove = playerOne;
                                        //playerPositions.Remove(playerOne);
                                    }
                                }
                            }
                        }
                        playerByPossAndSkill.Remove(playerToRemove);
                    }
                }
            }
            var poolSorted = playerByPossAndSkill.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key);
            foreach (var item in poolSorted)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Values.Sum()} skill");
                var sortedSkills = item.Value.OrderByDescending(x => x.Value).ThenBy(u => u.Key);
                foreach (var possition in sortedSkills)
                {
                    Console.WriteLine($"- {possition.Key} <::> {possition.Value}");
                }
            }
        }
    }
}
