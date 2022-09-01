using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            
            string[] daysOfweek =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday",
                "Sunday"
            };
            if (num < 1 || num > 7)
            {
                Console.WriteLine("Invalid day!");
            }
            else
            {
                Console.WriteLine(daysOfweek[num - 1]);
            }

        }
    }
}
