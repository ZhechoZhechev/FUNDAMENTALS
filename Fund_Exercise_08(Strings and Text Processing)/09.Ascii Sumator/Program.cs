using System;

namespace _09.Ascii_Sumator
{
    class Program
    {
        static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());

            string randomString = Console.ReadLine();

            int start = Math.Min(firstChar, secondChar);
            int end = Math.Max(firstChar, secondChar);

            int sum = 0;

            for (int i = 0; i < randomString.Length; i++)
            {
                int currChar = randomString[i];
                if (currChar > start && currChar < end)
                {
                    sum += currChar;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
