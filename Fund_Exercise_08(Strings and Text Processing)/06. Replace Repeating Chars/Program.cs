using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    class Program
    {
        static void Main()
        {
            string sequence = Console.ReadLine();

            StringBuilder withoutRepreat = new StringBuilder();
            
            withoutRepreat.Append(sequence[0]);

            for (int i = 0; i < sequence.Length - 1; i++)
            {

                if (sequence[i] != sequence[i + 1]) withoutRepreat.Append(sequence[i + 1]);
            }
            Console.WriteLine(withoutRepreat.ToString());
        }
    }
}
