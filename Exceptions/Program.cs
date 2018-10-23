using System;

namespace Exceptions
{
    class Program
    {
        public static void Main()
        {
            // Console.WriteLine("Enter hand 1:");
            // string hand1 = Console.ReadLine().ToLower();
            try
            {
                String hand1 = getInput();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Enter a valid input please");
                String hand1 = getInput();
            }
            Random rnd = new Random();
            int comp = rnd.Next(1, 4); //random int between 1 and 3
            string hand2 = ComputerHands(comp);
            Console.WriteLine("Computer's hand: {0}", hand2);
            // Console.WriteLine(CompareHands(hand1, hand2));

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
        }


        public static string getInput()
        {
            Console.WriteLine("Enter hand1: ");
            String hand = Console.ReadLine().ToLower();
            if(hand != "rock" && hand != "paper" && hand != "scissors")
                throw new Exception("Wrong hand exception!");
            return hand;
        }
        public static string ComputerHands(int randint)
        {
            if(randint == 1)
            {
                return "rock";
            }
            else if(randint == 2)
            {
                return "paper";
            }
            return "scissors";  //if(randint == 3)
        }
        public static string CompareHands(string hand1, string hand2)
        {
            // Your code here
            if(hand1.Equals(hand2))
            {
                return "It's a tie!";
            }
            if(hand1.Equals("rock"))
            {
                if (hand2.Equals("scissors"))
                {
                    return "Hand one wins!";
                }
                else            //if hand2 is paper
                {
                    return "Computer wins!";
                }
            }
            if(hand1.Equals("scissors"))
            {
                if (hand2.Equals("paper"))
                {
                    return "Hand one wins!";
                }
                else            //if hand2 is rock
                {
                    return "Computer wins!";
                }
            }
            if(hand1.Equals("paper"))
            {
                if (hand2.Equals("rock"))
                {
                    return "Hand one wins!";
                }
                else            //if hand2 is scissors
                {
                    return "Computer wins!";
                }
            }
            return hand1 + ' ' + hand2;
        }
    }
}

