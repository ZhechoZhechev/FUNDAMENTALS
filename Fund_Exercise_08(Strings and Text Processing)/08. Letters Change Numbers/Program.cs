using System;

namespace _08._Letters_Change_Numbers
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            
            //string firstWord = input[0];
            //string secondWord = input[1];

            double sum = 0;

            foreach (var word in input)
            {
                char firstLetter = word[0];
                char lastLetter = word[word.Length - 1];
                double number = double.Parse(word.Substring(1, word.Length - 2));
                
                if (firstLetter >= 65 && firstLetter <= 90)
                {
                    sum += number / (char)(firstLetter - 64);
                }
                else
                {
                    sum += number * (char)(firstLetter - 96);
                }
                
                if (lastLetter >= 65 && lastLetter <= 90)
                {
                    sum = sum - (char)(lastLetter - 64);
                }
                else
                {
                    sum = sum + (char)(lastLetter - 96);
                }
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
