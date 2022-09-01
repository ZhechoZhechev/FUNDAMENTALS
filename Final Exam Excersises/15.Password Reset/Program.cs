using System;
using System.Text;

namespace _15.Password_Reset
{
    class Program
    {
        static void Main()
        {
            string stringToWorkWith = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Done")
            {
                var commands = input.Split();

                string action = commands[0];

                switch (action)
                {
                    case "TakeOdd":
                        StringBuilder newString = new StringBuilder();

                        for (int i = 1; i < stringToWorkWith.Length; i +=2)
                        {
                            newString.Append(stringToWorkWith[i]);
                        }
                        stringToWorkWith = newString.ToString();
                        Console.WriteLine(stringToWorkWith);
                        break;
                    case "Cut":
                        int index = int.Parse(commands[1]);
                        int lenght = int.Parse(commands[2]);

                        stringToWorkWith = stringToWorkWith.Remove(index, lenght);
                        Console.WriteLine(stringToWorkWith);
                        break;
                    case "Substitute":
                        string substringToReplace = commands[1];
                        string replacementSubstring = commands[2];

                        if (stringToWorkWith.Contains(substringToReplace))
                        {
                            stringToWorkWith = stringToWorkWith.Replace(substringToReplace, replacementSubstring);
                            Console.WriteLine(stringToWorkWith);
                        }
                        else Console.WriteLine("Nothing to replace!");
                        break;
                }
            }
            Console.WriteLine($"Your password is: {stringToWorkWith}");
        }
    }
}
