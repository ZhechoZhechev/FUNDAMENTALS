using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightSaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double lightSaberCount = studentsCount + Math.Ceiling(studentsCount * 0.10);
            double beltsCount = studentsCount - (studentsCount / 6);
            double robesCount = studentsCount;

            double totalForSabers = lightSaberCount * lightSaberPrice;
            double totalForBelts = beltsCount * beltPrice;
            double totalForRobes = robesCount * robePrice;

            double totalNeeded = totalForSabers + totalForBelts + totalForRobes;
            if (budget >= totalNeeded)
            {
                Console.WriteLine($"The money is enough - it would cost {totalNeeded:f2}lv.");
            }
            else
            {
                double neededMore = totalNeeded - budget;
                Console.WriteLine($" John will need {neededMore:f2}lv more.");
            }

        }
    }
}
