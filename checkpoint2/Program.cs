using System;

namespace checkpoint2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
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
        public string[][] Grid { get; set; } //the "grid" that makes up the board
        public List<Checker> Checkers { get; set; } //the collection of Checkers currently on the board
        CreateBoard() //Creating the grid that is the board
        {

        }
        DrawBoard() //View the game board
        {

        }
        GenerateBoard() //Creating all the Checker instances at the beginning of the game
        {

        }
        SelectChecker() //Selecting a particular checker
        {

        }
        RemoveChecker() //Remove a defeated checker
        {

        }
        CheckForWin() //Check if all Checkers of one color have been removed
        {

        }
    }
    class Game
    {
        Start() //Starting a game
        {
            
        }
    }
}
