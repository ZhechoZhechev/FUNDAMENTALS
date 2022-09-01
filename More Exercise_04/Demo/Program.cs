using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main()
        {

            Random randomSix = new Random();


            List<int> winningNums = new List<int>();

            SixFromFortyNineNums(randomSix, winningNums);


        }

        private static void SixFromFortyNineNums(Random randomSix, List<int> winningNums)
        {


            while (winningNums.Count < 6)
            {
                int number = randomSix.Next(1, 50);
                if (!winningNums.Contains(number))
                {
                    winningNums.Add(number);
                }
            }
            winningNums.Sort();

            Console.WriteLine(string.Join(", ", winningNums));


        }
    }
}
