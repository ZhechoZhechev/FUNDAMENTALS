using System;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main()
        {
            var stringOfChars = Console.ReadLine().Split();

            Dictionary<char, int> charsCount = new Dictionary<char, int>();

            foreach (var word in stringOfChars)
            {
                if (word == " ") continue;
                
                foreach (var character in word)
                {
                    if (!charsCount.ContainsKey(character))
                    {
                        charsCount.Add(character, 0);
                    }
                    charsCount[character]++;
                }

            }
            foreach (var character in charsCount)
            {
                Console.WriteLine($"{character.Key} -> {character.Value}");
            }
        }
    }
}
