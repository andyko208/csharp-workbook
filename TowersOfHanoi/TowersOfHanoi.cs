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
            game.drawBoard();
            game.MovePiece("A", "B");
            Console.WriteLine();
            game.drawBoard();
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
        public Stack<Block> Blocks{get;}
        public Tower()
        {
            Blocks = new Stack<Block>();
        }
        public void Push(Block block)
        {
            Blocks.Push(block);
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
        public void drawBoard()
        {
            foreach(string key in Towers.Keys)
            {
                Console.Write(key + ": ");
                Tower index = Towers[key];
                foreach(Block blck in index.Blocks)    
                {
                    Console.Write(blck.Weight + " ");
                }
                Console.WriteLine();
            }
        }
        public void MovePiece(string popOff, string pushOn)
        {
            Stack<Block> st = Towers[popOff].Blocks;
            Stack<Block> rev = new Stack<Block>();
            while (st.Count != 0)
            {
                rev.Push(st.Pop());
            }
            Towers[pushOn].Push(rev.Pop());
            // Towers[pushOn].Push(Towers[popOff].Blocks.Pop());
        }
    }
}
