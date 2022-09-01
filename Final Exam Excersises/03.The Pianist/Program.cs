using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.The_Pianist
{
    class Piece
    {
        public string PieceName { get; set; }
        public string Composer { get; set; }
        public string PieceKey { get; set; }
    }
    class Program
    {

        static void Main()
        {
            int numOfPieces = int.Parse(Console.ReadLine());

            List<Piece> pieces = new List<Piece>();


            for (int i = 0; i < numOfPieces; i++)
            {
                string input = Console.ReadLine();

                var info = input.Split("|");

                string pieceName = info[0];
                string composer = info[1];
                string key = info[2];

                Piece piece = new Piece()
                {
                    PieceName = pieceName,
                    Composer = composer,
                    PieceKey = key
                };
                pieces.Add(piece);
            }
            string newCommands = string.Empty;
            while ((newCommands = Console.ReadLine()) != "Stop")
            {
                var newInfo = newCommands.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string action = newInfo[0];
                switch (action)
                {
                    case "Add":
                        AddAPiece(pieces, newInfo);
                        break;
                    case "Remove":
                        RemoveAPiece(pieces, newInfo);
                        break;
                    case "ChangeKey":
                        ChangeKeyToAPiece(pieces, newInfo);
                        break;
                }
            }
            foreach (var piece in pieces)
            {
                Console.WriteLine($"{piece.PieceName} -> Composer: {piece.Composer}, Key: {piece.PieceKey}");
            }

            //Tuple<string, string, string> jecho = new Tuple<string, string, string>();
            static void ChangeKeyToAPiece(List<Piece> pieces, string[] newInfo)
            {
                string pieceToChangeKeyTo = newInfo[1];
                string keyToChange = newInfo[2];
                if (pieces.Any(x => x.PieceName == pieceToChangeKeyTo))
                {

                    pieces.First(x => x.PieceName == pieceToChangeKeyTo).PieceKey = keyToChange;
                    Console.WriteLine($"Changed the key of {pieceToChangeKeyTo} to {keyToChange}!");
                }
                else
                {
                    Console.WriteLine($"Invalid operation! {pieceToChangeKeyTo} does not exist in the collection.");
                }
            }

            static void RemoveAPiece(List<Piece> pieces, string[] newInfo)
            {
                string pieceToRemove = newInfo[1];

                if (pieces.Any(x => x.PieceName == pieceToRemove))
                {
                    pieces.Remove(pieces.First(x => x.PieceName == pieceToRemove));
                    Console.WriteLine($"Successfully removed {pieceToRemove}!");
                }
                else
                {
                    Console.WriteLine($"Invalid operation! {pieceToRemove} does not exist in the collection.");
                }
            }

            static void AddAPiece(List<Piece> pieces, string[] newInfo)
            {
                string pieceToAdd = newInfo[1];
                string composerToAdd = newInfo[2];
                string keyToAdd = newInfo[3];

                if (!pieces.Any(x => x.PieceName == pieceToAdd))
                {
                    Piece piece = new Piece() { Composer = composerToAdd, PieceKey = keyToAdd, PieceName = pieceToAdd };
                    pieces.Add(piece);

                    Console.WriteLine($"{pieceToAdd} by {composerToAdd} in {keyToAdd} added to the collection!");
                }
                else
                {
                    Console.WriteLine($"{pieceToAdd} is already in the collection!");
                }


            }

        }
    }
}

