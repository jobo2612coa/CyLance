using System;
using Xunit;
using MakeABoard;
using MakeABoard.Models;

namespace XUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Always_True()
        {
            Assert.True(true);
        }
        [Fact]
        public void Board_Create_1()
        {
            int[,] seed = new int[3, 3] { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } };
            BoardModel board = new BoardModel(seed);
            bool isEqual = board.IsEqual(seed);
            Assert.True(board.IsEqual(seed));
        }
        [Fact]
        public void Board_Create_2()
        {
            int[,] seed1 = new int[3, 3] { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } };
            int[,] seed2 = new int[3, 3] { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 0, 1 } };
            BoardModel board = new BoardModel(seed1);
            bool isEqual = board.IsEqual(seed2);
            Assert.False(board.IsEqual(seed2));
        }
        [Fact]
        public void Player_Move_Set_1()
        {
            int[,] seed = new int[3, 3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };
            BoardModel boardModel = new BoardModel();

            Player player = new Player(boardModel, BoardModel.XMark);
            boardModel = player.Move();
            Assert.False(boardModel.IsEqual(seed));
        }
        [Fact]
        public void Player_Move_Set_2()
        {
            int[,] seed1 = new int[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 0, 1 } };
            int[,] seed2 = new int[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            BoardModel boardModel = new BoardModel(seed1);

            Player player = new Player(boardModel, BoardModel.XMark);
            boardModel = player.Move();
            Assert.True(boardModel.IsEqual(seed2));
        }
        [Fact]
        public void Player_Move_Set_3()
        {
            int[,] seed1 = new int[3, 3] { { 1, -1, 1 }, { -1, 0, -1 }, { 1, -1, 1 } };
            int[,] seed2 = new int[3, 3] { { 1, -1, 1 }, { -1, 1, -1 }, { 1, -1, 1 } };
            BoardModel boardModel = new BoardModel(seed1);

            Player player = new Player(boardModel, BoardModel.XMark);
            boardModel = player.Move();
            Assert.True(boardModel.IsEqual(seed2));
        }
        [Fact]
        public void Player_Move_Set_4()
        {
            int[,] seed1 = new int[3, 3] { { 1, -1, 1 }, { -1, 0, -1 }, { 1, -1, 1 } };
            int[,] seed2 = new int[3, 3] { { 1, -1, 1 }, { -1, -1, -1 }, { 1, -1, 1 } };
            BoardModel boardModel = new BoardModel(seed1);

            Player player = new Player(boardModel, BoardModel.YMark);
            boardModel = player.Move();
            Assert.True(boardModel.IsEqual(seed2));
        }
        [Fact]
        public void Player_Move_Random()
        {
            int[,] seed = new int [3,3] { { 1, 1, 1 }, { 1, 0, 1 }, { 1, 1, 1 } };
            BoardModel board = new BoardModel();

        }
    }
}
