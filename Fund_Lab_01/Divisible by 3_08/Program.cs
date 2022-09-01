using System;

namespace Divisible_by_3_08
{
    class Program
    {
        static void Main()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 ==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
