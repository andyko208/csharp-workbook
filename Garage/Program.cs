using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Person passenger1 = new Person("Johny");
            Person passenger2 = new Person("Perbee");
            Person passenger3 = new Person("Loopy");
            Person passenger4 = new Person("Dominic");
            Car blueCar = new Car("blue", 4);               //4 is # of seats in the car
            Garage smallGarage = new Garage(2);
            
            smallGarage.ParkCar(blueCar, 0);
            Console.WriteLine(smallGarage.Cars);
            blueCar.Sitdown(0, passenger1);                 //adding person into a car object, blueCar
            blueCar.Sitdown(1, passenger2);      
            blueCar.Sitdown(2, passenger3);
            blueCar.Sitdown(3, passenger4);   
            Console.WriteLine(blueCar.Persons);             
        }
        class Person
        {
            public Person(string namae)
            {
                name = namae;
            }
            public string name { get; private set; }
        }
        class Car
        {
            public Person[] persons;
            public string Color { get; private set; }
            public Car(string initialColor, int seatSize)
            {
                Color = initialColor;
                this.persons = new Person[seatSize];

            }
            public void Sitdown (int spot, Person passenger)
            {
                persons[spot] = passenger;
            }
            public string Persons {
                get {
                    for (int i = 0; i < persons.Length; i++)
                    {
                        if (persons[i] != null) {
                            Console.WriteLine(String.Format("{0} is in seat #{1}.", persons[i].name, i+1)); //i+1 **just to make seat# neat
                        }
                    }
                    return "That's all!";
                }
            }
        }

        class Garage
        {
            private Car[] cars;
            
            public Garage(int initialSize)
            {
                Size = initialSize;
                this.cars = new Car[initialSize];
            }
            
            public int Size { get; private set; }
            
            public void ParkCar (Car car, int spot)
            {
                cars[spot] = car;
            }
            public string Cars {
                get {
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (cars[i] != null) {
                            Console.WriteLine(String.Format("The {0} car is in spot {1}.", cars[i].Color, i));
                        }
                    }
                    return "\n";
                }
            }
        }
    }
}
