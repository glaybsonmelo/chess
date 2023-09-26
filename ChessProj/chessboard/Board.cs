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
        public void Write()
        {
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine();
            }
        }
    }
}
