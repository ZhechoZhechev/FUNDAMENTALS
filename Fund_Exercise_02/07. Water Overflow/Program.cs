using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main()
        {
            int tankCappacity = 255;
            int timesToPour = int.Parse(Console.ReadLine());
            int sumOflitters = 0;

            for (int i = 1; i <= timesToPour; i++)
            {
                int litters = int.Parse(Console.ReadLine());
                if (sumOflitters + litters > tankCappacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    sumOflitters += litters;
                }

            }
            Console.WriteLine(sumOflitters);
        }
    }
}
