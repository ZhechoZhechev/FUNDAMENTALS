using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main()
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            int result = GetMultipleOfEvenAndOdds(evenSum, oddSum);
            Console.WriteLine(result);
        }

        static int GetSumOfEvenDigits(int number) 
        {
                int evenSum = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                number = number / 10;
                    if (currentDigit % 2 == 0)
                {
                    evenSum += currentDigit;
                }
            }
                return evenSum;
        }

        static int GetSumOfOddDigits(int number)
        {
            int OddSum = 0;
            while (number > 0)
            {
                int currentDigit = number % 10;
                number = number / 10;
                if (currentDigit % 2 != 0)
                {
                    OddSum += currentDigit;
                }
            }
            return OddSum;
        }

        static int GetMultipleOfEvenAndOdds(int evenSum, int oddSum)
        {
            int multiOfSums = evenSum * oddSum;
            return multiOfSums;
        }
    }
}
