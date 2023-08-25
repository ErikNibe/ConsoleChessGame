using ConsoleChessGame.Entities.board;
using ConsoleChessGame.Entities.board.Enums;


namespace ConsoleChessGame.Entities.Chess
{
    internal class King : Piece
    {
        public King(Board board, Color color) : base(board, color)
        {

        }

        public override string ToString()
        {
            return "R";
        }
    }
}
