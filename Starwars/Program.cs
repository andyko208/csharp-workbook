using System;

public class Program
{
	public static void Main()
	{
		Person leia = new Person("Leia", "Organa", "Rebel");
		Person darth = new Person("Darth", "Vader", "Imperial");
		Ship falcon = new Ship("Rebel", "Smuggling", 2);
		Ship tie = new Ship("Tie", "Fighter", 1);
		falcon.EnterShip(leia, 0);
		tie.EnterShip(darth,0);
		Station targon = new Station("orora", "Imperial", 2);
		targon.EnterStation(falcon, 0);
		targon.EnterStation(tie, 1);
		// targon.ExitStation(1);
		targon.Roster();

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
		this.numShip = numShip;
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
		foreach (var ship in ships)
		{
			return String.Format("{0}", ship.Alliance);
		}
		return "that's all!";
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

	public string Passengers
	{
		get
		{
			foreach (var person in passengers)
			{
				return String.Format("{0}", person.FullName);
			}

			return "That's Everybody!";
		}
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