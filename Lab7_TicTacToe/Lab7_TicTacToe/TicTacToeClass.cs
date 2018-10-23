using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_TicTacToe
{
    public class TicTacToeClass
    {
        public string currentPlayer;
        public int turn;

        //array of bool indexes to check if user is an X = false , or O = true
        public string[] board = new string[9];

        //fills an array of empty spaces and determines the start player for the match
        public void CreateBoard()
        {
            //for loop is to traverse through the array and make all the spaces empty and ready for play. 
            for (int i = 0; i < board.Length - 1; i++)
            {
                board[i] = "placement";  //the, "placement" word means that the space is usable on the board.
            }

         

        }
       //decides who plays first
        public string CurrentPlayer()
        {

            //generates random number 1 or 2 to decide if player 0(O) or 1(X) starts. 
            turn = 0; //X WILL START FIRST
            if (turn == 0)
            {
                currentPlayer = "X";

            }
            else if (turn == 1)
            {
                currentPlayer = "O";
            }

            return currentPlayer; 

        }
        //incraments the XorO variable in order to change players.
        public string ChangePlayer(int turn)
        {
            turn++;
            //mod 2 because remainder will always be 0 or 1 and this is a good way to switch between the next turn.
            if (turn % 2 == 0)
            {
                currentPlayer = "O";
            }
            else if (turn % 2 == 1)
            {
                currentPlayer = "X";
            }

            return currentPlayer; 
        }
        //Use this method by make a move by ID (0 through 8 since there are 9 spaces) 
        public string MakeMove(int moveID, int turn)
        {
            if (turn % 2 == 0)
            {
                board[moveID] = "O";
            }
            else if (turn % 2 == 1)
            {
                board[moveID] = "X";
            }
            return board[moveID]; //returning move value for the unit test.

        }
        //method checks the array index, if it contains the string placement then it is usable and returns a true. 
        public bool SpaceInUse(int moveID)
        {
            if (board[moveID] == "placement")
            {
                return true;
            }
            return false;
        }
    }
}
