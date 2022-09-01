using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main()
        {
            int theKey = int.Parse(Console.ReadLine());
            int charCount = int.Parse(Console.ReadLine());
            string decoded = "";

            for (int currentChar = 0; currentChar < charCount; currentChar++)
            {
                char character = char.Parse(Console.ReadLine());

                decoded += (char)(character + theKey);
            }
            Console.WriteLine(decoded);

        }
    }
}
