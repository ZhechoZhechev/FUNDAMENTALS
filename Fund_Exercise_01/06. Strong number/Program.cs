using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main()
        {
            int strongNum = int.Parse(Console.ReadLine());
            int strongNumCopy = strongNum;
            int factorielSum = 0;

            while (strongNum > 0)
            {
                int factoialNum = 1;
                int currentNum = strongNum % 10;
                strongNum /= 10;
                for (int i = 2; i <= currentNum; i++)
                {
                    factoialNum *= i;
                }
                factorielSum += factoialNum;
            }
            Console.WriteLine(factorielSum == strongNumCopy ? "yes" : "no");

        }
    }
}
