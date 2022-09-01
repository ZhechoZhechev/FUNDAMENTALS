using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main()
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            int numFour = int.Parse(Console.ReadLine());

            int sumOneAndTwo = numOne + numTwo;
            int divSumAndThree = sumOneAndTwo / numThree;
            int multiDivandFour = divSumAndThree * numFour;

            Console.WriteLine(multiDivandFour);
        }
    }
}
