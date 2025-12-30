/* Library Book System
o Create a Book class with attributes title, author, price, and availability.
o Implement a method BorrowBook() to borrow a book.*/


using System;

class LibraryBook
{
	public string Title;
	public string Author;
	public double Price;
	public bool IsAvailable;
	// Parameterized Constructor
	public LibraryBook(string title, string author, int price)
	{
		Title = title;
		Author = author;
		Price = price;
		IsAvailable = true;
	}
	// Method BorrowBook() to borrow a book.
	public void BorrowBook()
	{
		if (IsAvailable)
		{
			IsAvailable = false;
			Console.WriteLine($"You have borrowed '{Title}'.");
		}
		else
		{
			Console.WriteLine($"Sorry, '{Title}' is currently not available.");
		}
	}
	public void Display()
	{
		Console.WriteLine($"Title: {Title}, Author: {Author}, Price: {Price}, Available: {IsAvailable}");
	}
}