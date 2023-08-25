using ConsoleChessGame.Entities.Board;

namespace ConsoleChessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(8, 8);

            Screen.PrintBoard(board);

        }
    }
}