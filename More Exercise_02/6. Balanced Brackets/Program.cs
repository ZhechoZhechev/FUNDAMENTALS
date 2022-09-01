using System;

namespace _6._Balanced_Brackets
{
    class Program
    {
        static void Main()
        {
            int stringsCount = int.Parse(Console.ReadLine());
            int openBraketsCount = 0;
            int closeBraketsCount = 0;


            for (int i = 1; i <= stringsCount; i++)
            {
                string currentString = Console.ReadLine();

                if (currentString == "(")
                {
                    openBraketsCount++;
                }
                else if (currentString == ")")
                {
                    closeBraketsCount++;
                    if (openBraketsCount - closeBraketsCount != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
                
            }
            if (openBraketsCount == closeBraketsCount)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
