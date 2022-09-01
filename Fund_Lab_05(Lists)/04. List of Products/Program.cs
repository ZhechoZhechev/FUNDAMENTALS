using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    class Program
    {
        static void Main()
        {
            int count = int.Parse(Console.ReadLine());

            List<string> result = new List<string>(count);

            for (int i = 0; i < count; i++)
            {
                string product = Console.ReadLine();
                result.Add(product);
            }
            
            result.Sort();
            int counter = 1;
            foreach (string word in result)
            {
                Console.WriteLine($"{counter}.{word}");
                counter++;
            }
        }
    }
}
