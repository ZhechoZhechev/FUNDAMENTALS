using System;
using System.Linq;

namespace _04._Word_Filter
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split();

            string[] evenCharCountWords = words.Where(x => x.Length % 2 == 0).ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, evenCharCountWords));
        }
    }
}
