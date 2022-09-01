using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Pianist_v._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfPieces = int.Parse(Console.ReadLine());

            Dictionary<string, KeyValuePair<string, string>> pieces = new Dictionary<string, KeyValuePair<string, string>>();
            List<string> order = new List<string>();

            for (int i = 0; i < numOfPieces; i++)
            {
                string input = Console.ReadLine();

                var info = input.Split("|");

                string piece = info[0];
                string composer = info[1];
                string key = info[2];

                if (!pieces.ContainsKey(piece))
                {
                    pieces[piece] = new KeyValuePair<string, string>(composer, key);
                    order.Add(piece);

                }
            }

            string newCommands = string.Empty;

            while ((newCommands = Console.ReadLine()) != "Stop")
            {
                var newInfo = newCommands.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string action = newInfo[0];
                string piece = newInfo[1];
                switch (action)
                {
                    case "Add":
                        //string pieceToAdd = newInfo[1];
                        string composerToAdd = newInfo[2];
                        string keyToAdd = newInfo[3];

                        if (!pieces.ContainsKey(piece))
                        {

                            pieces[piece] = new KeyValuePair<string, string>(composerToAdd, keyToAdd);

                            order.Add(piece);

                            Console.WriteLine($"{piece} by {composerToAdd} in {keyToAdd} added to the collection!");
                        }
                        else
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        break;
                    case "Remove":

                        if (pieces.ContainsKey(piece))
                        {
                            pieces.Remove(piece);
                            order.Remove(piece);

                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                    case "ChangeKey":
                        string keyToChange = newInfo[2];
                        if (pieces.ContainsKey(piece))
                        {
                            var pieceData = pieces[piece];
                            var composer = pieceData.Key;
                            pieces[piece] = new KeyValuePair<string, string>(composer, keyToChange);
                            Console.WriteLine($"Changed the key of {piece} to {keyToChange}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                }
            }
            foreach (var piece in order)
            {
                Console.WriteLine($"{piece} -> Composer: {pieces[piece].Key}, Key: {pieces[piece].Value}");
            }
        }
    }
}

