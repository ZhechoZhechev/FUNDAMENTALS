using System;

namespace _9._Spice_Must_Flow
{
    class Program
    {
        static void Main()
        {
            int startingSpice = int.Parse(Console.ReadLine());
            const int SPICE_SONSUMED_BY_WORKERS = 26;
            const int SPICE_DECEASE_EACH_DAY = 10;
            int totalSpiceGathered = 0;
            int daysCounter = 0;

            while (startingSpice >= 100)
            {
                totalSpiceGathered += (startingSpice - SPICE_SONSUMED_BY_WORKERS);
                startingSpice -= SPICE_DECEASE_EACH_DAY;
                daysCounter++;
                if (startingSpice < 100)
                {
                    totalSpiceGathered -= SPICE_SONSUMED_BY_WORKERS;
                }

            }
            Console.WriteLine(daysCounter);
            Console.WriteLine(totalSpiceGathered);



        }
    }
}
