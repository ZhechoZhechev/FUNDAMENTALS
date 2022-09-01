using System;
using System.Text;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main()
        {
            //Create a program that returns an encrypted version of the same text.
            //Encrypt the text by shifting each character with three positions forward.For example,
            //A would be replaced by D, B would become E and so on.Print the encrypted text.

            var word = Console.ReadLine().ToCharArray();

            StringBuilder encryptedWord = new StringBuilder();

            for (int i = 0; i < word.Length; i++)
            {
                word[i] = (char)(word[i] + 3);
                encryptedWord.Append(word[i]);
            }
            Console.WriteLine(encryptedWord.ToString());
        }
    }
}
