using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;

            while (num > 0)
            {
                int currentNum = num % 10;
                sum += currentNum;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}
