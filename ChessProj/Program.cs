using ChessProj.chessboard;

internal class Program
{
    private static void Main(string[] args)
    {
        Board b = new Board(8, 8);
        b.Write();
    }
}