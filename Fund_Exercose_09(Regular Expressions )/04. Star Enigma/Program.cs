using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    class Program
    {
        static void Main()
        {
            int messagesCount = int.Parse(Console.ReadLine());

            List<string> attackedPlanets = new List<string>();
            
            List<string> destryedPlanets = new List<string>();

            for (int i = 0; i < messagesCount; i++)
            {
                string input = Console.ReadLine();

                int key = input.ToLower().Count(x => x == 't' || x == 's' || x == 'a' || x == 'r');

                string decryptedMsg = string.Empty;

                for (int k = 0; k < input.Length; k++)
                {
                    char decrChar = (char)(input[k] - key);
                    decryptedMsg += decrChar;
                }

                string regex = @"[^@\-!:>]*@(?<planet>[A-Z]+[a-z]+)[^@\-!:>]*:(?<population>[\d]+)[^@\-!:>]*!(?<action>[A-Z]{1})![^@\-!:>]*->(?<soldiers>\d+)[^@\-!:>]*";

                Match deciptedInfo = Regex.Match(decryptedMsg, regex);

                if (deciptedInfo.Success)
                {
                    string planetName = deciptedInfo.Groups["planet"].Value;
                    string action = deciptedInfo.Groups["action"].Value;
                    
                    if (action == "A") attackedPlanets.Add(planetName);
                    else destryedPlanets.Add(planetName);
                }
            }
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            attackedPlanets.OrderBy(x => x).ToList().ForEach(planetName => Console.WriteLine($"-> {planetName}"));

            Console.WriteLine($"Destroyed planets: {destryedPlanets.Count}");
            destryedPlanets.OrderBy(x => x).ToList().ForEach(planetName => Console.WriteLine($"-> {planetName}"));
        }
    }
}
