using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double lenght = double.Parse(Console.ReadLine());
            Console.Write("Length: ");
            
            double width = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            
            double height = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            
            double volume  = (lenght * width * height) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}
