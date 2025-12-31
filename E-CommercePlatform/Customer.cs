/*E-commerce Platform with Orders, Customers, and Products
Description: Design an e-commerce platform with Order, Customer, and Product classes.Model relationships where a Customer places an Order, 
and each Order contains multiple Product objects.
Goal: Show communication and object relationships by designing a system where customers
communicate through orders, and orders aggregate products.
*/

class Customer
{
	public string Name { get; set; }

	public Customer(string name)
	{
		Name = name;
	}
	public void PlaceOrder(Order order)
	{
		Console.WriteLine($"{Name} placed Order #{order.OrderId}");
		order.DisplayOrderDetails();
	}
}