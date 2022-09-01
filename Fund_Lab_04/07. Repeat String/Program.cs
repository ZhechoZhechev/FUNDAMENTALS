using System;
using System.Linq;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main()
        {
            string @string = Console.ReadLine();
            int repeats = int.Parse(Console.ReadLine());
            Console.WriteLine(RepeatedString(@string, repeats));
        }

        static string RepeatedString(string @string, int repeats) 
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i <= repeats; i++)
            {
                result.Append(@string);
            }
            return result.ToString();
        }
    }
}
