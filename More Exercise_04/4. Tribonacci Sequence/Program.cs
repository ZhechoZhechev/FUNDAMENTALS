using System;

namespace _4._Tribonacci_Sequence
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int[] sequence = new int[Math.Max(num, 3)];

            FillingTheSequence(num, sequence);

            for (int i = 0; i < num; i++)
            {
                Console.Write($"{sequence[i]} ");
            }
        }

        private static void FillingTheSequence(int num, int[] sequence)
        {

            sequence[0] = sequence[1] = 1;
            sequence[2] = 2;

            for (int i = 3; i <= sequence.Length - 1; i++)
            {

                sequence[i] = sequence[i - 1] + sequence[i - 2] + sequence[i - 3];

            }
        }
    }
}
