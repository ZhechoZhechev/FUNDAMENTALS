using System;

namespace Problem_1
{
    class Program
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            int studens = int.Parse(Console.ReadLine());
            double priceFlour = double.Parse(Console.ReadLine());
            double priceSingleEgg = double.Parse(Console.ReadLine());
            double priceApron = double.Parse(Console.ReadLine());

            int freeFlourPacks = studens / 5;
            //for (int i = 1; i < studens; i++)
            //{
            //    if (studens % 5 == 0)
            //    {
            //        freeFlourPacks++;
            //    }
            //}

            double totalFlour = priceFlour * (studens - freeFlourPacks);

            double totalForEggs = studens * priceSingleEgg * 10;
            
            double additionalAprons = Math.Ceiling(studens * 0.20);
            double totalforAprons = priceApron * (studens + additionalAprons);

            double totaCost = totalFlour + totalForEggs + totalforAprons;

            if (totaCost <= budget)
            {
                Console.WriteLine($"Items purchased for {totaCost:f2}$.");
            }
            else
            {
                double moneyNeeded = totaCost - budget;
                Console.WriteLine($"{moneyNeeded:f2}$ more needed.");
            }
        }
    }
}
