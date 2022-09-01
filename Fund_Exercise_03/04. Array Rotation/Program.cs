using System;
using System.Linq;

namespace _04._Array_Rotation
{
    class Program
    {
        static void Main()
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int numOfRotations = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numOfRotations; i++)
            {
                int firstDigit = array[0];
                
                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length -1] = firstDigit;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
