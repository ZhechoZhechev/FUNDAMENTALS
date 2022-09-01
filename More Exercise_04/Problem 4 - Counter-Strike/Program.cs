using System;

namespace Problem_4___Counter_Strike
{
    class Program
    {
        static void Main()
        {
            int myEnergy = int.Parse(Console.ReadLine());

            string input = string.Empty;
            int battlesWonCount = 0;

            while ((input = Console.ReadLine()) != "End of battle")
            {
                int distance = int.Parse(input);
                if (myEnergy >= distance)
                {
                    myEnergy -= distance;
                    battlesWonCount++;
                    if (battlesWonCount % 3 == 0) myEnergy += battlesWonCount;
                }
                else
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battlesWonCount} won battles and {myEnergy} energy");
                    return;
                   
                }
            }
            Console.WriteLine($"Won battles: {battlesWonCount}. Energy left: {myEnergy}");
        }
    }
}
