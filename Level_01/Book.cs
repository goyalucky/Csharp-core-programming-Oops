/*Book Library System
? Design a Book class with :
	o ISBN (public)
	o title(protected)
	o author(private)
? Implement methods to:
	o Set and get the author name.
	o Create a subclass EBook to access ISBN and title and demonstrate access
	modifiers.*/


using System;


class Book
{
	// Public member
	public string ISBN;

	// Protected member
	protected string title;

	// Private member
	private string author;

	// Constructor
	public Book(string isbn, string title, string author)
	{
		ISBN = isbn;
		this.title = title;
		this.author = author;
	}

	// Setter for author
	public void SetAuthor(string author)
	{
		this.author = author;
	}

	// Getter for author
	public string GetAuthor()
	{
		return author;
	}
}

// Subclass demonstrating access modifiers
class EBook : Book
{
	public string format;

	public EBook(string isbn, string title, string author, string format)
		: base(isbn, title, author)
	{
		this.format = format;
	}

	// Method accessing public & protected members
	public void DisplayDetails()
	{
		Console.WriteLine("ISBN: " + ISBN);        // Public
		Console.WriteLine("Title: " + title);      // Protected
		Console.WriteLine("Author: " + GetAuthor());// Private accessed via method
		Console.WriteLine("Format: " + format);
	}
}

// Main Class
class Program
{
	static void Main()
	{
		EBook ebook = new EBook("978-0131101630", "C# Programming", "John Smith", "PDF");

		ebook.DisplayDetails();

		// Modifying author using public setter
		ebook.SetAuthor("Robert Martin");
		Console.WriteLine("Updated Author: " + ebook.GetAuthor());
	}
}
