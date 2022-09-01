using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main()
        {
            int wagonsNum = int.Parse(Console.ReadLine());
            int[] train = new int[wagonsNum];
            int sum = 0;

            for (int i = 0; i < wagonsNum; i++)
            {
                train[i] = int.Parse(Console.ReadLine());
                sum += train[i];

            }
            Console.WriteLine(string.Join(" ", train));
            Console.WriteLine(sum);
        }
    }
}
