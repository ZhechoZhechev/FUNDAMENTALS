using System;

namespace _3._Floating_Equality
{
    class Program
    {
        static void Main()
        {
            double numOne = double.Parse(Console.ReadLine());
            double numTwo = double.Parse(Console.ReadLine());
            const double EPS = 0.000001;

            double difference = Math.Abs(numOne - numTwo);
            if (EPS < difference)
            {
                Console.WriteLine("False");
            }
            else
            {
                Console.WriteLine("True");
            }
        }
    }
}
