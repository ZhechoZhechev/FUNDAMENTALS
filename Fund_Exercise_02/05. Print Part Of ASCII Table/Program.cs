using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main()
        {
            int intervalStart = int.Parse(Console.ReadLine());
            int intervalEnd = int.Parse(Console.ReadLine());
            string sumOfChars = "";

            for (int currentChar = intervalStart; currentChar <= intervalEnd; currentChar++)
            {
                sumOfChars += (char)currentChar + " ";
            }
            Console.WriteLine(sumOfChars);
        }
    }
}
