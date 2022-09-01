using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main()
        {
            var usernames = Console.ReadLine().Split(", ");

            var longValidation = usernames.Where(x => x.Length >= 3 && x.Length <= 16);

            List<string> validPasses = new List<string>();

            
            foreach (var pass in longValidation)
            {
            
                bool isValidPass = true;
                for (int i = 0; i < pass.Length; i++)
                {
                    char currChar = pass[i];
                    
                    if (!(char.IsLetterOrDigit(currChar) || currChar == '_' || currChar == '-'))
                    {
                        isValidPass = false;
                        break;
                    }
                }
                if (isValidPass) validPasses.Add(pass);
            }

            Console.WriteLine(string.Join(Environment.NewLine, validPasses));

        }
    }
}
