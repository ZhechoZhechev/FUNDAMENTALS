using System;

namespace Problem_1___Guinea_Pig
{
    class Program
    {
        static void Main(string[] args)
        {
            //if (i == liftCabins.Length - 1 && peopleWaiting < 4 ) //
            //{
            //    liftCabins[i] += peopleWaiting;
            //    Console.WriteLine($"The lift has empty spots!");
            //    Console.WriteLine(string.Join(" ", liftCabins));
            //    break;
            //}
            //if (i == liftCabins.Length - 1 && peopleWaiting > 4)
            //{
            //    Console.WriteLine($"There isn't enough space! {peopleWaiting} people in a queue!");
            //    Console.WriteLine(string.Join(" ", liftCabins));
            //    break;
            //}
            //if (i == liftCabins.Length - 2 && peopleWaiting == 4)
            //{
            //    liftCabins[i + 1] = 4;
            //    Console.WriteLine(string.Join(" ", liftCabins));
            //    break;
            //}



            //· On the first line – quantity food in kilograms - a floating - point number in the range[0.0…10000.0].
            //· On the second line – quantity hay in kilograms - a floating - point number in the range[0.0…10000.0].
            //· On the third line – quantity cover in kilograms - a floating - point number in the range[0.0…10000.0].
            //· On the fourth line – guinea's weight in kilograms - a floating-point number in the range [0.0…10000.0].

            double food = double.Parse(Console.ReadLine()) * 1000;
            double hay = double.Parse(Console.ReadLine()) * 1000;
            double cover = double.Parse(Console.ReadLine()) * 1000;
            double weight = double.Parse(Console.ReadLine()) * 1000;

            for (int i = 1; i <= 30; i++)
            {
                food -= 300;
                if (i % 2 == 0)
                {
                    hay -= food * 0.05;
                }
                if (i % 3 == 0 )
                {
                    cover -= weight / 3;
                }
                if (food <= 0 || cover <= 0 || hay <= 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }
            Console.WriteLine($"Everything is fine! Puppy is happy! Food: {food/1000:f2}, Hay: {hay/1000:f2}, Cover: {cover/1000:f2}.");
            
        }
    }
}
