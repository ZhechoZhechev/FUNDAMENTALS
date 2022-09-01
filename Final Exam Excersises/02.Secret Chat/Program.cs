using System;

namespace _02.Secret_Chat
{
    class Program
    {
        static void Main()
        {
            string tourStop = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Travel")
            {
                var info = input.Split(':', StringSplitOptions.RemoveEmptyEntries);

                var action = info[0];

                switch (action)
                {
                    case "Add Stop":
                        tourStop = AddString(tourStop, info);
                        break;
                    case "Remove Stop":
                        tourStop = RemoveString(tourStop, info);
                        break;
                    case "Switch":
                        tourStop = Switch(tourStop, info);
                        break;
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {tourStop}");
        }

        private static string Switch(string tourStop, string[] info)
        {
            string oldString = info[1];
            string newString = info[2];
            tourStop = tourStop.Replace(oldString, newString);
            Console.WriteLine(tourStop);
            return tourStop;
        }

        private static string RemoveString(string tourStop, string[] info)
        {
            int startIndex = int.Parse(info[1]);
            int endIndex = int.Parse(info[2]);
            if (startIndex >= 0 && endIndex >= 0 && startIndex <= tourStop.Length - 1 && endIndex <= tourStop.Length - 1)
            {
                tourStop = tourStop.Remove(startIndex, endIndex - startIndex + 1);
            }
            Console.WriteLine(tourStop);
            return tourStop;
        }

        private static string AddString(string tourStop, string[] info)
        {
            int index = int.Parse(info[1]);
            string stringToAdd = info[2];

            if (index >= 0 && index <= tourStop.Length - 1)
            {
                tourStop = tourStop.Insert(index, stringToAdd);
            }
            Console.WriteLine(tourStop);
            return tourStop;
        }
    }
}
