using System;
using System.Collections.Generic;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main()
        {

            int count = int.Parse(Console.ReadLine());
            
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            for (int i = 1; i <= count; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                
                if (!synonyms.ContainsKey(word))
                {
                    synonyms.Add(word, new List<string>());
                }
                synonyms[word].Add(synonym);
            }
            foreach (var word in synonyms)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
