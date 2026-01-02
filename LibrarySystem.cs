/*Library Management System
Description: Develop a library management system:
● Use an abstract class LibraryItem with fields like itemId, title, and author.
● Add an abstract method GetLoanDuration() and a concrete method GetItemDetails().
● Create subclasses Book, Magazine, and DVD, overriding GetLoanDuration() with specific logic.
● Implement an interface IReservable with methods ReserveItem() and CheckAvailability().
● Apply encapsulation to secure details like the borrower’s personal data.
● Use polymorphism to allow a general LibraryItem reference to manage all items.*/


using System;

public interface IReservable
{
	void ReserveItem();
	void CheckAvailability();
}

public abstract class LibraryItem
{
	private int itemId;
	private string title;
	private string author;

	private string borrowerName;

	protected LibraryItem(int itemId, string title, string author)
	{
		this.itemId = itemId;
		this.title = title;
		this.author = author;
	}

	public void AssignBorrower(string name)
	{
		borrowerName = name;
	}

	public abstract int GetLoanDuration();

	public void GetItemDetails()
	{
		Console.WriteLine($"Item ID: {itemId}");
		Console.WriteLine($"Title: {title}");
		Console.WriteLine($"Author: {author}");
	}
}

public class Book : LibraryItem, IReservable
{
	public Book(int id, string title, string author)
		: base(id, title, author) { }

	public override int GetLoanDuration()
	{
		return 14;
	}

	public void ReserveItem()
	{
		Console.WriteLine("Book Reserved Successfully");
	}

	public void CheckAvailability()
	{
		Console.WriteLine("Book is Available");
	}
}


public class Magazine : LibraryItem
{
	public Magazine(int id, string title, string author)
		: base(id, title, author) { }

	public override int GetLoanDuration()
	{
		return 7;
	}
}


public class DVD : LibraryItem
{
	public DVD(int id, string title, string author)
		: base(id, title, author) { }

	public override int GetLoanDuration()
	{
		return 3;
	}
}
