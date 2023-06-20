namespace CheckersWithAI.ConsoleUI.Models
{
    internal class Move
    {
        public Move(char pieceLetter, int pieceNumber, char moveLetter, int moveNumber)
        {
            PieceLetter = pieceLetter;
            PieceNumber = pieceNumber;
            MoveLetter = moveLetter;
            MoveNumber = moveNumber;
        }

        public char PieceLetter { get; }

        public int PieceNumber { get; }

        public int MoveLetter { get; }

        public int MoveNumber { get; }
    }
}
