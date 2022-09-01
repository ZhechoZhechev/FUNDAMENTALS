using System;

namespace _02._Articles
{
    class Program
    {
        class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Content = content;
                Author = author;
            }
            public string Title { get; set; }
            public string Content { get; set; }
            public string Author { get; set; }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }

        static void Main()
        {
            string[] input = Console.ReadLine().Split(", ");
            Article article = new Article(input[0], input[1], input[2]);

            int numberOfChanges = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfChanges; i++)
            {
                string[] commands = Console.ReadLine().Split(": ");
                string action = commands[0];
                switch (action)
                {
                    case "Edit":
                        article.Content = commands[1];
                        break;
                    case "ChangeAuthor":
                        article.Author = commands[1];
                        break;
                    case "Rename":
                        article.Title = commands[1];
                        break;

                }
            }
            Console.WriteLine(article);
        }
    }
}
