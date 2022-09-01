using System;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main()
        {
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string stringToInvert = input;

                string invertedString = string.Empty;

                for (int i = stringToInvert.Length - 1; i >= 0; i--)
                {
                    invertedString += stringToInvert[i];
                }
                Console.WriteLine($"{stringToInvert} = {invertedString}");
            }
        }
    }
}
