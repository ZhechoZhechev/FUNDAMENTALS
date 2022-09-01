using System;

namespace _05._Multiplication_Sign
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[3];
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            WhatNumberIsTheMultiplier(arr);
        }

        private static void WhatNumberIsTheMultiplier(int[] arr)
        {
            int zerosCount = 0;
            int possCount = 0;
            int negCount = 0;

            foreach (int number in arr)
            {
                if (number == 0) zerosCount++;

                else if (number < 0) negCount++;

                else possCount++;
            }
            
            if (zerosCount > 0) Console.WriteLine("zero");
           
            else if (possCount == 3) Console.WriteLine("positive");

            else if (possCount == 1 || negCount == 2) Console.WriteLine("positive");

            else Console.WriteLine("negative");
        }
    }
}


