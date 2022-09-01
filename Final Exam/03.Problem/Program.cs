using System;
using System.Text;

namespace _03.Problem
{
    class Program
    {
        static void Main()
        {
            string spell = Console.ReadLine();

            string input = string.Empty;
            if (spell == " " || spell == string.Empty)
            {
                Console.WriteLine("The spell did not work!");
                return;
            }
            while ((input = Console.ReadLine()) != "Abracadabra")
            {
                var info = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string action = info[0];

                switch (action)
                {
                    case "Abjuration":
                        spell = spell.ToUpper();
                        Console.WriteLine(spell);
                        break;
                    case "Necromancy":
                        spell = spell.ToLower();
                        Console.WriteLine(spell);
                        break;
                    case "Illusion":
                        int index = int.Parse(info[1]);
                        char letter = char.Parse(info[2]);
                        if (index >= 0 && index <= spell.Length - 1)
                        {
                            StringBuilder sb = new StringBuilder(spell);
                            sb[index] = letter;
                            spell = sb.ToString();
                            
                            Console.WriteLine("Done!");
                        }
                        else
                        {
                            Console.WriteLine("The spell was too weak.");
                        }
                        break;
                    case "Divination":
                        string stringToReplace = info[1];
                        string stringToReplaceWith = info[2];
                        if (spell.Contains(stringToReplace))
                        {
                            spell = spell.Replace(stringToReplace, stringToReplaceWith);
                            Console.WriteLine(spell);
                        }
                        else continue;
                        break;
                    case "Alteration":
                        string stringToRemove = info[1];
                        if (spell.Contains(stringToRemove))
                        {
                            int startIndex = spell.IndexOf(stringToRemove);
                            spell = spell.Remove(startIndex, stringToRemove.Length);
                            Console.WriteLine(spell);
                        }
                        else continue;
                        break;
                    default:
                        Console.WriteLine("The spell did not work!");
                        break;
                }
            }
        }
    }
}
