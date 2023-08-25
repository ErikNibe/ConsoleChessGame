namespace ConsoleChessGame.Entities.board
{
    internal class Board
    {
        public int Lines { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces;

        public Board(int lines, int columns) 
        { 
            Lines = lines;
            Columns = columns;
            Pieces = new Piece[Lines, Columns];
        }

        public Piece Piece (int line, int column)
        {
            // Return the correspondent position on the board
            return Pieces[line, column];
        }

        public void AddPiece(Piece p, Position pos)
        {
            // Add a piece of chess at the correspondent position
            Pieces[pos.Line, pos.Column] = p;
            p.Position = pos;
        }
    }
}
