using System;
using System.Linq;

namespace _02._The_Lift
{
    class Program
    {
        static void Main()
        {
            int peopleWaiting = int.Parse(Console.ReadLine());
            int[] liftCabins = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i <= liftCabins.Length - 1; i++)
            {
                int maxPerCabin =Math.Min(4 - liftCabins[i], peopleWaiting);
                liftCabins[i] += maxPerCabin;
                peopleWaiting -= maxPerCabin;
            }
            int notFullCarts = 0;
            foreach (int cart in liftCabins)
            {
                if (cart < 4)
                {
                    notFullCarts++;
                }
            }
            if (peopleWaiting > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
            }
            else if (peopleWaiting == 0 && notFullCarts > 0)
            {
                Console.WriteLine($"The lift has empty spots!");
            }
            else if (peopleWaiting == 0 && liftCabins[liftCabins.Length -1] == 4)
            {
                Console.WriteLine(string.Join(" ", liftCabins));
                return;
            }
            Console.WriteLine(string.Join(" ", liftCabins));
        }
    }
}
