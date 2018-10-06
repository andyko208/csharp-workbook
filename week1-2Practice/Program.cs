using System;

namespace week1_2Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // #1
            Console.WriteLine("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int sum = num1 + num2;
            Console.WriteLine("Your result is: {0}", sum);
            // #2
            Console.WriteLine("How many yards? ");
            double yard = Convert.ToDouble(Console.ReadLine());
            double inch = yard * 36;
            Console.WriteLine("There are {0} inches in {1} yard", inch,yard);
            // #3
            bool people = true;
            // #4
            bool f = false;
            // #5
            float num = 5.321f;
            // if(people == true && f == false)
            //     Console.WriteLine(num);
            // #6
            Console.WriteLine("var num^2 is {0}", num * num);
            // #7
            String firstName = "Kyung Myung";
            String lastName = "Ko";
            int age = 18;
            String job = "student";
            String favoriteBand = "rubberband";
            String favoriteSportsTeam = "WorldCup Team";
            // #8
            Console.WriteLine("My first name is {0}", firstName);
            Console.WriteLine("My last name is {0}",lastName);
            Console.WriteLine("My age is {0}",age);
            Console.WriteLine("My job is {0}", job);
            Console.WriteLine("My favoirte band is {0}",favoriteBand);
            Console.WriteLine("My favoirte sports team is {0}", favoriteSportsTeam);
            // #9
            num = (int)num;
            // Console.WriteLine(num);
            // #10
            Console.WriteLine("The sum of 100 and 10 is {0}", 100 + 10);
            Console.WriteLine("The product of 100 and 10 is {0}",100 * 10);
            Console.WriteLine("The difference between 100 and 10 is {0}",100 - 10);
            Console.WriteLine("The quotient of 100 and 10 is {0}",100 / 10);
        }
    }
}
