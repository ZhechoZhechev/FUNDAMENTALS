using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main()
        {
            string regex = @"\+359([ -])2\1\d{3}\1\d{4}\b";
            
            string telephoneNums = Console.ReadLine();

            MatchCollection phoneNumMatches = Regex.Matches(telephoneNums, regex);

            Console.WriteLine(string.Join(", ", phoneNumMatches));
        }
    }
}
