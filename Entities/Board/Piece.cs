using ConsoleChessGame.Entities.Board.Enums;

namespace ConsoleChessGame.Entities.Board
{
    internal class Piece
    {
        public Position Position { get; set; }
        public Color Color { get; protected set; }
        public int NumberOfMoves { get; protected set; }
        public Board Board { get; protected set; }

        public Piece(Position position, Color color, Board board)
        {
            Position = position;
            Color = color;
            NumberOfMoves = 0;
            Board = board;
        }
    }
}
