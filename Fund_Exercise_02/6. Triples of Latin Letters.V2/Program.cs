using System;

namespace _6._Triples_of_Latin_Letters.V2
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    for (int k = 0; k < number; k++)
                    {
                        char one = (char)('a' + i);
                        char two = (char)('a' + j);
                        char three = (char)('a' + k);

                        Console.WriteLine($"{one}{two}{three}");
                    }
                }
            }
        }
    }
}
