using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main()
        {
            int countOfStudents = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();
            
            for (int i = 1; i <= countOfStudents; i++)
            {
                string[] info = Console.ReadLine().Split();
                Student student = new Student(info[0], info[1], double.Parse(info[2]));
                students.Add(student);
            }
            Console.WriteLine(string.Join($"{Environment.NewLine}", students.OrderByDescending(x => x.Grade)));
        }
    }

    class Student 
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LasttName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LasttName { get; set; }
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LasttName}: {Grade:f2}";
        }
    }
}
