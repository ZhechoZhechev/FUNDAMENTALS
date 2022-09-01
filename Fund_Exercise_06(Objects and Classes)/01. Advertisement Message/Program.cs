using System;

namespace _01._Advertisement_Message
{
    class Program
    {
        static void Main()
        {
            string[] phrases = new string[]
            {
                "Excellent product.", "Such a great product.",
                "I always use that product.", "Best product of its category.",
                "Exceptional product.", "I can't live without this product."
            };
            string[] events = new string[]
            {
                "Now I feel good.", "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.", "I feel great!"
            };
            string[] authors = new string[]
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };
            string[] cities = new string[]
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            int messagesCount = int.Parse(Console.ReadLine());
            
            Random random = new Random();
            
            for (int i = 1; i <= messagesCount; i++)
            {
                Console.WriteLine($"{phrases[random.Next(0, phrases.Length)]} {events[random.Next(0, events.Length)]}" +
                    $" {authors[random.Next(0, authors.Length)]} – {cities[random.Next(0, cities.Length)]}.");
            }
        }
    }
}
