using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sumOfdigits = 0;
                int actualNum = i;
                while (actualNum > 0)
                {
                    int lastDigit = actualNum % 10;
                    actualNum = actualNum / 10;
                    sumOfdigits += lastDigit;
               
                }
                    if (sumOfdigits == 5 || sumOfdigits == 7 || sumOfdigits == 11)
                    {
                    Console.WriteLine($"{i} -> True");
                    }
                    else
                    {
                    Console.WriteLine($"{i} -> False");
                    }
            }
        }
    }
}
