﻿using ChessProj.chessboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessProj.chess
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
