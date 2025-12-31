using System;

// Main class
class Program
{
	static void Main()
	{
		// Products
		Product p1 = new Product("Laptop", 65000);
		Product p2 = new Product("Mouse", 1500);
		Product p3 = new Product("Keyboard", 2500);

		// Order
		Order order1 = new Order(101);
		order1.AddProduct(p1);
		order1.AddProduct(p2);
		order1.AddProduct(p3);

		// Customer
		Customer customer = new Customer("Prashant");

		// Communication
		customer.PlaceOrder(order1);
	}
}
