using System;

namespace checkpoint1
{
    class Program
    {
        static void Main(string[] args)
        {
            // count();
            // exit();
            // factorial();
            // Guess();
            maximum();
        }
        //1
        public static void count() 
        {
            int total = 0;
            for (int i = 1; i < 101; i++)
            {
                if(i % 3 == 0)
                    total++;
            }
            Console.WriteLine(total);
        }

        //2 
        public static void exit()
        {
            String stop = "";
            int sum = 0;
            Console.WriteLine("Type ok to stop!");
            while(stop != "ok")
            {
                Console.WriteLine("Enter a number:");
                sum += Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Stop?");
                stop = Console.ReadLine();
            }
            Console.WriteLine(sum);
        }
        //3
        public static void factorial()
        {
            int final = 0;
            Console.WriteLine("Enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = num-1; i > 0; i--)
            {
                num *= i;
            }
            Console.WriteLine(num);
        }
        //4
        public static void Guess()
        {
            Random rnd = new Random();
            int ranint1 = rnd.Next(1, 10);
            int ranint2 = rnd.Next(1, 10);
            int ranint3 = rnd.Next(1, 10);
            int ranint4 = rnd.Next(1, 10);
            // Console.WriteLine("{0}{1}{2}{3}", ranint1,ranint2,ranint3,ranint4);
            int chances = 4;
            int guess = 0;
            Boolean found = false;
            while(chances != 0 && found == false)
            {
                Console.WriteLine("Guess a number between 1~10");
                guess = Convert.ToInt32(Console.ReadLine());
                if(guess == ranint1)
                {
                    Console.WriteLine("You won!");
                    found = true;
                }
                else if(guess == ranint2)
                {
                    Console.WriteLine("You won!");
                    found = true;
                }
                else if(guess == ranint3)
                {
                    Console.WriteLine("You won!");
                    found = true;
                }
                else if(guess == ranint4)
                {
                    Console.WriteLine("You won!");
                    found = true;
                }
                else
                {
                    chances--;
                    Console.WriteLine("{0}", chances);
                }
            }
            if(chances == 0)
                Console.WriteLine("You lost!");           
        }
        //5
        public static void maximum()
        {
            int[] arr = new int[5];
            int max = 0;
            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter a number:");
                arr[i] = Convert.ToInt32(Console.ReadLine());                
            }
            for(int i = 1; i < 5; i++)
            {
                max = arr[0];
                if(max < arr[i])
                    max = arr[i];
            }
            Console.WriteLine("{0}", max);
        }
    }
}
