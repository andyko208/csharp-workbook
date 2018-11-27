using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = (int)PrimaryColors.RED;
            int y = (int)PrimaryColors.YELLOW;
            int z = (int)PrimaryColors.BLUE;
            Console.WriteLine("A value of {0} can be color Blue", x + y);
            Console.WriteLine("Red color mixed with Yellow color is {0}", CombineColors(PrimaryColors.RED,PrimaryColors.YELLOW));
        }
        public static string CombineColors(PrimaryColors color1, PrimaryColors color2)
        {
            if(color1 == PrimaryColors.RED)
            {
                if(color2 == PrimaryColors.YELLOW)
                    return "ORANGE";
                else if(color2 == PrimaryColors.BLUE){
                    return "PURPLE";
                }
                else if(color2 == PrimaryColors.RED){
                    return "RED";
                }
            }
            else if(color1 == PrimaryColors.YELLOW)
            {
                if(color2 == PrimaryColors.YELLOW)
                    return "YELLOW";
                else if(color2 == PrimaryColors.BLUE){
                    return "GREEN";
                }
                else if(color2 == PrimaryColors.RED){
                    return "ORANGE";
                }
            }
            else if(color1 == PrimaryColors.BLUE)
            {
                if(color2 == PrimaryColors.YELLOW)
                    return "GREEN";
                else if(color2 == PrimaryColors.BLUE){
                    return "BLUE";
                }
                else if(color2 == PrimaryColors.RED){
                    return "PURPLE";
                }
            }
            return "Wrong values!";
        }
        public enum PrimaryColors
        {
            RED = 1 , YELLOW = 2, BLUE = 3
        }
    }
}
