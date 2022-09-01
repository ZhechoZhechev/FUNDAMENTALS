using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main()
        {
            var filePath = Console.ReadLine().Split("\\", StringSplitOptions.RemoveEmptyEntries);
            var fileAndType = filePath[filePath.Length - 1].Split(".");
            
            string file = fileAndType[0];
            string type = fileAndType[1];

            Console.WriteLine($"File name: {file}");
            Console.WriteLine($"File extension: {type}");
        }
    }
}
