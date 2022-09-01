using System;
using System.Linq;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main()
        {
            string ourText = Console.ReadLine();

            char[] digits = ourText.Where(x => char.IsDigit(x)).ToArray();
            char[] letters = ourText.Where(x => char.IsLetter(x)).ToArray();
            char[] others = ourText.Where(x => !char.IsLetterOrDigit(x)).ToArray();

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(others);
        }
    }
}
