using System;

namespace _17.The_Imitation_Game
{
    class Program
    {
        static void Main()
        {
            string encMessage = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Decode") 
            {
                var commands = input.Split('|');

                var action = commands[0];

                switch (action)
                {
                    case "Move":
                        int numOfLetts = int.Parse(commands[1]);

                        var substring = encMessage.Substring(0, numOfLetts);
                        encMessage = encMessage.Remove(0, numOfLetts);
                        encMessage = encMessage.Insert(encMessage.Length, substring);
                        break;
                    case "Insert":
                        int index = int.Parse(commands[1]);
                        string valueToInsert = commands[2];

                        encMessage = encMessage.Insert(index, valueToInsert);
                        break;
                    case "ChangeAll":
                        string substrToReplace = commands[1];
                        string replacementString = commands[2];

                        encMessage = encMessage.Replace(substrToReplace, replacementString);
                        break;
                }
            }
            Console.WriteLine($"The decrypted message is: {encMessage}");
        }
    }
}
