using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main()
        {
            int lettersCount = int.Parse(Console.ReadLine());
            int sumOfChars = 0;

            for (int i = 1; i <= lettersCount; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                sumOfChars += (int)letter; 
            }
            Console.WriteLine($"The sum equals: {sumOfChars}");
        }
    }
}
