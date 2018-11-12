using System;
using System.Collections.Generic;
using System.Collections;


namespace TowersOfHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
        }
    }
    class Block
    {
        public int Weight{get; private set;}   
        public Block(int Weight)
        {
            this.Weight = Weight;
        }
    }
    class Tower
    {
        Stack<Block> towers;
        public Tower()
        {
            towers = new Stack<Block>();
        }
    }
    class Game
    {
		Dictionary<int, Stack<Block>> setBlocks;
        public Game()
        {
            setBlocks = new Dictionary<int, Stack<Block>>();
            
        }
    }
}
