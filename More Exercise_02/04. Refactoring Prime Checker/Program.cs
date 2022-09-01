using System;

namespace _04._Refactoring_Prime_Checker
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            for (int currentNum = 2; currentNum <= num; currentNum++)
            {
                bool isPrime = true;
                for (int divider = 2; divider < currentNum; divider++)
                {
                    if (currentNum % divider == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", currentNum, isPrime.ToString().ToLower());
            }
        }
    }
}
