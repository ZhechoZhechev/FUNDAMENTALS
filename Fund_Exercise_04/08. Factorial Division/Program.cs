using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main()
        {
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

           double factOne = FactorialMeth(numOne);
           double factTwo = FactorialMeth(numTwo);
            Console.WriteLine($"{factOne / factTwo:f2}");
        }

        private static long FactorialMeth(int num)
        {
            long factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
