using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab7_TicTacToe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab7_TicTacToe.Tests
{
    [TestClass()]
    public class TicTacToeTests
    {
        TicTacToeClass game = new TicTacToeClass();
        [TestMethod()]
        public void checkBoardSizeTest()
        {

            const int boardSize = 9;
            game.CreateBoard();
            Assert.AreEqual(boardSize, game.board.Length);
        }
        [TestMethod()]
        public void checkifPlayerisXTest()
        {
            const string playerX = "X";
            Assert.AreEqual(playerX, game.CurrentPlayer());
        }

        [TestMethod()]
        public void checkifPlayerisOTest()
        {
            const string playerO = "O";
             int turn = 1; // turns will incrament in the TicTacToeClass so we will use #1 for an example of showing that it is player O's turn.
            Assert.AreEqual(playerO, game.ChangePlayer(turn));
        }
        [TestMethod()]
        public void xIsPlacedTest()
        {
            const string playerMove = "X";
            int turn = 1;
            Assert.AreEqual(playerMove, game.MakeMove(1,turn));//made it O's turn to make a placement, and used a random moveID to fufill the method parameters.
        }

        [TestMethod()]
        public void oIsPlacedTest()
        {
            const string playerMove = "O";
            int turn = 0;
            Assert.AreEqual(playerMove, game.MakeMove(1, turn));//made it O's turn to make a placement, and used a random moveID to fufill the method parameters.
        }
        [TestMethod()]
        public void emptySpaceTest()
        {
            bool spaceIs = true; // if true, then space is placeable(placement)
            game.CreateBoard(); //method must run in order to create the empty placement spots in the array(board). 
            Assert.AreEqual(spaceIs, game.SpaceInUse(1)); // game from the start already sets all spaces empty so any moveID will be placement without the game being played.
        }
    }
}