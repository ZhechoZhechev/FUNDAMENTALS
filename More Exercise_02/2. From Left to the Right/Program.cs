using System;

namespace _2._From_Left_to_the_Right
{
    class Program
    {
        static void Main()
        {
            int linesCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= linesCount; i++)
            {
                string twoNumbers = Console.ReadLine();
                long sum = 0;
                string[] splitTwoNumbers = twoNumbers.Split(" ");
                long numOne = long.Parse(splitTwoNumbers[0]);
                long numTwo = long.Parse(splitTwoNumbers[1]);


                if (numOne > numTwo)
                {
                    while (numOne != 0)
                    {
                        long curentDigit = numOne % 10;
                        sum += curentDigit;
                        numOne /= 10;
                    }
                }
                else
                {
                    while (numTwo != 0)
                    {
                        long curentDigit = numTwo % 10;
                        sum += curentDigit;
                        numTwo /= 10;
                    }

                }
                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}
