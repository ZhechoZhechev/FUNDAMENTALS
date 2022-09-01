using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main()
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distBetweenTargets = int.Parse(Console.ReadLine());
            int esxhaustionFactor = int.Parse(Console.ReadLine());
            int targetsCount = 0;
            int pokePowerCopy = pokePower;

            while (pokePower >= distBetweenTargets)
            {
                pokePower -= distBetweenTargets;
                targetsCount++;
                if (pokePower * 2 == pokePowerCopy && esxhaustionFactor > 0)
                {
                    pokePower /= esxhaustionFactor;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(targetsCount);
        }
    }
}
