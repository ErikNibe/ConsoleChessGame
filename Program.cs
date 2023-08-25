using ConsoleChessGame.Entities.board;
using ConsoleChessGame.Entities.board.Enums;
using ConsoleChessGame.Entities.Chess;

namespace ConsoleChessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board board = new Board(8, 8);

                board.AddPiece(new Tower(board, Color.Black), new Position(0, 0));
                board.AddPiece(new Tower(board, Color.Black), new Position(0, 9));
                board.AddPiece(new Tower(board, Color.Black), new Position(2, 4));

                Screen.PrintBoard(board);
            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}