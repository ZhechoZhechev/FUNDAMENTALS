using System;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split();

            string result = string.Empty;

            foreach (var word in input)
            {
                for (int i = 0; i < word.Length; i++)
                {
                    result += word;
                }
            }
            Console.WriteLine(result);
        }
    }
}
