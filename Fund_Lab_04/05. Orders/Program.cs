using System;

namespace _05._Orders
{
    class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculation(product, quantity));
        }

        static string Calculation(string product, int quantity) 
        {
            double totalPrice = 0;
            switch (product)
            {
                case "coffee":
                    totalPrice = quantity * 1.50;
                    break;
                case "water":
                    totalPrice = quantity * 1.00;
                    break;
                case "coke":
                    totalPrice = quantity * 1.40;
                    break;
                case "snacks":
                    totalPrice = quantity * 2.00;
                    break;
            }
            return ($"{totalPrice:f2}");
            //return String.Format("{0:0.00}", totalPrice);
        }
    }
}
