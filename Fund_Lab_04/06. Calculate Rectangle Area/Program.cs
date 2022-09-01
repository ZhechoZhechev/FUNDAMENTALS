using System;

namespace _06._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main()
        {
            double lenght = int.Parse(Console.ReadLine());
            double width = int.Parse(Console.ReadLine());

            Console.WriteLine(RectangleArea(lenght, width));
        }

        static double RectangleArea(double lenght, double width) 
        {
            double recArea = lenght * width;

            return recArea;
        }
    }
}
