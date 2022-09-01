using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _22.Rage_Quit
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string substrings = @"[\D]+";
            string multipliers = @"[0-9]+";

            List<string> strings = new List<string>(); 
            List<int> multiNums = new List<int>();

            MatchCollection strs = Regex.Matches(input, substrings);
            MatchCollection nums = Regex.Matches(input, multipliers);

            //StringBuilder onlyTheLett = new StringBuilder(); 

            foreach (Match item in strs)
            {
                strings.Add(item.ToString());
                //onlyTheLett.Append(item);
            }
            foreach (Match num in nums)
            {
                multiNums.Add(int.Parse(num.ToString()));
            }


            StringBuilder result = new StringBuilder();

            for (int i = 0; i < strings.Count; i++)
            {
                string repeated = String.Concat(Enumerable.Repeat(strings[i], multiNums[i]));
                result.Append(repeated.ToUpper());
            }
            int UniqueLetCount = result.ToString().ToLower().Distinct().Count();

            Console.WriteLine($"Unique symbols used: {UniqueLetCount}");
            Console.WriteLine(result);
        }
    }
}
