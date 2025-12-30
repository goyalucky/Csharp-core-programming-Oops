/* Shopping Cart System
Create a Product class to manage shopping cart items with the following features:
● static:
    o A static variable Discount shared by all products.
    o A static method UpdateDiscount() to modify the discount percentage.
● this:
    o Use this to initialize ProductName, Price, and Quantity in the constructor.
● readonly:
    o Use a readonly variable ProductID to ensure each product has a unique identifier that cannot be changed.
● is operator:
    o Validate whether an object is an instance of the Product class before processing its details.*/


using System;

class Product
{
    // static variable
    public static int Discount = 0;

    // readonly variable
    public readonly int ProductID;

    // instance variables
    public string ProductName;
    public double Price;
    public int Quantity;

    // constructor using 'this'
    public Product(string ProductName, double Price, int Quantity, int ProductID)
    {
        this.ProductName = ProductName;
        this.Price = Price;
        this.Quantity = Quantity;
        this.ProductID = ProductID;
    }

    // static method
    public static void UpdateDiscount(int newDiscount)
    {
        if (newDiscount < 0 || newDiscount > 100)
        {
            throw new ArgumentException("Discount must be between 0 and 100");
        }
        Discount = newDiscount;
    }

    // method using 'is' operator
    public void ProcessProductDetails(object obj)
    {
        if (obj is Product)
        {
            Product p = (Product)obj;
            Console.WriteLine("Product Name: " + p.ProductName);
            Console.WriteLine("Price: " + p.Price);
            Console.WriteLine("Quantity: " + p.Quantity);
            Console.WriteLine("Product ID: " + p.ProductID);
            Console.WriteLine("Discount: " + Discount + "%");
        }
        else
        {
            Console.WriteLine("Invalid object. Not a Product instance.");
        }
    }
}
