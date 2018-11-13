using System;
using System.Collections.Generic;
using System.Collections;
public class Program
{
	public static void Main()
	{
		Person leia = new Person("Leia", "Organa", "Rebel");
		Person darth = new Person("Darth", "Vader", "Imperial");
		Person cads = new Person("asdf", "qwe", "Rebel");
		Person ewqr = new Person("John", "Tom", "Imperial");
		Ship falcon = new Ship("Rebel", "Smuggling", 2);
		Ship tie = new Ship("Tie", "Fighter", 2);
		falcon.EnterShip(leia, 0);
		falcon.EnterShip(cads, 1);
		tie.EnterShip(darth,0);
		tie.EnterShip(ewqr,1);
		Station targon = new Station("orora", "Imperial", 2);
		targon.EnterStation(falcon, 0);
		targon.EnterStation(tie, 1);
		Console.WriteLine(targon.Roster());
		Console.WriteLine(falcon.Passengers());
		Console.WriteLine(tie.Passengers());
	}
}

class Person
{
	private string firstName;
	private string lastName;
	private string alliance;
	public Person(string firstName, string lastName, string alliance)
	{
		this.firstName = firstName;
		this.lastName = lastName;
		this.alliance = alliance;
	}

	public string FullName
	{
		get
		{
			return this.firstName + " " + this.lastName;
		}

		set
		{
			string[] names = value.Split(' ');
			this.firstName = names[0];
			this.lastName = names[1];
		}
	}
}
class Station
{
	public string name;
	public string alliance;
	public int numShip;
	public Ship[] ships;
	public Station(string name, string alliance, int numShip)
	{
		this.name = name;
		this.alliance = alliance;
		ships = new Ship[numShip];
	}
	public void EnterStation(Ship ship, int seat)
	{
		this.ships[seat] = ship;
	}
	public void ExitStation(int seat)
	{
		this.ships[seat] = null;
	}
	public string Roster()
	{
		string line = " ";
		foreach (var ship in ships)
		{
			line += String.Format("{0}", ship.Alliance) + " ";
		}
		return line;
	}
}
class Ship
{
	private Person[] passengers;
	public Ship(string alliance, string type, int size)
	{
		this.Type = type;
		this.Alliance = alliance;
		this.passengers = new Person[size];
	}

	public string Type
	{
		get;
		set;
	}

	public string Alliance
	{
		get;
		set;
	}

	public String Passengers()
	{
		string line = "";
		foreach (var person in passengers)
		{
			line += String.Format("{0}", person.FullName) + " ";
		}
		return line;
	}

	public void EnterShip(Person person, int seat)
	{
		this.passengers[seat] = person;
	}

	public void ExitShip(int seat)
	{
		this.passengers[seat] = null;
	}
}