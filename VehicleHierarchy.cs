/*Vehicle and Transport System
Description:Design a vehicle hierarchy where Vehicle is the superclass, and Car, Truck, and Motorcycle are subclasses with unique attributes.
Tasks:
1.Define a superclass Vehicle:
	o Add two attributes: MaxSpeed(integer) and FuelType(string).
	o Add a method DisplayInfo() to display the vehicle's information.
2. Define subclasses Car, Truck, and Motorcycle that inherit from Vehicle:
	o Car: Add an additional attribute SeatCapacity (integer).
	o Truck: Add an additional attribute PayloadCapacity (integer).
	o Motorcycle: Add an additional attribute HasSidecar (boolean).
3. Demonstrate polymorphism:
	o Store objects of type Car, Truck, and Motorcycle in an array of Vehicle type.
	o Call the DisplayInfo() method on each using System;*/


public class Vehicle
{
	public int MaxSpeed;
	public string FuelType;
	public virtual void DisplayInfo()
	{
		Console.WriteLine($"MaxSpeed: {MaxSpeed}, FuelType: {FuelType}");
	}
}

public class Car: Vehicle
{
	public int SeatCapacity;
	public override void DisplayInfo()
	{
		base.DisplayDetails();
		Console.WriteLine("SeatCapacity " + SeatCapacity);
	}
}
public class Truck : Vehicle
{
	public int PayloadCapacity;
	public override void DisplayInfo()
	{
		base.DisplayDetails();
		Console.WriteLine("Payload Capacity " + PayloadCapacity);
	}
}
public class Motorcycle : Vehicle
{
	public bool SeatCapacity;
	public override void HasSidecar()
	{
		base.DisplayDetails();
		Console.WriteLine("HasSidecar " + HasSidecar);
	}
}