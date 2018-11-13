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
            game.printKeys();
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
        Stack<Block> Blocks;
        public Tower()
        {
            Blocks = new Stack<Block>();
        }
        public void Push(Block block)
        {
            Blocks.Push(block);
        }
        public Stack<Block> Pop()
        {
            return Blocks;
        }
    }
    class Game
    {
		Dictionary<string, Tower> Towers;

        public Game()
        {
            Towers = new Dictionary<String, Tower>();
            Towers["A"] = new Tower();
            Towers["B"] = new Tower();
            Towers["C"] = new Tower();
            Block a = new Block(1);
            Block b = new Block(2);
            Block c = new Block(3);
            Block d = new Block(4);
            Towers["A"].Push(a);
            Towers["A"].Push(b);
            Towers["A"].Push(c);
            Towers["A"].Push(d);
        }
        public void printKeys()
        {
            foreach(string key in Towers.Keys)
            {
                Console.Write(key + ": ");
                foreach(Block blck in Towers.Values)    //has to be ~~ in blocks inside stack
                {
                    Console.Write(blck.Weight);
                }
                Console.WriteLine();
            }
        }
    }
}
