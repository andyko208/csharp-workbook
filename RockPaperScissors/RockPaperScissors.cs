using System;

namespace RockPaperScissors
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter hand 1:");
            string hand1 = Console.ReadLine().ToLower();
            Console.WriteLine("Enter hand 2:");
            string hand2 = Console.ReadLine().ToLower();
            Console.WriteLine(CompareHands(hand1, hand2));

            // leave this command at the end so your program does not close automatically
            Console.ReadLine();
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
                    return "Hand two wins!";
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
                    return "Hand two wins!";
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
                    return "Hand two wins!";
                }
            }
            return hand1 + ' ' + hand2;
        }
    }
}
