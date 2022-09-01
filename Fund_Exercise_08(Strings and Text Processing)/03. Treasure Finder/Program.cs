using System;
using System.Linq;
using System.Text;

namespace _10._Treasure_Finder
{
    class Program
    {
        static void Main()
        {
            var key = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = string.Empty;


            while ((input = Console.ReadLine()) != "find")
            {
                StringBuilder decoded = new StringBuilder();
                
                string stringToDecode = input;
                int keyIndex = 0;

                for (int i = 0; i < stringToDecode.Length; i++)
                {
                    char currChar = stringToDecode[i];
                    int curKey = key[keyIndex];
                    char decocedChar = (char)(currChar - curKey);

                    decoded.Append(decocedChar);

                    keyIndex++;

                    if (keyIndex == key.Count) keyIndex = 0;
                }
                string ouput = decoded.ToString();
                
                int indexBeforeTheTresure = ouput.IndexOf('&');
                int indexAfterOfTheTresure = ouput.IndexOf('&', ouput.IndexOf('&') + 1);
                
                string nameTresure = ouput.Substring(indexBeforeTheTresure + 1, indexAfterOfTheTresure - indexBeforeTheTresure - 1);
                
                int indexBeforeThePlace = ouput.IndexOf('<');
                int indexAfterTheOlace = ouput.IndexOf('>');
                
                string place = ouput.Substring(indexBeforeThePlace + 1, indexAfterTheOlace - indexBeforeThePlace - 1);

                Console.WriteLine($"Found {nameTresure} at {place}");
                decoded.Clear();

            }
        }
    }
}
