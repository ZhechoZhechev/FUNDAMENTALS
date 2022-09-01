using System;
using System.Text;

namespace _07._String_Explosion
{
    class Program
    {
        static void Main()
        {
            string sequence = Console.ReadLine();

            StringBuilder afterExplosion = new StringBuilder();
            
            int explosionPower = 0;

            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == '>')
                {
                    afterExplosion.Append(sequence[i]);
                    explosionPower += int.Parse(sequence[i + 1].ToString());
                }
                else if (sequence[i] != '>' && explosionPower == 0)
                {
                    afterExplosion.Append(sequence[i]);
                }
                else if (sequence[i] != '>' && explosionPower != 0)
                {
                    explosionPower--;
                }
            }
            Console.WriteLine(afterExplosion);
        }
    }
}
