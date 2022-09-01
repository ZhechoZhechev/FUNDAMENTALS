using System;

namespace _03._Substring
{
    class Program
    {
        static void Main()
        {
            string strToremove = Console.ReadLine();
            string initialString = Console.ReadLine();

            while (initialString.Contains(strToremove))
            {
                initialString = initialString.Replace(strToremove, string.Empty);
            }
            Console.WriteLine(initialString);
        }
    }
}
