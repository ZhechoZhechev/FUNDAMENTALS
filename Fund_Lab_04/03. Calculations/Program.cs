using System;

namespace _03._Calculations
{
    class Program
    {
        static void Main()
        {
            string command = Console.ReadLine();
            int numOne = int.Parse(Console.ReadLine());
            int numTwo = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add":
                    AddTwoNums(numOne, numTwo);
                    break;
                case "multiply":
                    MultyTwoNums(numOne, numTwo);
                    break;
                case "subtract":
                    SubstrTwoNums(numOne, numTwo);
                    break;
                case "divide":
                    DivideTwoNums(numOne, numTwo);
                    break;
            }
        }
        static void AddTwoNums(int numOne, int numTwo) 
        {
            Console.WriteLine(numOne+numTwo);
        }

        static void MultyTwoNums(int numOne, int numTwo)
        {
            Console.WriteLine(numOne * numTwo);
        }

        static void SubstrTwoNums(int numOne, int numTwo)
        {
            Console.WriteLine(numOne - numTwo);
        }

        static void DivideTwoNums(int numOne, int numTwo)
        {
            Console.WriteLine(numOne / numTwo);
        }
    }
}
