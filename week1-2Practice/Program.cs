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
        }
    }
}
