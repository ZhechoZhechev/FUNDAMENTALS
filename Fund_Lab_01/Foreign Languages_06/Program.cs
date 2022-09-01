using System;

namespace Foreign_Languages_06
{
    class Program
    {
        static void Main()
        {
            string countryName = Console.ReadLine();

            switch (countryName)
            {
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;
                case "Spain":
                case "Argentina":
                case "Mexico":
                    Console.WriteLine("Spanish");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
