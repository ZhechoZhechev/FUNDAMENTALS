using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main()
        {
            char input = char.Parse(Console.ReadLine());

            if (Char.IsLower(input))
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
