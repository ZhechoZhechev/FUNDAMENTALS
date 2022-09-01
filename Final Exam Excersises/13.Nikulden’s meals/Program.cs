using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.Nikulden_s_meals
{
    class Guests
    {
        public string GuestName { get; set; }

        public List<string> Meal = new List<string>();
    }
    class Program
    {

        static void Main()
        {
            List<Guests> guests = new List<Guests>();

            List<string> unlikedMeals = new List<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Stop")
            {
                var commands = input.Split("-", StringSplitOptions.RemoveEmptyEntries);
                var action = commands[0];
                var guest = commands[1];
                var meal = commands[2];


                switch (action)
                {
                    case "Like":
                        if (!guests.Any(x => x.GuestName == guest))
                        {
                            Guests guestToAdd = new Guests
                            {
                                GuestName = guest,
                                Meal = new List<string>() { meal }
                            };
                            guests.Add(guestToAdd);
                        }
                        else if (guests.Any(x => x.GuestName == guest) && !guests.Any(y => y.Meal.Contains(meal)))
                        {
                            var addedGuest = guests.FirstOrDefault(x => x.GuestName == guest);
                            addedGuest.Meal.Add(meal);
                        }
                        break;
                    case "Dislike":
                        var curGuest = guests.FirstOrDefault(x => x.GuestName == guest);
                        if (guests.Any(x => x.GuestName == guest))
                        {
                            if (curGuest.Meal.Contains(meal))
                            {
                                curGuest.Meal.Remove(meal);
                                unlikedMeals.Add(meal);
                                Console.WriteLine($"{guest} doesn't like the {meal}.");
                            }
                            else
                            {
                                Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"{guest} is not at the party.");
                        }
                        break;
                }
            }
            foreach (var guest in guests)//.OrderByDescending(x => x.Meal.Count).ThenBy(y => y.GuestName))
            {
                Console.WriteLine($"{guest.GuestName}: {string.Join(", ", guest.Meal)}");
            }
            Console.WriteLine($"Unliked meals: {unlikedMeals.Count}");
        }
    }
}
