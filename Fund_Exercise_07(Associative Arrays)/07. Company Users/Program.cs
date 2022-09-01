using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    class Program
    {
        static void Main()
        {
            string input = string.Empty;

            Dictionary<string, List<String>> companiesAndEmployees = new Dictionary<string, List<string>>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] info = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string company = info[0];
                string employeId = info[1];
                if (!companiesAndEmployees.ContainsKey(company))
                {
                    companiesAndEmployees.Add(company, new List<string>());
                    companiesAndEmployees[company].Add(employeId);
                }
                else if (companiesAndEmployees.ContainsKey(company) && !companiesAndEmployees[company].Contains(employeId))
                {
                    companiesAndEmployees[company].Add(employeId);
                }
            }
            foreach (var company in companiesAndEmployees)
            {
                Console.WriteLine($"{company.Key}");
                Console.Write("-- ");
                Console.WriteLine(string.Join($"{Environment.NewLine}-- ", company.Value));
            }
        }
    }
}
