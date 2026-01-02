/*Vehicle Management System with Hybrid Inheritance
○ Description: Model a vehicle system where Vehicle is the superclass and ElectricVehicle and PetrolVehicle are subclasses. Additionally, 
create a Refuelable interface implemented by PetrolVehicle.
○ Tasks:
■ Define a superclass Vehicle with attributes like MaxSpeed and Model.
■ Create an interface Refuelable with a method Refuel().
■ Define subclasses ElectricVehicle and PetrolVehicle.PetrolVehicle should implement Refuelable, while ElectricVehicle include a Charge() method.
○ Goal: Use hybrid inheritance by having PetrolVehicle implement both Vehicle and Refuelable, demonstrating how Java interfaces allow 
adding multiple behaviors.*/


using System;

public class Vehicle
{
	public string Model;
	public int MaxSpeed;
}

public interface Refuelable
{
	void Refuel();
}

public class ElectricVehicle : Vehicle
{
	public void Charge()
	{
		Console.WriteLine("Electric vehicle is charging");
	}
}

public class PetrolVehicle : Vehicle, Refuelable
{
	public void Refuel()
	{
		Console.WriteLine("Petrol vehicle is refueling");
	}
}
