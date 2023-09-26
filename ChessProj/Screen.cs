using ChessProj.chessboard;
namespace ChessProj
{
    class Screen
    {
        public static void PrintBoard(Board b)
        {
            int rows = b.rows;
            int cols = b.cols;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(b.GetPiece(i, j) == null ? "- " : b.GetPiece(i, j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
