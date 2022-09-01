using System;
using System.Numerics;

namespace _11.SnowBalls
{
    class Program
    {
        static void Main()
        {
            int ballsNum = int.Parse(Console.ReadLine());
            int topSnowballSnow = 0;
            int topSnowballTime = 0;
            int topSnowballQuality = 0;
            BigInteger topSnowballValue = 0;
            for (int i = 1; i <= ballsNum; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                //For each snowball you must calculate its snowballValue by the following formula:
                //(snowballSnow / snowballTime) ^ snowballQuality
                BigInteger snowballValue = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);
                if (snowballValue > topSnowballValue)
                {
                    topSnowballSnow = snowballSnow;
                    topSnowballTime = snowballTime;
                    topSnowballQuality = snowballQuality;
                    topSnowballValue = snowballValue;
                }
            }
            Console.WriteLine($"{topSnowballSnow} : {topSnowballTime} = {topSnowballValue} ({topSnowballQuality})");
        }
    }
}
