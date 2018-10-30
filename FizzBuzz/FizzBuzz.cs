using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int end = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < end; i++)     //16 is just random number I chose
            {
                if(i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine("FizzBuzz");
                else if(i % 3 == 0)
                    Console.WriteLine("Fizz");
                else if(i % 5 == 0)
                    Console.WriteLine("Buzz");    
                else
                {
                    Console.WriteLine("{0}", i);
                }                    
            }
        }
    }
}
