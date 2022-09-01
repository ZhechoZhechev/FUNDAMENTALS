using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main()
        {
            string[] firstArr = Console.ReadLine().Split();
            string[] secondArr = Console.ReadLine().Split();

            for (int i = 0; i < firstArr.Length; i++)
            {
                for (int j = 0; j < secondArr.Length; j++)
                {
                    if (firstArr[i] == secondArr[j])
                    {
                        Console.Write($"{firstArr[i]}" + " ");
                        break;
                    }
                }
            }
        }
    }
}
