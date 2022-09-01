using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main()
        {
            int pplNum = int.Parse(Console.ReadLine());
            int elevatorCapacyty = int.Parse(Console.ReadLine());
            int coursesCount = 0;
           
            if (pplNum % elevatorCapacyty == 0)
            {
                coursesCount = pplNum / elevatorCapacyty;
            }
            else
            {
                coursesCount = (pplNum / elevatorCapacyty) + 1; ;
            }
            Console.WriteLine(coursesCount);
        }
    }
}
