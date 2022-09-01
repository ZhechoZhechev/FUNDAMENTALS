using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main()
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());

            TheSmallestNumber(numOne, numTwo, numThree);
        }

        private static void TheSmallestNumber(int num1, int num2, int num3)
        {
            Console.WriteLine(Math.Min(num1, Math.Min(num2, num3)));

        }
    }
}
