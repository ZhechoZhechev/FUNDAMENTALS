using System;

namespace _05._Login
{
    class Program
    {
        static void Main()
        {
            string userName = Console.ReadLine();
            string AcctualPass = "";
            for (int i = userName.Length -1; i >= 0 ; i--)
            {
                AcctualPass += userName[i];
            }
            int wrongPassCount = 0;
            string givenPass = Console.ReadLine();
            while (AcctualPass != givenPass) 
            {
                wrongPassCount++;
                if (wrongPassCount > 3)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                givenPass = Console.ReadLine();
            }
                Console.WriteLine($"User {userName} logged in.");
        }
    }
}
