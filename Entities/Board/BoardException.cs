using System;

namespace ConsoleChessGame.Entities.board
{
    internal class BoardException : Exception
    {
        public BoardException(string msg) : base(msg) { }

    }
}
