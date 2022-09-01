using System;

namespace _04._Reverse_String
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string wordBackwards = "";

            for (int i = word.Length -1; i >= 0; i--)
            {
                wordBackwards += word[i];
            }
            Console.WriteLine(wordBackwards);
        }
    }
}
