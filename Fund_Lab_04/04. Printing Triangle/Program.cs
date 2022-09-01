using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number -1; i++)
            {
                Console.WriteLine();
                TrianglesHight(1, i);
            }

            for (int i = number ; i >= 1; i--)
            {
                Console.WriteLine();
                TrianglesHight(1, i);
            }


        }

        static void TrianglesHight(int start, int end) 
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
