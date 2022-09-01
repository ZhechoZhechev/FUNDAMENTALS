using System;

namespace _03._Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());

            LongestLine(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        private static void LongestLine(double a, double b, double c, double d, double e, double f, double g, double h)
        {
            double firstLine = Math.Sqrt(Math.Pow(Math.Abs(a - c), 2) + Math.Pow(Math.Abs(b - d), 2));
            double secondLine = Math.Sqrt(Math.Pow(Math.Abs(e - g), 2) + Math.Pow(Math.Abs(f - h), 2));

            if (firstLine> secondLine)
            {
                DefineWhichIsCloserToZero(a, b, c, d);
            }
            else
            {
                DefineWhichIsCloserToZero(e, f, g, h);
            }
        }

        private static void DefineWhichIsCloserToZero(double a, double b, double c, double d)
        {
            double diagonal1 = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double diagonal2 = Math.Sqrt(Math.Pow(c, 2) + Math.Pow(d, 2));

            if (diagonal1 <= diagonal2)
            {
                Console.WriteLine($"({a}, {b})({c}, {d})");
            }
            else
            {
                Console.WriteLine($"({c}, {d})({a}, {b})");
            }

        }

    }
}
