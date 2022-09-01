using System;

namespace _11._Orders
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            double totalAccumulated = 0;

            for (int i = 1; i <= num; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double coffePrice = ((days * capsulesCount) * pricePerCapsule);
                totalAccumulated += coffePrice;
                Console.WriteLine($"The price for the coffee is: ${coffePrice:f2}");
            }
            Console.WriteLine($"Total: ${totalAccumulated:f2}");
        }
    }
}
