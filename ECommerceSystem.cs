/*E - Commerce Platform
Description: Develop a simplified e-commerce platform:
● Create an abstract class Product with fields like productId, name, and price, and an abstract method CalculateDiscount().
● Extend it into concrete classes: Electronics, Clothing, and Groceries.
● Implement an interface ITaxable with methods CalculateTax() and GetTaxDetails() for applicable product categories.
● Use encapsulation to protect product details, allowing updates only through setter methods.
● Showcase polymorphism by creating a method that calculates and prints the final price (price + tax - discount) for a list of products.*/


using System;

public interface ITaxable
{
	double CalculateTax();
	string GetTaxDetails();
}

public abstract class Product
{
	// Encapsulation
	private int productId;
	private string name;
	private double price;

	public void SetProductId(int id) => productId = id;
	public void SetName(string name) => this.name = name;
	public void SetPrice(double price) => this.price = price;

	public int GetProductId() => productId;
	public string GetName() => name;
	public double GetPrice() => price;

	public abstract double CalculateDiscount();

	public double GetFinalPrice(double tax)
	{
		return price + tax - CalculateDiscount();
	}
}

public class Electronics : Product, ITaxable
{
	public override double CalculateDiscount()
	{
		return GetPrice() * 0.10; 
	}

	public double CalculateTax()
	{
		return GetPrice() * 0.18; 
	}

	public string GetTaxDetails()
	{
		return "18% GST on Electronics";
	}
}

public class Clothing : Product, ITaxable
{
	public override double CalculateDiscount()
	{
		return GetPrice() * 0.15; 
	}

	public double CalculateTax()
	{
		return GetPrice() * 0.05;
	}

	public string GetTaxDetails()
	{
		return "5% GST on Clothing";
	}
}

public class Groceries : Product
{
	public override double CalculateDiscount()
	{
		return GetPrice() * 0.05; 
	}
}
