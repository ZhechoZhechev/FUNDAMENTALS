using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    class Program
    {
        static void Main()
        {
            int numberOfPairs = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> studentsAndGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberOfPairs; i++)
            {
                string studenName = Console.ReadLine();
                double studenGrade = double.Parse(Console.ReadLine());

                if (!studentsAndGrades.ContainsKey(studenName))
                {
                    studentsAndGrades.Add(studenName, new List<double>());
                    studentsAndGrades[studenName].Add(studenGrade);
                }
                else studentsAndGrades[studenName].Add(studenGrade);
            }
            foreach (var student in studentsAndGrades.Where(x => x.Value.Average() >= 4.50))
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}
