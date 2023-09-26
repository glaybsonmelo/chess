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

    }
}
