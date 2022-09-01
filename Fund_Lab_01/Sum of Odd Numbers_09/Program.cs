using System;

namespace Sum_of_Odd_Numbers_09
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < num; i++)
            {
                int currentOddNum = (2 * i) + 1;
                Console.WriteLine(currentOddNum);
                sum += currentOddNum;

            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
