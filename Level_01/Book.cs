/* Library Management System
Create a Book class to manage library books with the following features:
● static:
	o A static variable LibraryName shared across all books.
	o A static method DisplayLibraryName() to print the library name.
● this:
	o Use this to initialize Title, Author, and ISBN in the constructor.
● readonly:
	o Use a readonly variable ISBN to ensure the unique identifier of a book cannot be changed.
● is operator:
	o Verify if an object is an instance of the Book class before displaying its details.*/


using System;

class Book
{
	// static variable (shared by all books)
	public static string LibraryName = "Central Library";

	// readonly variable (cannot be changed once assigned)
	public readonly string ISBN;

	// instance variables
	public string Title;
	public string Author;

	// constructor using 'this' keyword
	public Book(string Title, string Author, string ISBN)
	{
		this.Title = Title;
		this.Author = Author;
		this.ISBN = ISBN;
	}

	// static method
	public static void DisplayLibraryName()
	{
		Console.WriteLine("Library Name: " + LibraryName);
	}

	// method using 'is' operator
	public void DisplayBookDetails(object obj)
	{
		if (obj is Book)
		{
			Book b = (Book)obj;
			Console.WriteLine("Title: " + b.Title);
			Console.WriteLine("Author: " + b.Author);
			Console.WriteLine("ISBN: " + b.ISBN);
		}
		else
		{
			Console.WriteLine("Invalid object. Not a Book instance.");
		}
	}
}
