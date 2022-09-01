using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _16.Mirror_words
{
    class Program
    {
        static void Main()
        {
            string pattern = @"(@|#)(?<firstw>[A-Za-z]{3,})\1\1(?<secondw>[A-Za-z]{3,})\1";
            string input = Console.ReadLine();

            MatchCollection validPairs = Regex.Matches(input, pattern);

            Dictionary<string, string> mirrorWords = new Dictionary<string, string>();

            if (validPairs.Count > 0)
            {
                Console.WriteLine($"{validPairs.Count} word pairs found!");
            }
            else Console.WriteLine("No word pairs found!");

            foreach (Match word in validPairs)
            {
                string firstWord = word.Groups["firstw"].Value;
                string secondWord = word.Groups["secondw"].Value;
                var secondReversed = new string(secondWord.ToCharArray().Reverse().ToArray());

                if (string.Equals(firstWord, secondReversed))
                {
                    mirrorWords.Add(firstWord, secondWord);
                }
            }
            if (mirrorWords.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                int count = 0;
                foreach (var item in mirrorWords)
                {
                    Console.Write($"{item.Key} <=> {item.Value}");
                    if (count < mirrorWords.Count - 1)
                    {
                        Console.Write(", ");
                    }
                    count++;
                }
            }
            else Console.WriteLine("No mirror words!");
        }
    }
}
