using System;

namespace Problem_11___Bonus_Scoring_System
{
    class Program
    {
        static void Main()
        {
            int numOfStidents = int.Parse(Console.ReadLine());
            int numOfLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            double totalBonus = double.MinValue;
            int currAttendance = 0;

            if (numOfLectures == 0)
            {
                Console.WriteLine($"Max Bonus: 0.");
                Console.WriteLine($"The student has attended 0 lectures.");
                return;
            }

            for (int i = 1; i <= numOfStidents; i++)
            {
                double currStudentBonus = 0;
                int studentAttendance = int.Parse(Console.ReadLine());
                //{total bonus} = {student attendances} / {course lectures} * (5 + {additional bonus})
                currStudentBonus = studentAttendance / (double)numOfLectures * (5 + additionalBonus);

                if (currStudentBonus > totalBonus)
                {
                    totalBonus = currStudentBonus;
                    currAttendance = studentAttendance;
                }

            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(totalBonus)}.");
            Console.WriteLine($"The student has attended {currAttendance} lectures.");

        }
    }
}
