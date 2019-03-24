using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            int player = 1;
            int[,] board = new int[3, 3];
            InitializeBoard(board);
            bool gameend = false;
            //board[0, 0] = player;
            //player = 0;
            //board[2, 2] = player;
            //player = 1;

            while (gameend==false)
            {
                Console.Clear();
                Print(board);
                Console.Write("Please enter row: ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter col: ");
                int col = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("row: " + row + " col: " + col);

                board[row, col] = player;

                //Check if won
                if( player==board[0,0] && player==board[0,1] && player==board[0,2])
                {
                    Console.WriteLine(player + "has won the game!");
                    gameend = true;
                }
                player=ChangeTurn(player);
                
                //Print(board);
            }
        }
        public static int ChangeTurn(int player)
        {
            if (player == 1)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }

        public static void InitializeBoard(int[,]board)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = 0;
                }
            }
        }
        public static void Print(int[,]board)
        {
            Console.WriteLine(" | 0 | 1 | 2 | ");
            //Printing the board
            for (int i = 0; i < 3; i++)
            {
                Console.Write(i+ "| ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j]);
                    Console.Write(" | ");
                }
                Console.WriteLine();
            }
        }
    }
}
