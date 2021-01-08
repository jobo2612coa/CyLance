using MakeABoard.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MakeABoard
{
    public class Player
    {
        BoardModel _board = new Models.BoardModel();
        int _mark;
        public Player()
        {

        }
        public Player(BoardModel board, int mark)
        {
            _board = new BoardModel( board.GameBoard);
            _mark = mark;
        }
        public Models.BoardModel Move()
        {
            bool done = false;
            var random = new Random();
            while (!done)
            {
                int i = random.Next( 3);
                int j = random.Next(3);
                if (!_board.IsSet(i, j))
                {
                    _board.SetMark(_mark, i, j);
                    done = true;
                }
            }
            return _board;
        }
    }

    public class Randoma : Player
    {
        BoardModel _board = new Models.BoardModel();
        int _mark;
        public Randoma(BoardModel board, int mark)
        {
            _board = new BoardModel(board.GameBoard);
            _mark = mark;
        }
    }

}
