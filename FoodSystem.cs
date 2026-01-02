/*Online Food Delivery System
Description: Create an online food delivery system:
● Define an abstract class FoodItem with fields like itemName, price, and quantity.
● Add abstract methods CalculateTotalPrice() and concrete methods like GetItemDetails().
● Extend it into classes VegItem and NonVegItem, overriding CalculateTotalPrice() to include additional charges.
● Use an interface IDiscountable with methods ApplyDiscount() and GetDiscountDetails().
● Use polymorphism to handle different types of food items dynamically.*/


using System;

public interface IDiscountable
{
	void ApplyDiscount();
	void GetDiscountDetails();
}

public abstract class FoodItem
{
	private string itemName;
	protected double price;
	protected int quantity;

	protected FoodItem(string itemName, double price, int quantity)
	{
		this.itemName = itemName;
		this.price = price;
		this.quantity = quantity;
	}

	public abstract double CalculateTotalPrice();

	public void GetItemDetails()
	{
		Console.WriteLine($"Item Name: {itemName}");
		Console.WriteLine($"Price: ₹{price}");
		Console.WriteLine($"Quantity: {quantity}");
	}
}

public class VegItem : FoodItem, IDiscountable
{
	private const double VegPackagingCharge = 20;

	public VegItem(string name, double price, int quantity)
		: base(name, price, quantity) { }

	public override double CalculateTotalPrice()
	{
		return (price * quantity) + VegPackagingCharge;
	}

	public void ApplyDiscount()
	{
		Console.WriteLine("10% Discount Applied on Veg Item");
	}

	public void GetDiscountDetails()
	{
		Console.WriteLine("Veg Item Discount: 10%");
	}
}


public class NonVegItem : FoodItem
{
	private const double NonVegExtraCharge = 50;

	public NonVegItem(string name, double price, int quantity)
		: base(name, price, quantity) { }

	public override double CalculateTotalPrice()
	{
		return (price * quantity) + NonVegExtraCharge;
	}
}
