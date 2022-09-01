using System;

namespace Multiplication_Table_10
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine($"{num} X {multiplier} = {num * multiplier}");
                multiplier++;

            } while (multiplier <= 10);

        }
    }
}
