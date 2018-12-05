using System;
using System.Collections.Generic;

namespace Inheritance
{
    class Program
    {
        // this is the main entry point and driver for this program
        static void Main(string[] args)
        {
            Engineering Computer = new Engineering("engineering", 135, 40);
            Literature English = new Literature("Liberal Arts", 120, 15);
            Business Advertising = new Business("Business", 125, 35);
            Console.WriteLine(English.intro());         //superclass method
            Console.WriteLine(Computer.intro());        //overridden method
            Console.WriteLine();
            Console.WriteLine("Computer's data type is {0}", Computer.GetType());
            Console.WriteLine("English's data type is {0}", English.GetType());
            Console.WriteLine("Advertising's data type is {0}", Advertising.GetType());
        }
    }

    public abstract class Major
    {
        string department;
        int creditHours;
        public Major(string department, int creditHours)
        {
            this.department = department;
            this.creditHours = creditHours;
        }
        virtual
        public string intro()  //superclass method
        {
            return "I'm from " + department + " department";
        }
    }
    public class Engineering: Major
    {
        int labHours;
        public Engineering(String department, int creditHours, int labHours):base(department, creditHours)
        {
            this.labHours = labHours;
        }
        override
        public string intro()
        {
            return String.Format("I'll be stuck in lab for {0} hours!",labHours);
        }
    }
    public class Literature: Major
    {
        int numLitBooks;
        public Literature(String department, int creditHours, int numLitBooks):base(department, creditHours)
        {
            this.numLitBooks = numLitBooks;
        }
    }
    public class Business: Major
    {
        int hourSpeech;
        public Business(String department, int creditHours, int hourSpeech):base(department, creditHours)
        {
            this.hourSpeech = hourSpeech;
        }
    }

    // abstract vehicle class, cannot be  instantiated
    public abstract class Vehicle {
        String make;
        String model;
        String color;
        int numWheels;


        public Vehicle(String color, String make, String model, int numWheels){
            this.color = color;
            this.make = make;
            this.model = model;
            this.numWheels = numWheels;
        }

        // overiding the ToString method from the base object class
        override
        public String ToString(){
            String formated = String.Format("{0} {1} {2}", color, make, model);
            return formated;

        }
    }

    // extending the Vehicle class
    public  class Car: Vehicle{
        bool isHatchback;

        // callin the base constructor in vehicle
        public Car(String color, String make, String model, bool isHatchback):base(color, make, model, 4){
            this.isHatchback = isHatchback;
        }
    }
}
