using System;

namespace _07._NxN_Matrix
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            MatrixMethod(number);
        }

        private static void MatrixMethod(int number)
        {
            for (int i = 1; i <= number; i++)
            {

                for (int j = 1; j <= number; j++)
                {
                Console.Write($"{number} ");
                }
                    Console.WriteLine();
                
            }
        }
    }
}
