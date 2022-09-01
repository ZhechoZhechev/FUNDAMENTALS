using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main()
        {
            int lostGamesNum = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetsTrashed = lostGamesNum / 2;
            int mousesTrashed = lostGamesNum / 3;
            int keyboardsTrashed = lostGamesNum /6;
            int displaysTrashed = keyboardsTrashed / 2;

            double total = (headsetPrice * headsetsTrashed) + (mousePrice * mousesTrashed)
                + (keyboardsTrashed * keyboardPrice) + (displaysTrashed * displayPrice);

            Console.WriteLine($"Rage expenses: {total:f2} lv.");
        }
    }
}
