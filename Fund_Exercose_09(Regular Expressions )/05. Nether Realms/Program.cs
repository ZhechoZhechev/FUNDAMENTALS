using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    class Program
    {
        static void Main()
        {
            string damageRegex = @"(?:\+|-)?[0-9]+(?:\.[0-9]+)?";
            string healthRegex = @"[^\d\+\-*\/\.]";
            string multiOrDivide = @"[\*\/]";
            string splitRegex = @"[,\s]+";

            string input = Console.ReadLine();
            string[] demonNames = Regex.Split(input, splitRegex).OrderBy(x => x).ToArray();

            for (int i = 0; i < demonNames.Length; i++)
            {
                string currDemon = demonNames[i];

                double curDemonDmgCalc = 0;
                double curDemonHealthCalc = 0;

                MatchCollection currDemonDmg = Regex.Matches(currDemon, damageRegex);
                foreach (Match num in currDemonDmg)
                {
                    curDemonDmgCalc += double.Parse(num.ToString());
                }
                MatchCollection divideOrMulty = Regex.Matches(currDemon, multiOrDivide);
                foreach (Match @operator in divideOrMulty)
                {
                    char currOperator = char.Parse(@operator.ToString());
                    if (currOperator == '*')
                    {
                        curDemonDmgCalc *= 2;
                    }
                    else
                    {
                        curDemonDmgCalc /= 2;
                    }
                }
                MatchCollection curDemonHealth = Regex.Matches(currDemon, healthRegex);
                foreach (Match ch in curDemonHealth)
                {
                    char curValue = char.Parse(ch.ToString());
                    curDemonHealthCalc += curValue;
                }
                Console.WriteLine($"{currDemon} - {curDemonHealthCalc} health, {curDemonDmgCalc:f2} damage");
            }
        }
    }
}
