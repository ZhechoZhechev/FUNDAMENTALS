using System;

namespace _05.Activation_Keys
{
    class Program
    {
        static void Main()
        {
            string activationKey = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Generate")
            {
                var info = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string action = info[0];

                switch (action)
                {
                    case "Contains":
                        string substring = info[1];

                        if (activationKey.Contains(substring))
                        {
                            Console.WriteLine($"{activationKey} contains {substring}");
                        }
                        else Console.WriteLine("Substring not found!");
                        break;
                    case "Flip":
                        string upperOrLower = info[1];
                        int startIndex = int.Parse(info[2]);
                        int endIndex = int.Parse(info[3]) - 1;

                        string substringToChange = activationKey.Substring(startIndex, endIndex - startIndex + 1);
                        activationKey = activationKey.Remove(startIndex, endIndex - startIndex + 1);

                        if (upperOrLower == "Upper")
                        {
                            substringToChange = substringToChange.ToUpper();
                            activationKey = activationKey.Insert(startIndex, substringToChange);
                        }
                        else
                        {
                            substringToChange = substringToChange.ToLower();
                            activationKey = activationKey.Insert(startIndex, substringToChange);
                        }

                        Console.WriteLine(activationKey);
                        break;
                    case "Slice":
                        int startIndexToSlice = int.Parse(info[1]);
                        int endIndexToSlice = int.Parse(info[2]) - 1;

                        activationKey = activationKey.Remove(startIndexToSlice, endIndexToSlice - startIndexToSlice + 1);
                        
                        Console.WriteLine(activationKey);
                        break;
                }
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
