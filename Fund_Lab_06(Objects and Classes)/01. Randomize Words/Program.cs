using System;
using System.Linq;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main()
        {
            var fewWords = Console.ReadLine().Split().ToList();

            Random random = new Random();
            for (int i = 0; i < fewWords.Count; i++)
            {
                int randomIndex = random.Next(0, fewWords.Count);
                var currentWord = fewWords[i];
                
                fewWords[i] = fewWords[randomIndex];
                fewWords[randomIndex] = currentWord;
            }
            foreach (string word in fewWords)
            {
                Console.WriteLine(word);
            }
        }
    }
}
