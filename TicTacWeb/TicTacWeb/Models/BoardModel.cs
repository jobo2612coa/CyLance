using System.Reflection.Metadata;

namespace TicTacWeb.Models
{
    public class BoardModel
    {
        private int[,] _board = new int[3, 3];
        private const int Xval = 1;
        private const int YVal = -1;
        public void SetX(int LocRow, int LocCol)
        {
            _board[LocRow, LocCol] = Xval;
        }

        public void SetY(int LocRow, int LocCol)
        {
            _board[LocRow, LocCol] = YVal;
        }

        public void Set00X() => SetX(0, 0);

    }
}