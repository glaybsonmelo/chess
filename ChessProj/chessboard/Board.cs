namespace ChessProj.chessboard
{
    internal class Board
    {
        public int rows {  get; set; }
        public int cols { get; set; }
        private Piece[,] pieces;
        public Board(int row, int col)
        {
            this.rows = row;
            this.cols = col;
            this.pieces = new Piece[rows, cols];
        }
        public Piece GetPiece(int row, int col)
        {
            return pieces[row, col];
        }
        public Piece GetPiece(Position pos)
        {
            return pieces[pos.Row, pos.Col];
        }
        public void PutPiece(Piece p, Position pos)
        {
            if (ExistPiece(pos))
            {
                throw new BoardException("Já existe uma peça nessa posição");
            }
            pieces[pos.Row, pos.Col] = p;
            p.position = pos;
        }

        public bool ExistPiece(Position pos)
        {
            validatePosition(pos);
            return GetPiece(pos) != null;
        }

        public bool ValidPosition(Position pos)
        {
            if(pos.Row < 0 || pos.Row >= rows || pos.Col < 0 || pos.Col >= cols)
            {
                return false;
            }
            return true;
        }

        public void validatePosition(Position pos)
        {
            if (!ValidPosition(pos))
            {
                throw new BoardException("Posição inválida!");
            }
        }



    }


}
