using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main()
        {
            int kegsCount = int.Parse(Console.ReadLine());
            double biggestVolume = 0;
            string biggestKegName = "";

            for (int i = 1; i <= kegsCount; i++)
            {
                string kegModel = Console.ReadLine();
                double kegRadius = double.Parse(Console.ReadLine());
                int kegHeight = int.Parse(Console.ReadLine());

                double kegVolume = Math.PI * Math.Pow(kegRadius, 2) * kegHeight;
                if (kegVolume > biggestVolume)
                {
                    biggestVolume = kegVolume;
                    biggestKegName = kegModel;
                }
            }
            Console.WriteLine(biggestKegName);
        }
    }
}
