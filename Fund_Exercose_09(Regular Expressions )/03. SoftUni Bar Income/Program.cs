using System;
using System.Text.RegularExpressions;

namespace _03._SoftUni_Bar_Income
{
    class Program
    {
        static void Main()
        {
            string regex = @"%(?<name>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<quantity>\d+)\|[^|$%.]*?(?<price>\d+([.]\d+)?)\$";

            string input = string.Empty;

            double totalIncome = 0;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                Match data = Regex.Match(input, regex);
                if (data.Success)
                {
                    double currentCustSpent = 0;

                    string customer = data.Groups["name"].Value;
                    string product = data.Groups["product"].Value;
                    int quantity = int.Parse(data.Groups["quantity"].Value);
                    double price = double.Parse(data.Groups["price"].Value);

                    currentCustSpent = quantity * price;

                    totalIncome += currentCustSpent;

                    Console.WriteLine($"{customer}: {product} - {currentCustSpent:f2}");
                }
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
