using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main()
        {
            int pplCount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string weekDay = Console.ReadLine();
            double totalVacationPrice = 0;

            if (groupType == "Students")
            {
                if (weekDay == "Friday")
                {
                    totalVacationPrice = pplCount * 8.45;
                }
                else if (weekDay == "Saturday")
                {
                    totalVacationPrice = pplCount * 9.80;
                }
                else if (weekDay == "Sunday")
                {
                    totalVacationPrice = pplCount * 10.46;
                }
                if (pplCount >= 30)
                {
                    totalVacationPrice *= 0.85;
                }
                
            }
            if (groupType == "Business")
            {
                if (weekDay == "Friday")
                {
                    totalVacationPrice = pplCount * 10.90;
                }
                else if (weekDay == "Saturday")
                {
                    totalVacationPrice = pplCount * 15.60;
                }
                else if (weekDay == "Sunday")
                {
                    totalVacationPrice = pplCount * 16;
                }
                if (pplCount >= 100)
                {
                    totalVacationPrice -= totalVacationPrice / pplCount * 10;
                }
            }
            if (groupType == "Regular")
            {
                if (weekDay == "Friday")
                {
                    totalVacationPrice = pplCount * 15;
                }
                else if (weekDay == "Saturday")
                {
                    totalVacationPrice = pplCount * 20;
                }
                else if (weekDay == "Sunday")
                {
                    totalVacationPrice = pplCount * 22.50;
                }
                if (pplCount >= 10 && pplCount <= 20)
                {
                    totalVacationPrice *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {totalVacationPrice:f2}");
        }
    }
}
