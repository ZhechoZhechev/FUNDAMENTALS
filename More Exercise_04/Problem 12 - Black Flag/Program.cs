using System;

namespace Problem_12___Black_Flag
{
    class Program
    {
        static void Main()
        {
            int plunderDays = int.Parse(Console.ReadLine());
            int plunderPerDay = int.Parse(Console.ReadLine());
            double plunderToReach = double.Parse(Console.ReadLine());

            double totalPlunder = 0;

            for (int day = 1; day <= plunderDays ; day++)
            {
                totalPlunder += plunderPerDay;
                
                if (day % 3 == 0)
                {
                    totalPlunder += plunderPerDay * 0.5;
                }
                
                if (day % 5 == 0)
                {
                    totalPlunder = totalPlunder * 0.7;
                }
                
            }

            if (totalPlunder >= plunderToReach)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                Console.WriteLine($"Collected only {(totalPlunder / plunderToReach) * 100:f2}% of the plunder.");
            }
        }
    }
}
