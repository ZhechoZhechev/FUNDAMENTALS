using System;
using System.Linq;

namespace _11.Nikulden_s_Charity
{
    class Program
    {
        static void Main()
        {
            string stringToDecode = Console.ReadLine();

            var input = string.Empty;

            while ((input = Console.ReadLine()) != "Finish")
            {
                var info = input.Split();
                var action = info[0];

                switch (action)
                {
                    case "Replace":
                        char charToReplace = char.Parse(info[1]);
                        char charToReplaceWith = char.Parse(info[2]);

                        stringToDecode = stringToDecode.Replace(charToReplace, charToReplaceWith);
                        Console.WriteLine(stringToDecode);
                        break;
                    case "Cut":
                        int startIndex = int.Parse(info[1]);
                        int endIndex = int.Parse(info[2]);

                        if (startIndex >= 0 && startIndex <= stringToDecode.Length - 1 && endIndex >= 0 && endIndex <= stringToDecode.Length - 1)
                        {
                            stringToDecode = stringToDecode.Remove(startIndex, endIndex - startIndex + 1);
                            Console.WriteLine(stringToDecode);
                        }
                        else Console.WriteLine("Invalid indexes!");
                        break;
                    case "Make":
                        string upperOrLower = info[1];
                        
                        if (upperOrLower == "Upper")
                        {
                            stringToDecode = stringToDecode.ToUpper();
                            Console.WriteLine(stringToDecode);
                        }
                        else
                        {
                            stringToDecode = stringToDecode.ToLower();
                            Console.WriteLine(stringToDecode);
                        }
                        break;
                    case "Check":
                        string stringToCheck = info[1];
                        if (stringToDecode.Contains(stringToCheck))
                        {
                            Console.WriteLine($"Message contains {stringToCheck}");
                        }
                        else
                        {
                            Console.WriteLine($"Message doesn't contain {stringToCheck}");
                        }
                        break;
                    case "Sum":
                        int starInd = int.Parse(info[1]);
                        int endInd = int.Parse(info[2]);

                        if (starInd >= 0 && starInd <= stringToDecode.Length - 1 && endInd >= 0 && endInd <= stringToDecode.Length - 1)
                        {
                            var sum = stringToDecode.Substring(starInd, endInd - starInd + 1).Select(x => (int)x).Sum();
                            Console.WriteLine(sum);
                        }
                        else
                        {
                            Console.WriteLine("Invalid indexes!");
                        }
                        break;

                }
            }
        }
    }
}
