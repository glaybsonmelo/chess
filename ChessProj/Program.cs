using ChessProj;
using ChessProj.chess;
using ChessProj.chessboard;

internal class Program
{
    private static void Main(string[] args)
    {
        Board b = new Board(8, 8);

        Piece p1 = new King(b, Color.Black);
        Piece p2 = new Tower(b, Color.Black);
        Piece p3 = new Tower(b, Color.Black);

        try
        {

            b.PutPiece(p1, new Position(0, 0));
            b.PutPiece(p1, new Position(6, 2));
            b.PutPiece(p2, new Position(3, 1));
            b.PutPiece(p3, new Position(6, 6));
            Screen.PrintBoard(b);
        } catch(BoardException err)
        {
            Console.WriteLine(err.Message);
        }
    }

}