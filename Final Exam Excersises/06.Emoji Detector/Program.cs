using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

namespace _06.Emoji_Detector
{
    class Program
    {
        static void Main()
        {
            string emojiPattern = @"([:]{2}|[*]{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string numsPattern = @"[0-9]";

            string text = Console.ReadLine();

            MatchCollection numbers = Regex.Matches(text, numsPattern);

            BigInteger coolThresholdSum = 1;

            foreach (Match num in numbers)
            {
                int curNum = int.Parse(num.ToString());
                coolThresholdSum = coolThresholdSum * curNum;
            }
            var coolEmojies = new List<string>();

            MatchCollection emojies = Regex.Matches(text, emojiPattern);
            int emojiesCount = 0;
            foreach (Match item in emojies)
            {
                emojiesCount++;

                BigInteger emojiCoolness = 1;

                string emoji = item.Groups["emoji"].Value;

                foreach (var ch in emoji)
                {
                    //int curChar = int.Parse(ch.ToString());
                    emojiCoolness = emojiCoolness + ch;

                }

                if (emojiCoolness >= coolThresholdSum)
                {
                    coolEmojies.Add(item.ToString());
                }
            }
            Console.WriteLine($"Cool threshold: {coolThresholdSum}");
            Console.WriteLine($"{emojiesCount} emojis found in the text. The cool ones are:");
            Console.WriteLine($"{string.Join(Environment.NewLine, coolEmojies)}");
        }
    }
}
