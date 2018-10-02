using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int numMeals;
            int days;
            int monthMeal;

            Console.WriteLine("What's your name?");
            name = Console.ReadLine();
            Console.WriteLine("How many times do you eat meals a day?");
            numMeals = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many days are there in this month?");
            days = Convert.ToInt32(Console.ReadLine());
            monthMeal = numMeals * days;

            Console.WriteLine("Hello! My name is {0} and I eat {1} meals a day. I will eat {2} meals this month.", name,numMeals,monthMeal);
        }
    }
}
