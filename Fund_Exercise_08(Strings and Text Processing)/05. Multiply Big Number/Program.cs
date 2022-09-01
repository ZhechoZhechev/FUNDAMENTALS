using System;
using System.Linq;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main()
        {
            string firstNumber = Console.ReadLine();
            int secondNumber = int.Parse(Console.ReadLine());

            StringBuilder result = new StringBuilder();
            int remainder = 0;

            if (secondNumber == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = firstNumber.Length -1; i >= 0; i--)
            {
                int currNumber = int.Parse(firstNumber[i].ToString());
                int multiplication = secondNumber * currNumber;
                int total = multiplication + remainder;

                result.Append(total % 10);
                remainder = total / 10;
                
            }
            if (remainder != 0) result.Append(remainder);

            string reversed = new string(result.ToString().Reverse().ToArray());
            Console.WriteLine(reversed);

        }
    }
}
