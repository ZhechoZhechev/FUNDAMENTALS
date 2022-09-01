using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _12.Message_Translator
{
    class Program
    {
        static void Main()
        {
            int messagesCount = int.Parse(Console.ReadLine());

            string pattern = @"(!{1}(?<command>[A-Z][a-z]{2,})!{1}):(\[{1}(?<message>[A-Za-z]{8,})\])";

            for (int i = 0; i < messagesCount; i++)
            {
                var message = Console.ReadLine();

                Match info = Regex.Match(message, pattern);

                if (info.Success)
                {
                    var command = info.Groups["command"].Value;
                    var messageToDecrypt = info.Groups["message"].Value;

                    var decrypted = messageToDecrypt.Select(x => (int)x).ToList();

                    Console.WriteLine($"{command}: {string.Join(" ", decrypted)}");
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
