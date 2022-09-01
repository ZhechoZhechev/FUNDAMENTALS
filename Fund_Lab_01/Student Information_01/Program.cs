using System;

namespace Student_Information_01
{
    class Program
    {
        static void Main()
        {
            string studenName = Console.ReadLine();
            int studentAge = int.Parse(Console.ReadLine());
            double averageGrade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {studenName}, Age: {studentAge}, Grade: {averageGrade:f2}");

        }
    }
}
