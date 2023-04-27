using System;
using System.Threading;

namespace TicTacToe
{
    class Program
    {
        static char[] spaces = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        static int flag;
        /// <summary>
        /// Draws the game board
        /// </summary>
        static void DrawBoard()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}   | {1}    |  {2}   ", spaces[0], spaces[1], spaces[2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}   | {1}    |  {2}   ", spaces[3], spaces[4], spaces[5]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}   | {1}    |  {2}   ", spaces[6], spaces[7], spaces[8]);
            Console.WriteLine("     |     |     ");
        }

        /// <summary>
        /// Checks if the game was won, tied, or should continue
        /// </summary>
        /// <returns></returns>

        static int CheckWin()
        {
            if (spaces[0] == spaces[1] &&
                spaces[1] == spaces[2] || // row 1
                spaces[3] == spaces[4] &&
                spaces[4] == spaces[5] || // row 2
                spaces[6] == spaces[7] &&
                spaces[7] == spaces[8] || // row 3
                spaces[0] == spaces[3] &&
                spaces[3] == spaces[6] || // column 1
                spaces[1] == spaces[4] &&
                spaces[4] == spaces[7] || // column 2
                spaces[2] == spaces[5] &&
                spaces[5] == spaces[8] || // column 3
                spaces[0] == spaces[4] &&
                spaces[4] == spaces[8] ||// diagonal 1
                spaces[2] == spaces[4] &&
                spaces[4] == spaces[6]) // diagonal 2
            {
                return 1;
            }
            else if (spaces[0] != '1' &&
                     spaces[1] != '2' &&
                     spaces[2] != '3' &&
                     spaces[3] != '4' &&
                     spaces[4] != '5' &&
                     spaces[5] != '6' &&
                     spaces[6] != '7' &&
                     spaces[7] != '8' &&
                     spaces[8] != '9') //checks for a tie by checking if the tic tac toe fields no longer has numbers in them
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        
        
        public static void Main(string[] args)
        {
            
        }
    }
}