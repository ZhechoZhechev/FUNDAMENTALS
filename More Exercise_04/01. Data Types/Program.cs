using System;

namespace _01._Data_Types
{
    class Program
    {
        static void Main()
        {
            string commandOne = Console.ReadLine();
            
            switch (commandOne)
            {
                case "int":
                    int integer = int.Parse(Console.ReadLine());
                    ListenAndAct(integer);
                    break;
                case "real":
                    double @decimal = double.Parse(Console.ReadLine());
                    ListenAndAct(@decimal);
                    break;
                case "string":
                    string word = Console.ReadLine();
                    ListenAndAct(word);
                    break;
                    
            }

        }

        private static void ListenAndAct(int commandTwo) => Console.WriteLine(commandTwo * 2);
        private static void ListenAndAct(double commandTwo) => Console.WriteLine($"{commandTwo * 1.5:f2}");
        private static void ListenAndAct(string commandTwo) => Console.WriteLine($"${commandTwo}$");

    }
}
