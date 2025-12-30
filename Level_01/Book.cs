/* Book Class
o Create a Book class with attributes title, author, and price.
o Provide both default and parameterized constructors.*/


using System;

class Book
{
	public string Title;
	public string Author;
	public int Price;

	public Book(string title, string author, int price)
	{
		this.Title = title;
		this.Author = author;
		this.Price = price;
	}

	public Book()
	{
		this.Title = "Harry Potter";
		this.Author = "F. Scott Fitzgerald";
		this.Price = 40000;
	}
}