using System;
using System.Linq;

namespace _08.Extract_Person_Information
{
    class Program
    {
        static void Main()
        {
            int numberOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfInputs; i++)
            {
                var info = Console.ReadLine().Split();

                string name = string.Empty;
                string age = string.Empty;

                foreach (var word in info)
                {
                    if (word.Contains('@') || word.Contains('|'))
                    {
                        int nameStratIndex = word.IndexOf('@');
                        int nameEndIndex = word.IndexOf('|');
                        name = word.Substring(nameStratIndex +1 , nameEndIndex - nameStratIndex - 1);

                    }
                    if (word.Contains('#') || word.Contains('*'))
                    {
                        int ageStartIndex = word.IndexOf('#');
                        int ageEndIndex = word.IndexOf('*');
                        age = word.Substring(ageStartIndex +1 , ageEndIndex - ageStartIndex -1);
                    }

                }

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
