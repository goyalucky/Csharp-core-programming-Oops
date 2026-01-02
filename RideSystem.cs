/*Ride - Hailing Application
Description: Develop a ride-hailing application.
● Abstract Class:
	o Define an abstract class Vehicle with fields: vehicleId, driverName, and ratePerKm.
	o Add an abstract method CalculateFare(double distance).
	o Implement a concrete method GetVehicleDetails().
● Subclasses:
	o Extend Vehicle into Car, Bike, and Auto.
	o Override CalculateFare() based on type-specific rates.
● Interface:
	o Implement an interface IGPS.
	o Define methods GetCurrentLocation() and UpdateLocation().
● Encapsulation:
	o Secure driver and vehicle details using private fields and properties.
● Polymorphism:
	o Create a method that processes multiple vehicle types dynamically.
	o Calculate fares based on the Vehicle reference.*/


using System;

public interface IGPS
{
	void GetCurrentLocation();
	void UpdateLocation();
}

public abstract class Vehicle
{
	private int vehicleId;
	private string driverName;
	protected double ratePerKm;

	protected Vehicle(int vehicleId, string driverName, double ratePerKm)
	{
		this.vehicleId = vehicleId;
		this.driverName = driverName;
		this.ratePerKm = ratePerKm;
	}

	public abstract double CalculateFare(double distance);

	public void GetVehicleDetails()
	{
		Console.WriteLine($"Vehicle ID: {vehicleId}");
		Console.WriteLine($"Driver Name: {driverName}");
		Console.WriteLine($"Rate per KM: ₹{ratePerKm}");
	}
}

public class Car : Vehicle, IGPS
{
	private const double BaseCharge = 50;

	public Car(int id, string driver, double rate)
		: base(id, driver, rate) { }

	public override double CalculateFare(double distance)
	{
		return BaseCharge + (ratePerKm * distance);
	}

	public void GetCurrentLocation()
	{
		Console.WriteLine("Car location: Sector 62");
	}

	public void UpdateLocation()
	{
		Console.WriteLine("Car location updated");
	}
}

public class Bike : Vehicle, IGPS
{
	private const double BaseCharge = 20;

	public Bike(int id, string driver, double rate)
		: base(id, driver, rate) { }

	public override double CalculateFare(double distance)
	{
		return BaseCharge + (ratePerKm * distance);
	}

	public void GetCurrentLocation()
	{
		Console.WriteLine("Bike location: MG Road");
	}

	public void UpdateLocation()
	{
		Console.WriteLine("Bike location updated");
	}
}

public class Auto : Vehicle
{
	private const double BaseCharge = 30;

	public Auto(int id, string driver, double rate)
		: base(id, driver, rate) { }

	public override double CalculateFare(double distance)
	{
		return BaseCharge + (ratePerKm * distance);
	}
}
