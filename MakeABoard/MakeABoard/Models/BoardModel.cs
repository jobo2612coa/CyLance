using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MakeABoard.Models
{
    public class BoardModel 
    {
        /* The Board Model . . .
         * is a child of Match Model
         * contains the current state of the game board
         * is used by player
         */

        public int[,] GameBoard = new int[3, 3] 
        { { NoMark, NoMark, NoMark }, 
            { NoMark, NoMark, NoMark }, 
            { NoMark, NoMark, NoMark } };

        public const int NoMark = 0;
        public const int XMark = 1;
        public const int YMark = -1;

        public string Test { get; set; }

        public BoardModel()
        {
            SetFakeBoard();
            Test = "Test";
        }
        public BoardModel(int[,] board)
        {
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    GameBoard[i, j] = board[i, j];
                }
            }
        }
        public bool IsEqual(int[,] board)
        {
            bool result = true;
            if (board != null)
            {
                for (int i = 0; i <= 2; i++)
                {
                    for (int j = 0; j <= 2; j++)
                    {
                        if (GameBoard[i, j] != board[i, j])
                        {
                            result = false;
                        }
                    }
                }
            } else
            {
                result = false;
            }
            return result;
        }
        public void SetFakeBoard()
        {
            GameBoard = new int[3, 3]
            {
                { XMark, YMark, NoMark },
                { NoMark, XMark, YMark },
                { NoMark, NoMark, XMark }
            };
        }
        public string GetMark(int value)
        {
            if (value == -1)
            {
                return "O";
            }
            else if (value == 0)
            {
                return "";
            }
            else if (value == 1)
            {
                return "X"; 
            }
            else return "error";
        }
        public bool IsSet(int x, int y)
        {
            return GameBoard[x, y] != NoMark ? true : false ;
        }
        public bool IsX(int x, int y)
        {
            return (GameBoard[x, y] == XMark ? true : false);
        }
        public bool IsY(int x, int y)
        {
            return (GameBoard[x, y] == YMark ? true : false);
        }
        public void SetMark(int Mark, int x, int y)
        {
            if (!IsSet(x, y))
            {
                GameBoard[x, y] = Mark;
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
