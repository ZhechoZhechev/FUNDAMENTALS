using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Student 
    {
        public Student(string firstName, string lastName, int age, string homeTown) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }

    class Program
    {
        static void Main()
        {
            string input = string.Empty;

            var students = new List<Student>();

            while ((input = Console.ReadLine()) != "end")
            {
                var data = input.Split().ToList();

                Student student = new Student(data[0], data[1], int.Parse(data[2]), data[3]);

                students.Add(student);

            }
            string cityName = Console.ReadLine();

            foreach (Student student in students)
            {
                if (cityName == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
