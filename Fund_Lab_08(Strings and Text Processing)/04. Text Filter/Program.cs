using System;

namespace _04._Text_Filter
{
    class Program
    {
        static void Main()
        {
            string[] wordsToMask = Console.ReadLine().Split(", ");
            string ourText = Console.ReadLine();

            foreach (var word in wordsToMask)
            {
                string asterixEquivalent = new string('*', word.Length);

                ourText = ourText.Replace(word, asterixEquivalent);
            }
            Console.WriteLine(ourText);
        }
    }
}
