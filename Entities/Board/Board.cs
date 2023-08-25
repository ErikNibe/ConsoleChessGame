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

        public Piece Piece (Position position)
        {
            return Pieces[position.Line, position.Column];
        }

        public Piece Piece (int line, int column)
        {
            // Piece method overload
            
            // Return the correspondent position on the board
            return Pieces[line, column];
        }

        public bool PieceExist (Position position)
        {
            ValidatePosition(position);

            return Piece(position) != null; 
        }

        public void AddPiece(Piece p, Position pos)
        {
            if (PieceExist(pos)) throw new BoardException("Já existe uma peça nessa posição!");

            // Add a piece of chess at the correspondent position
            Pieces[pos.Line, pos.Column] = p;
            p.Position = pos;
        }

        public bool ValidPosition(Position position)
        {
            if (position.Line < 0 || position.Line >= Lines || position.Column < 0 || position.Column >= Columns)
            {
                return false;
            }

            return true;
        }

        public void ValidatePosition(Position position)
        {
            if (!ValidPosition(position))
            {
                throw new BoardException("Posição Inválida!");
            }
        }
    }
}
