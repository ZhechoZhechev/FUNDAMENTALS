using System;

namespace _4._Tribonacci_Sequence.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] sequence = new int[num];

            FillingTheSequence(num, sequence);
        }

        private static void FillingTheSequence(int num, int[] sequence)
        {
            switch (num)
            {
                case 1:
                    sequence[0] = 1;
                    break;
                case 2:
                    sequence[0] = 1;
                    sequence[1] = 1;
                    break;
                case 3:
                    sequence[0] = 1;
                    sequence[1] = 1;
                    sequence[2] = 2;
                    break;
                default:
                    sequence[0] = 1;
                    sequence[1] = 1;
                    sequence[2] = 2;
                    for (int i = 3; i <= sequence.Length -1; i++)
                    {
                        sequence[i] = sequence[i - 1] + sequence[i - 2] + sequence[i - 3];
                    }
                    break;
            }
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
