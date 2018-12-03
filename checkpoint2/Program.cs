using System;
using System.Collections.Generic;

namespace checkpoint2
{
    class Program
    {
        static void Main(string[] args)
        {
            Board ba = new Board();
            ba.CreateBoard();
            ba.GenerateCheckers();
            ba.PlaceCheckers();
            ba.DrawBoard();
            int selectRow;
            int selectCol;
            int placeRow;
            int placeCol;
            Console.WriteLine("Enter Pickup Row:");
            selectRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Pickup Column:");
            selectCol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Placement Row:");
            placeRow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Placement Column:");
            placeCol = Convert.ToInt32(Console.ReadLine());
            Checker check = ba.SelectChecker(selectRow, selectCol);
            ba.MoveChecker(check, placeRow, placeCol);
            ba.PlaceCheckers();
            ba.DrawBoard();
            ba.RemoveChecker(2,1);  //removes checker from the list and Grid
            ba.PlaceCheckers();
            Console.WriteLine();
            ba.DrawBoard();
        }
    }
    class Checker
    {
        public string Symbol { get; set; } //the actual symbol either an open or a closed dot
        public int[] Position { get; set; } //the coordinates of its place on the grid
        public string Color { get; set; } //the team name (either "white" or "black")
        public Checker(String color)
        {
            color = color.ToLower();
            if(color == "white")
                Symbol =  "○";
            else{
                Symbol = "●";
            }
        }
    }
    class Board
    {
        public string[,] Grid { get; set; } //the "grid" that makes up the board
        public List<Checker> Checkers { get; set; } //the collection of Checkers currently on the board
        public void CreateBoard() //Creating the grid that is the board
        {
            Grid = new string[8,8];
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    Grid[i,j] = " ";
                }
            }
        }
        public void DrawBoard() //View the game board
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    Console.Write(Grid[i,j]);
                }
                Console.WriteLine();
            }
        }
        public void GenerateCheckers()      //Creating all the Checker instances at the beginning of the game
        {
            int[] whitePositions = new int[2];
            int[] blackPositions = new int[2];
            Checkers = new List<Checker>();
            for(int i = 0; i < 8; i++)
            {
                for(int j = 1; j < 8; j+=2)
                {
                    if(i == 0 || i == 2 || i == 6)
                    {
                        if(i == 0 || i == 1 || i == 2)
                        {
                            whitePositions = new int[]{i, j};
                            Checker check = new Checker("white");
                            check.Position = whitePositions;
                            Checkers.Add(check);
                        }
                        else if(i == 5 || i == 6 || i == 7)
                        {
                            blackPositions = new int[]{i, j};
                            Checker check = new Checker("black");
                            check.Position = blackPositions;
                            Checkers.Add(check);
                        }
                    }
                    else if(i == 1 || i == 5 || i == 7)
                    {
                        if(i == 0 || i == 1 || i == 2)
                        {
                            j--;
                            whitePositions = new int[]{i, j};
                            Checker check2 = new Checker("white");
                            check2.Position = whitePositions;
                            Checkers.Add(check2);
                            j++;
                        }
                        else if(i == 5 || i == 6 || i == 7)
                        {
                            j--;
                            blackPositions = new int[]{i, j};
                            Checker check2 = new Checker("black");
                            check2.Position = blackPositions;
                            Checkers.Add(check2);
                            j++;
                        }
                    }
                }
            }
        }
        public void PlaceCheckers()             //puts symbols in Grid to see actual checkers
        {
            for (int i = 0; i < Checkers.Count; i++)
            {
                int[] position = Checkers[i].Position;
                Grid[position[0],position[1]] = Checkers[i].Symbol;
            }
        }
        // public void GenerateBoard() Creating all the Checker instances at the beginning of the game
        // {
            
        // }
        public Checker SelectChecker(int row, int column) //Selecting a particular checker
        {
            int[] position =  new int[]{row, column};
            for(int i = 0; i < Checkers.Count; i++)
            {
                if(Checkers[i].Position[0] == row && Checkers[i].Position[1] == column)
                    return Checkers[i];
            }
            return Checkers[0];
        }
        public void MoveChecker(Checker check, int row, int column)
        {
            Grid[check.Position[0],check.Position[1]] = " "; //removes symbol before moving out
            check.Position[0] = row;
            check.Position[1] = column;
        }
        public void RemoveChecker(int row, int column) //Remove a defeated checker
        {
            Grid[row,column] = " ";
            Checker chek = SelectChecker(row, column);
            Checkers.Remove(chek);
        }
        public Boolean CheckForWin() //Check if all Checkers of one color have been removed
        {
            int count = 0;
            for(int i = 0; i < Checkers.Count-1; i++)
            {
                if(Checkers[i].Symbol == Checkers[i+1].Symbol)
                    count++;
            }
            if(count == Checkers.Count)
                return true;
            return false;
        }
    }
    class Game
    {
        public void Start() //Starting a game
        {
            
        }
    }
}
