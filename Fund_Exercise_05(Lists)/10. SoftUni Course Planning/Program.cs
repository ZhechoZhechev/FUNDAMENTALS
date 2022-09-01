using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main()
        {
            List<string> schedule = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string input = "";

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] commands = input.Split(":");
                string command = commands[0];

                switch (command)
                {
                    case "Add":
                        AddAlesson(commands, schedule);
                        break;
                    case "Insert":
                        InsertAlesson(commands, schedule);
                        break;
                    case "Remove":
                        LessonToRemove(commands, schedule);
                        break;
                    case "Swap":
                        SwapLessons(commands, schedule);
                        break;
                    case "Exercise":
                        ExerciseCase(commands, schedule);
                        break;
                }
            }
            int lessonIndex = 1;
            foreach (var lesson in schedule)
            {
                Console.WriteLine($"{lessonIndex}.{lesson}");
                lessonIndex++;
            }
        }

        private static void ExerciseCase(string[] commands, List<string> schedule)
        {
            string exrciseToAdd = commands[1];
            string exerciseString = $"{exrciseToAdd}-Exercise";
            if (schedule.Contains(exrciseToAdd))
            {
                if (!schedule.Contains(exerciseString))
                {
                    int leesonIndex = schedule.IndexOf(exrciseToAdd);
                    if (leesonIndex <= schedule.Count - 1)
                    {
                        schedule.Insert(leesonIndex + 1, exerciseString);
                    }
                    else
                    {
                        schedule.Add(exerciseString);
                    }
                }
            }
            else
            {
                schedule.Add(exrciseToAdd);
                schedule.Add(exerciseString);
            }
        }

        private static void SwapLessons(string[] commands, List<string> schedule)
        {
            string firstLessonToSwap = commands[1];
            string secondLessonToSwap = commands[2];
            int firstIndex = schedule.IndexOf(firstLessonToSwap);
            int secondIndex = schedule.IndexOf(secondLessonToSwap);
            if (schedule.Contains(firstLessonToSwap) && schedule.Contains(secondLessonToSwap))
            {
                string tempLesson = schedule[firstIndex];
                schedule[firstIndex] = schedule[secondIndex];
                schedule[secondIndex] = tempLesson;
            }
            if (schedule.Contains($"{firstLessonToSwap}-Exercise")) 
            {
                if (secondIndex + 1 < schedule.Count -1)
                {
                    string tempExerName = $"{firstLessonToSwap}-Exercise";
                    schedule.Remove($"{firstLessonToSwap}-Exercise");
                    schedule.Insert(secondIndex + 1, tempExerName);
                }
                else if (secondIndex + 1 > schedule.Count - 1)
                {
                    schedule.Add($"{firstLessonToSwap}-Exercise");
                    schedule.Remove($"{firstLessonToSwap}-Exercise");
                }
            }
            if (schedule.Contains($"{secondLessonToSwap}-Exercise"))
            {
                if (firstIndex + 1 < schedule.Count - 1)
                {
                    string tempExerName = $"{secondLessonToSwap}-Exercise";
                    schedule.Remove($"{secondLessonToSwap}-Exercise");
                    schedule.Insert(firstIndex + 1, tempExerName);
                }
                else if (firstIndex + 1 > schedule.Count - 1)
                {
                    schedule.Add($"{secondLessonToSwap}-Exercise");
                    schedule.Remove($"{secondLessonToSwap}-Exercise");
                }
            }
        }

        private static void LessonToRemove(string[] commands, List<string> schedule)
        {
            string LessonToremove = commands[1];
            if (schedule.Contains(LessonToremove))
            {
                schedule.Remove(LessonToremove);
                if (schedule.Contains($"{LessonToremove}-Exercise"))
                {
                    schedule.Remove(($"{LessonToremove}-Exercise"));
                }
            }
        }

        private static void InsertAlesson(string[] commands, List<string> schedule)
        {
            string lessonToInsert = commands[1];
            int index = int.Parse(commands[2]);
            if (!schedule.Contains(lessonToInsert))
            {
                schedule.Insert(index, lessonToInsert);
            }
            
        }

        private static void AddAlesson(string[] commands, List<string> schedule)
        {
            string LessonToAdd = commands[1];
            if (!schedule.Contains(LessonToAdd))
            {
                schedule.Add(LessonToAdd);
            }
        }
    }
}
