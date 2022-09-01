using System;

namespace Multiplication_Table_10
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int multiplier = 1;


            while (multiplier <= 10)
            {
                Console.WriteLine($"{num} X {multiplier} = {num * multiplier}");
                multiplier++;
            }
        }
    }
}
