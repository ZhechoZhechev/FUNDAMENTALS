using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isSixToTenChars = IsSixToTenValidation(password);
            bool isOnlyLettsAndDiggits = IsLettAndDiggVallidation(password);
            bool containsAtleastTwoDiggits = DoesItContainAtLeastTwoDiggits(password);

            if (!isSixToTenChars)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isOnlyLettsAndDiggits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!containsAtleastTwoDiggits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isSixToTenChars && isOnlyLettsAndDiggits && containsAtleastTwoDiggits)
            {
                Console.WriteLine("Password is valid");
            }

        }

        private static bool DoesItContainAtLeastTwoDiggits(string password)
        {
            int count = 0;
            foreach (var symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    count++;
                }
            }
            if (count >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsLettAndDiggVallidation(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
                return true;
        }

        private static bool IsSixToTenValidation(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
    }
}
