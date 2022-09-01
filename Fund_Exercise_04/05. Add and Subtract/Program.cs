using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main()
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());
            int numThree = int.Parse(Console.ReadLine());
            
            int sum = SumOfOneAndTwo(numOne, numTwo);
            int finalResult = SumMinusThirdNum(sum, numThree);
            Console.WriteLine(finalResult);
        }

        private static int SumMinusThirdNum(int sum, int numThree) => sum - numThree;

        private static int SumOfOneAndTwo(int numOne, int numTwo) => numOne + numTwo;

    }
}
