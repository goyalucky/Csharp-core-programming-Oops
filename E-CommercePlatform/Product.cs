/*E - commerce Platform with Orders, Customers, and Products
Description: Design an e-commerce platform with Order, Customer, and Product classes.
Model relationships where a Customer places an Order, and each Order contains multiple Product objects.
Goal: Show communication and object relationships by designing a system where customers communicate through orders, and orders aggregate products.*/


using System;
using System.Collections.Generic;

// Product class
class Product
{
	public string Name { get; set; }
	public double Price { get; set; }

	public Product(string name, double price)
	{
		Name = name;
		Price = price;
	}
}
