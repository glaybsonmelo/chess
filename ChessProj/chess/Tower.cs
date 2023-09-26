﻿using ChessProj.chessboard;
namespace ChessProj.chess
{
    internal class Tower : Piece
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
