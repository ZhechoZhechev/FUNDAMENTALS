using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            MidleCharsFormula(input);
        }

        private static void MidleCharsFormula(string input)
        {
            if (input.Length % 2 != 0)
            {
                Console.WriteLine(input[input.Length / 2]);
            }
            else
            {
                Console.Write(input[input.Length / 2 - 1]);
                Console.Write(input[input.Length / 2]);
            }
        }
    }
}
