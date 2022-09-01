using System;
using System.Linq;

namespace _04.Another_Secret_Chat
{
    class Program
    {
        static void Main()
        {
            string concealedMessage = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Reveal")
            {
                var info = input.Split(":|:");

                string action = info[0];

                switch (action)
                {
                    case "InsertSpace":
                        int index = int.Parse(info[1]);
                        concealedMessage = concealedMessage.Insert(index, " ");
                        break;
                    case "Reverse":
                        var substring = info[1];
                        if (concealedMessage.Contains(substring))
                        {
                            int curIndex = concealedMessage.IndexOf(substring);
                            concealedMessage = concealedMessage.Remove(curIndex, substring.Length);
                            concealedMessage = $"{concealedMessage}{string.Join("",substring.Reverse())}";
                        }
                        else
                        {
                            Console.WriteLine("error");
                            continue;
                        }
                        break;
                    case "ChangeAll":
                        string subToReplace = info[1];
                        string replacmentString = info[2];
                        concealedMessage = concealedMessage.Replace(subToReplace, replacmentString);
                        break;
                }
                Console.WriteLine(concealedMessage);
            }
            Console.WriteLine($"You have a new text message: {concealedMessage}");
        }
    }
}
