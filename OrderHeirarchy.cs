/*Online Retail Order Management
○ Description: Create a multilevel hierarchy to manage orders, where Order isthe base class, ShippedOrder is a subclass, and 
DeliveredOrder extends ShippedOrder.
○ Tasks:
■ Define a base class Order with common attributes like orderId and OrderDate.
■ Create a subclass ShippedOrder with additional attributes like TrackingNumber.
■ Create another subclass DeliveredOrder extending ShippedOrder,adding a DeliveryDate attribute.
■ Implement a method GetOrderStatus() to return the current order status based on the class level.
○ Goal: Explore multilevel inheritance, showing how attributes and methods can be added across a chain of classes.*/


using System;

public class Order
{
	public int OrderId;
	public string OrderDate;

	public virtual string GetOrderStatus()
	{
		return "Order Placed";
	}
}

public class ShippedOrder : Order
{
	public string TrackingNumber;

	public override string GetOrderStatus()
	{
		return "Order Shipped";
	}
}

public class DeliveredOrder : ShippedOrder
{
	public string DeliveryDate;

	public override string GetOrderStatus()
	{
		return "Order Delivered";
	}
}
