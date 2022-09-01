using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11._Morse_Code_Translator
{
    class Program
    {
        static void Main()
        {
            Dictionary<char, string> morseAlphabetDictionary = new Dictionary<char, string>()
                                   {
                                       {'A', ".-"},
                                       {'B', "-..."},
                                       {'C', "-.-."},
                                       {'D', "-.."},
                                       {'E', "."},
                                       {'F', "..-."},
                                       {'G', "--."},
                                       {'H', "...."},
                                       {'I', ".."},
                                       {'J', ".---"},
                                       {'K', "-.-"},
                                       {'L', ".-.."},
                                       {'M', "--"},
                                       {'N', "-."},
                                       {'O', "---"},
                                       {'P', ".--."},
                                       {'Q', "--.-"},
                                       {'R', ".-."},
                                       {'S', "..."},
                                       {'T', "-"},
                                       {'U', "..-"},
                                       {'V', "...-"},
                                       {'W', ".--"},
                                       {'X', "-..-"},
                                       {'Y', "-.--"},
                                       {'Z', "--.."},
                                       {'0', "-----"},
                                       {'1', ".----"},
                                       {'2', "..---"},
                                       {'3', "...--"},
                                       {'4', "....-"},
                                       {'5', "....."},
                                       {'6', "-...."},
                                       {'7', "--..."},
                                       {'8', "---.."},
                                       {'9', "----."}
                                   };
            var stringToTranslate = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            StringBuilder translated = new StringBuilder();

            Translator(morseAlphabetDictionary, stringToTranslate, translated);
            
            Console.WriteLine(translated);
        }

        private static void Translator(Dictionary<char, string> morseAlphabetDictionary, List<string> stringToTranslate, StringBuilder translated)
        {
            foreach (var str in stringToTranslate)
            {
                if (str == "|")
                {
                    translated.Append(" ");
                }
                else
                {
                    var toAdd = morseAlphabetDictionary.Where(kvp => kvp.Value == str).Select(kvp => kvp.Key).ToArray();
                    translated.Append(toAdd);
                }

            }
        }
    }
}
