using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                bool isPalindrome = IsPalinfrome(input);
                Console.WriteLine(isPalindrome.ToString().ToLower());
            }

        }

        private static bool IsPalinfrome(string input)
        {
            int number = int.Parse(input);
            int tempValue = number;
            int reverse = 0;
            while (tempValue > 0)
            {
                reverse = reverse * 10 + tempValue % 10;
                tempValue /= 10;
            }
            if (number == reverse)
            {
                return true;
            }
            return false;
        }
    }
}
