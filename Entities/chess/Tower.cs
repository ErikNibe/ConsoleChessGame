using ConsoleChessGame.Entities.board;
using ConsoleChessGame.Entities.board.Enums;

namespace ConsoleChessGame.Entities.Chess
{
    internal class Tower: Piece
    {
        public Tower(Board board, Color color) : base(board, color)
        {

        }

        public override string ToString()
        {
            return "T";
        }
    }
}