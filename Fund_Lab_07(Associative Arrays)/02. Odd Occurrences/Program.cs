using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main()
        {
            var words = Console.ReadLine().Split()
                .Select(x => x.ToLower())
                .ToArray();

            Dictionary<string, int> wordsByCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!wordsByCount.ContainsKey(word))
                {
                    wordsByCount.Add(word, 0);
                }
                wordsByCount[word]++;
            }
            var oddWords = new List<string>();

            foreach (var word in wordsByCount)
            {
                if (word.Value % 2 != 0)
                {
                    oddWords.Add(word.Key);
                }
            }
            Console.WriteLine(string.Join(" ", oddWords));
        }
    }
}
