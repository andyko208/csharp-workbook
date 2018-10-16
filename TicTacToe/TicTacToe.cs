using System;

namespace TicTacToe
{
    class Program
    {
        public static string playerTurn = "X";
        public static string[][] board = new string[][]
        {
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "},
            new string[] {" ", " ", " "}
        };

        public static void Main()
        {
            do
            {
                int[] taken = new int[2];
                DrawBoard();
                GetInput();
                PlaceMark(taken[0],taken[1]);


            } while (!CheckForWin() && !CheckForTie());

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }
        
        public static int[] GetInput()           //return two ints that store user inputs
        {
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int column = int.Parse(Console.ReadLine());
            int[] taken = new[] {row, column};
            return taken;
        }
        public static bool PlaceMark(int row, int column) //return true if possible to put a mark
        {
            // your code goes here
            if(row > 2 || column > 2)
                return false;
            if(board[row][column] == "X" || board[row][column] == "O")
                return false;
            return true;
            
        }

        public static bool CheckForWin()
        {
            // your code goes here
            if (HorizontalWin() || VerticalWin())
                return true;
            return false;
        }

        public static bool CheckForTie()
        {
            // your code goes here
            if (HorizontalWin() == false || VerticalWin() == false)
                return true;
            return false;
        }
        
        public static bool HorizontalWin()
        {
            // your code goes here
            if(board[0][0] == playerTurn && board[0][1] == playerTurn && board[0][2] == playerTurn)
                return true;
            if(board[1][0] == playerTurn && board[1][1] == playerTurn && board[1][2] == playerTurn)
                return true;
            if(board[2][0] == playerTurn && board[2][1] == playerTurn && board[2][2] == playerTurn)
                return true;    
            return false;
        }

        public static bool VerticalWin()
        {
            if(board[0][0] == playerTurn && board[1][0] == playerTurn && board[2][0] == playerTurn)
                return true;
            if(board[0][1] == playerTurn && board[1][1] == playerTurn && board[2][1] == playerTurn)
                return true;
            if(board[0][2] == playerTurn && board[1][2] == playerTurn && board[2][2] == playerTurn)
                return true;   
            return false;
        }

        public static bool DiagonalWin()
        {
            // your code goes here
            if(board[0][0] == playerTurn && board[1][1] == playerTurn && board[2][2] == playerTurn)
                return true;
            if(board[0][2] == playerTurn && board[1][1] == playerTurn && board[2][0] == playerTurn)
                return true;   
            return false;
        }

        public static void DrawBoard()
        {
            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
        }
    }
}
