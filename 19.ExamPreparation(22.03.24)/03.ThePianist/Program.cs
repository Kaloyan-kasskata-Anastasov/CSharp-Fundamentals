class Program
{
    class Piece
    {
        public Piece(string name, string composer, string key)
        {
            Name = name;
            Composer = composer;
            Key = key;
        }

        public string Name { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }

        public override string ToString()
        {
            return $"{Name} -> Composer: {Composer}, Key: {Key}";
        }
    }

    static void Main()
    {
        List<Piece> piecesList = new List<Piece>();

        int piecesCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < piecesCount; i++)
        {
            string[] arguments = Console.ReadLine().Split("|");
            piecesList.Add(new Piece(arguments[0], arguments[1], arguments[2]));
        }

        string input;
        while ((input = Console.ReadLine()) != "Stop")
        {
            string[] arguments = input.Split("|");

            string pieceName;
            switch (arguments[0])
            {
                case "Add":
                    Piece newPiece = new Piece(arguments[1], arguments[2], arguments[3]);
                    if (piecesList.Exists(p => p.Name == newPiece.Name))
                    {
                        Console.WriteLine($"{newPiece.Name} is already in the collection!");
                    }
                    else
                    {
                        piecesList.Add(newPiece);
                        Console.WriteLine($"{newPiece.Name} by {newPiece.Composer} in {newPiece.Key} added to the collection!");
                    }

                    break;
                case "Remove":
                    pieceName = arguments[1];
                    Piece foundPieceToRemove = piecesList.Find(p => p.Name == pieceName);
                    if (foundPieceToRemove != null)
                    {
                        piecesList.Remove(foundPieceToRemove);
                        Console.WriteLine($"Successfully removed {foundPieceToRemove.Name}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }

                    break;
                case "ChangeKey":
                    pieceName = arguments[1];
                    string newKey = arguments[2];
                    Piece foundPieceToChange = piecesList.Find(p => p.Name == pieceName);
                    if (foundPieceToChange != null)
                    {
                        Console.WriteLine($"Changed the key of {foundPieceToChange.Name} to {newKey}!");
                        foundPieceToChange.Key = newKey;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {pieceName} does not exist in the collection.");
                    }

                    break;
            }
        }

        foreach (Piece piece in piecesList)
        {
            Console.WriteLine(piece);
        }

        //piecesList.ForEach(p => Console.WriteLine(p));
        //piecesList.ForEach(Console.WriteLine);
    }
}
