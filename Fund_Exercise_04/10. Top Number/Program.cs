using System;
using System.Linq;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int upperBorderNum = int.Parse(Console.ReadLine());

            for (int i = 1; i <= upperBorderNum; i++)
            {
                bool IsNumberTop = TopNumberCheck(i);
                if (IsNumberTop)
                {
                    Console.WriteLine(i);
                }
                
            }
        }

        private static bool TopNumberCheck(int num)
        {
            int copyNum = num;

            bool dividesToEight = false;
            bool hasAtLeastOneOddDigg = false;
            
            int sumOfDiggits = 0;
            while (num > 0)
            {
                int currentDig = num % 10;
                sumOfDiggits += currentDig;
                num /= 10;

            }
            if (sumOfDiggits % 8 == 0)
            {
                dividesToEight = true;
            }

            while (copyNum > 0)
            {
                int currentDig = copyNum % 10;
                if (currentDig %2 != 0)
                {
                    hasAtLeastOneOddDigg = true;
                    break;
                }
                copyNum /= 10;
            }
            //int[] numArray = numString.Split().Select(int.Parse).ToArray();

            if (!dividesToEight || !hasAtLeastOneOddDigg)
            {
                return false;
            }
            return true;

        }
    }
}
