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
            int tieInt = 0;     //if reaches 9, game ends
            do
            {
                int[] newArr = new int[2];
                DrawBoard();
                newArr = GetInput();
                if(PlaceMark(newArr[0],newArr[1]) == true && playerTurn == "X")
                {
                    board[newArr[0]][newArr[1]] = playerTurn;
                    playerTurn = "O";
                    tieInt++;
                }
                else if(PlaceMark(newArr[0],newArr[1]) == true && playerTurn == "O")
                {
                    board[newArr[0]][newArr[1]] = playerTurn;
                    playerTurn = "X";
                    tieInt++;
                }
                else
                {
                    newArr = GetInput();        //when user input is already taken or out of bound
                }
                DrawBoard();

            } while (!CheckForWin() && tieInt < 9); //game ending condition

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
            if (HorizontalWin() || VerticalWin() || DiagonalWin())
                return true;
            return false;
        }

        // public static bool CheckForTie() //have my own tie condition
        // {
        //     // your code goes here
        //     if (HorizontalWin() == false || VerticalWin() == false || DiagonalWin() == false)
        //         return true;
        //     return false;
        // }
        
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
