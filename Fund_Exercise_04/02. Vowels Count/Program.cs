using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine().ToLower();

            VowsCount(input);
        }

        private static void VowsCount(string input)
        {
            int count = 0;
            foreach (char vows in input)
            {
                if ("aouei".Contains(vows))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
