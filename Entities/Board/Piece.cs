using ConsoleChessGame.Entities.board.Enums;

namespace ConsoleChessGame.Entities.board
{
    internal class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int NumberOfMoves { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Board board, Color color)
        {
            Position = null;
            Color = color;
            NumberOfMoves = 0;
            Board = board;
        }
    }
}
