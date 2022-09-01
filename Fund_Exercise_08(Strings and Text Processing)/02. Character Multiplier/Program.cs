using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main()
        {
            var strings = Console.ReadLine().Split();

            string firstWord = strings[0];
            string secondWord = strings[1];

            string longerWord = string.Empty;
            string shorterWord = string.Empty;

            if (firstWord.Length > secondWord.Length)
            {
                longerWord = firstWord;
                shorterWord = secondWord;
            }
            else
            {
                longerWord = secondWord;
                shorterWord = firstWord;
            }

            int sum = 0;

            for (int i = 0; i < shorterWord.Length; i++)
            {
                sum += firstWord[i] * secondWord[i];
            }

            for (int i = shorterWord.Length; i <= longerWord.Length -1; i++)
            {
                sum += longerWord[i];
            }
            Console.WriteLine(sum);
        }
    }
}
