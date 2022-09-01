using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main()
        {
            char one = char.Parse(Console.ReadLine());
            char two = char.Parse(Console.ReadLine());
            char three = char.Parse(Console.ReadLine());

            string accumulate = "" + one + two + three;

            Console.WriteLine(accumulate);
        }
    }
}
