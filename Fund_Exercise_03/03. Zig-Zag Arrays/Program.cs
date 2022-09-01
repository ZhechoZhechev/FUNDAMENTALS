using System;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            string[] arrOne = new string[numberOfInputs];
            string[] arrTwo = new string[numberOfInputs];

            for (int i = 0; i < numberOfInputs; i++)
            {
                string[] twoNums = Console.ReadLine().Split();
                if (i % 2 == 0)
                {
                    arrOne[i] = twoNums[0];
                    arrTwo[i] = twoNums[1];
                }
                else
                {
                    arrOne[i] = twoNums[1];
                    arrTwo[i] = twoNums[0];

                }
            }
            Console.WriteLine(string.Join(" ",arrOne));
            Console.WriteLine(string.Join(" ",arrTwo));
        }
    }
}
