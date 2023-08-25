using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChessGame.Entities.Board
{
    internal class Board
    {
        public int Line { get; set; }
        public int Columns { get; set; }
        private Piece[,] Pieces;

        public Board(int line, int column) 
        { 
            Line = line;
            Columns = column;
            Pieces = new Piece[Line, Columns];
        }
    }
}
