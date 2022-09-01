using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Courses
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, List<string>> studentsByCourses = new Dictionary<string, List<string>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] info = input.Split(" : ");
                string courseName = info[0];
                string studentName = info[1];

                if (!studentsByCourses.ContainsKey(courseName))
                {
                    studentsByCourses.Add(courseName, new List<string>());
                    studentsByCourses[courseName].Add(studentName);
                }
                else
                {
                    studentsByCourses[courseName].Add(studentName);
                }
            }
            foreach (var course in studentsByCourses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                Console.Write("-- ");
                Console.WriteLine(string.Join($"{Environment.NewLine}-- ", course.Value));
            }
        }
    }
}
