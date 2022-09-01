using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main()
        {
            double numOne = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            double numTwo = double.Parse(Console.ReadLine());
            Console.WriteLine(Calculator(numOne, command, numTwo));
        }

        static double Calculator(double first, string @operator, double second) 
        {
            double result = 0;
            switch (@operator)
            {
                case "/":
                    result = first / second;
                    break;
                case "*":
                    result = first * second;
                    break;
                case "+":
                    result = first + second;
                    break;
                case "-":
                    result = first - second;
                    break;
            }
            return result;
        }
    }
}
