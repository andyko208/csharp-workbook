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
            while(game.CheckForWin() != true)
            {
                Console.WriteLine("What tower to pick up from? (A, B, C)");
                String pop = Console.ReadLine();
                pop = pop.ToUpper();
                Console.WriteLine("Where to set down the block?");
                String push = Console.ReadLine();
                push = push.ToUpper();
                if(game.IsLegal(pop, push) == true)
                {
                    game.MovePiece(pop, push);
                    game.drawBoard();
                }
                else{
                    Console.WriteLine("That is not a legal move.");
                }
            }
            Console.WriteLine("You won!!");
            
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
            Stack<Block> st = Towers[popOff].Blocks;    //to reduce time typing
            Stack<Block> rev = new Stack<Block>();      //to get the top block
            Stack<Block> cover = new Stack<Block>();    //for the stack that is being pushed
            while (st.Count != 0)
            {
                rev.Push(st.Pop());
            }
            while (Towers[pushOn].Blocks.Count != 0)        //gets blocks from the stack of being pushed
            {
                cover.Push(Towers[pushOn].Blocks.Pop());
            }
            Towers[pushOn].Blocks.Clear();          //clears out the stack being pushed to put in order
            Towers[pushOn].Push(rev.Pop());
            while(cover.Count != 0)                 //fills the block in right place
            {
                Towers[pushOn].Blocks.Push(cover.Pop());
            }
            while(rev.Count != 0)                   //fills the block in right place #2
            {
                Towers[popOff].Blocks.Push(rev.Pop());
            }
        }
        public Boolean IsLegal(string popOff, string pushOn)
        {
            if(Towers[pushOn].Blocks.Count == 0)
                return true;
            if(Towers[pushOn].Blocks.Count >= 1)
            {
                Stack<Block> rev1 = new Stack<Block>();    
                Stack<Block> rev2 = new Stack<Block>();
                while(Towers[popOff].Blocks.Count != 0)
                {
                    rev1.Push(Towers[popOff].Blocks.Pop());
                }
                Block topOne = rev1.Peek();        //top Block from Towers[popOff]
                while(Towers[pushOn].Blocks.Count != 0)
                {
                    rev2.Push(Towers[pushOn].Blocks.Pop());
                }
                Block topTwo = rev2.Peek();        //top Block from Towers[pushOn]
                while(rev1.Count != 0)              //put the blocks back in to where they were at
                {
                    Towers[popOff].Blocks.Push(rev1.Pop());
                }
                while(rev2.Count != 0)              //put the blocks back in to where they were at
                {
                    Towers[pushOn].Blocks.Push(rev2.Pop());
                }
                if(topOne.Weight < topTwo.Weight)
                    return true;
                return false;
            }
            return false;
        }
        public Boolean CheckForWin()
        {
            if(Towers["B"].Blocks.Count == 4 || Towers["C"].Blocks.Count == 4)
                return true;
            return false;
        }
    }
}
