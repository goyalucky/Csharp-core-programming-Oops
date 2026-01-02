/*Vehicle Rental System
Description: Design a system to manage vehicle rentals:
● Define an abstract class Vehicle with fields like vehicleNumber, type, and rentalRate.
● Add an abstract method CalculateRentalCost(int days).
● Create subclasses Car, Bike, and Truck with specific implementations of CalculateRentalCost().
● Use an interface IInsurable with methods CalculateInsurance() and GetInsuranceDetails().
● Apply encapsulation to restrict access to sensitive details like insurance policy numbers.
● Demonstrate polymorphism by iterating over a list of vehicles and calculating rental and insurance costs for each.*/


using System;

public interface IInsurable
{
	double CalculateInsurance();
	string GetInsuranceDetails();
}

public abstract class Vehicle
{
	// Encapsulation (private fields)
	private string vehicleNumber;
	private string type;
	private double rentalRate;
	private string insurancePolicyNumber;

	public void SetVehicleNumber(string number) => vehicleNumber = number;
	public void SetType(string type) => this.type = type;
	public void SetRentalRate(double rate) => rentalRate = rate;
	protected void SetInsurancePolicy(string policy) => insurancePolicyNumber = policy;

	public string GetVehicleNumber() => vehicleNumber;
	public string GetType() => type;
	public double GetRentalRate() => rentalRate;

	protected string GetInsurancePolicy()
	{
		return insurancePolicyNumber;
	}

	public abstract double CalculateRentalCost(int days);
}

public class Car : Vehicle, IInsurable
{
	public Car()
	{
		SetType("Car");
		SetInsurancePolicy("CAR-INS-101");
	}

	public override double CalculateRentalCost(int days)
	{
		return GetRentalRate() * days;
	}

	public double CalculateInsurance()
	{
		return 500; // fixed insurance
	}

	public string GetInsuranceDetails()
	{
		return "Car Insurance Policy";
	}
}

public class Bike : Vehicle, IInsurable
{
	public Bike()
	{
		SetType("Bike");
		SetInsurancePolicy("BIKE-INS-202");
	}

	public override double CalculateRentalCost(int days)
	{
		return GetRentalRate() * days * 0.8;
	}

	public double CalculateInsurance()
	{
		return 200;
	}

	public string GetInsuranceDetails()
	{
		return "Bike Insurance Policy";
	}
}

public class Truck : Vehicle, IInsurable
{
	public Truck()
	{
		SetType("Truck");
		SetInsurancePolicy("TRUCK-INS-303");
	}

	public override double CalculateRentalCost(int days)
	{
		return GetRentalRate() * days * 1.5;
	}

	public double CalculateInsurance()
	{
		return 1000;
	}

	public string GetInsuranceDetails()
	{
		return "Truck Insurance Policy";
	}
}
