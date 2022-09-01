using System;
using System.Linq;

namespace Problem_3
{
    class Program
    {
        static void Main()
        {
            var books = Console.ReadLine().Split("&").ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] commands = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);
                string action = commands[0];

                switch (action)
                {
                    case "Add Book":
                        string bookToAdd = commands[1];
                        if (!books.Contains(bookToAdd))
                        {
                            books.Insert(0, bookToAdd);
                        }
                        break;
                    case "Take Book":
                        string bookToremove = commands[1];
                        if (books.Contains(bookToremove))
                        {
                            books.Remove(bookToremove);
                        }
                        break;
                    case "Swap Books":
                        string firstBook = commands[1];
                        string secondBook = commands[2];
                        if (books.Contains(firstBook) && books.Contains(secondBook))
                        {
                            int indexOfFirst = books.IndexOf(firstBook);
                            int indexOfSecond = books.IndexOf(secondBook);
                            string backUpBook = books[indexOfFirst];
                            books[indexOfFirst] = books[indexOfSecond];
                            books[indexOfSecond] = backUpBook;
                        }
                        break;
                    case "Insert Book":
                        string bookToInsert = commands[1];
                        if (!books.Contains(bookToInsert))
                        {
                            books.Add(bookToInsert);
                        }
                        break;
                    case "Check Book":
                        int index = int.Parse(commands[1]);
                        if (index >= 0 && index <= books.Count - 1)
                        {
                            Console.WriteLine(books[index]);
                        }
                        break;
                }

            }
            Console.WriteLine(string.Join(", ", books));
        }
    }
}
