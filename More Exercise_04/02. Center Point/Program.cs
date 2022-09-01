using System;

namespace _02._Center_Point
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d = double.Parse(Console.ReadLine());

            DefineWhichIsCloserToZero(a, b, c, d);
        }

        private static void DefineWhichIsCloserToZero(double a, double b, double c, double d)
        {
            double diagonal1 = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double diagonal2 = Math.Sqrt(Math.Pow(c, 2) + Math.Pow(d, 2));

            if (diagonal1 <= diagonal2)
            {
                Console.WriteLine($"({a}, {b})");
            }
            else
            {
                Console.WriteLine($"({c}, {d})");
            }

        }
    }
}
