using System;
using System.Collections.Generic;
namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<String, int[]> grades = new Dictionary<string, int[]>();
            String stop = "";
            while(stop != "STOP")
            {
                double avg = 0;
                int max = 0;
                int min = 0;
                Console.WriteLine("What's the student's name?");
                String name = Console.ReadLine();
                Console.WriteLine("How many grades are you putting in for this student?");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] gradebook = new int[size];
                for(int i = 0; i < size; i++)
                {
                    Console.WriteLine("What's the his/her grade in a whole number?");
                    int grade = Convert.ToInt32(Console.ReadLine());
                    gradebook[i] = grade;
                    avg += grade;
                    max = gradebook[0];
                    min = gradebook[0];
                    if(gradebook[i] > max)
                        max = gradebook[i];
                    if(gradebook[i] < min)
                        min = gradebook[i];    
                }
                grades.Add(name, gradebook);
                avg = Math.Round((avg/size), 2);
                Console.WriteLine("{0}'s average grade is {1}, max grade is {2}, and min grade is {3}. ", name, avg, max, min);
                Console.WriteLine("Type stop (all caps), otherwise you are keep going!");
                stop = Console.ReadLine();
            }     
        }
    }
}
