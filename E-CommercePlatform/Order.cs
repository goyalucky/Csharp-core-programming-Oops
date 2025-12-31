/*E-commerce Platform with Orders, Customers, and Products
Description: Design an e-commerce platform with Order, Customer, and Product classes.Model relationships where a Customer places an Order, 
and each Order contains multiple Product objects.
Goal: Show communication and object relationships by designing a system where customers
communicate through orders, and orders aggregate products.*/


using System.Collections.Generic;

class Order
{
	public int OrderId { get; set; }
	private List<Product> products = new List<Product>();

	public Order(int orderId)
	{
		OrderId = orderId;
	}

	public void AddProduct(Product product)
	{
		products.Add(product);
	}

	public double GetTotalAmount()
	{
		double total = 0;
		foreach (var product in products)
		{
			total += product.Price;
		}
		return total;
	}

	public void DisplayOrderDetails()
	{
		Console.WriteLine($"Order ID: {OrderId}");
		foreach (var product in products)
		{
			Console.WriteLine($"- {product.Name} : ₹{product.Price}");
		}
		Console.WriteLine($"Total Amount: ₹{GetTotalAmount()}");
	}
}