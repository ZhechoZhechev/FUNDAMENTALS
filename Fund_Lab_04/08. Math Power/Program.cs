using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main()
        {
            double @base = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            Console.WriteLine(CalculatingPower(@base, power));
        }

        static double CalculatingPower(double @base, double power) 
        {
            double result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= @base;
            }
            return result;
        }
    }
}
