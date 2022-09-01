using System;
using System.Text.RegularExpressions;

namespace _07._Winning_Ticket
{
    class Program
    {
        static void Main()
        {
            string[] tickets = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
           //string patternSep = @"[,+\s+]";
            string pattern = @"(\@{6,}|\${6,}|\^{6,}|\#{6,})";

            //string[] tickets = Regex.Split(input, patternSep);

            for (int i = 0; i < tickets.Length; i++)
            {
                if (tickets[i].Length == 20)
                {
                    Match firstHalf = Regex.Match(tickets[i].Substring(0, 10), pattern);
                    Match secondHalf = Regex.Match(tickets[i].Substring(10), pattern);
                    int minLength = Math.Min(firstHalf.Length, secondHalf.Length);

                    if (firstHalf.Success && secondHalf.Success)
                    {
                        string winFirstHalf = firstHalf.Value.Substring(0, minLength);
                        string winSecondHalf = secondHalf.Value.Substring(0, minLength);

                        if (winFirstHalf.Equals(winSecondHalf))
                        {
                            if (winFirstHalf.Length == 10)
                            {
                                Console.WriteLine($"ticket \"{tickets[i]}\" - {minLength}{winFirstHalf.Substring(0, 1)} Jackpot!");
                            }
                            else
                            {
                                Console.WriteLine($"ticket \"{tickets[i]}\" - {minLength}{winFirstHalf.Substring(0, 1)}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{tickets[i]}\" - no match");
                    }
                }
                else
                {
                    Console.WriteLine("invalid ticket");
                }
            }
        }
    }
}

