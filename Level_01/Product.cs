/*Product Inventory
● Create a Product class with :
    o Instance Variables: productName, price.
    o Class Variable: totalProducts(shared among all products).

● Implement the following methods:
    o An instance method DisplayProductDetails() to display the details of a product.
    o A class method DisplayTotalProducts() to show the total number of products created.*/


using System;

class Product
{
    private string productName;
    private double price;
    private static int totalProducts;

    public Product(string name, double price)
    {
        this.productName = name;
        this.price = price;
        totalProducts++;
    }

    public void DisplayProductDetails()
    {
        Console.WriteLine("Product Name: " + productName);
        Console.WriteLine("Price: " + price.ToString("C"));
    }

    public static void DisplayTotalProducts()
    {
        Console.WriteLine("Total Products: " + totalProducts);
    }
}