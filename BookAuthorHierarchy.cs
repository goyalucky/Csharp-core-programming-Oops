/*Library Management with Books and Authors
○ Description: Model a Book system where Book is the superclass, and Author is a subclass.
○ Tasks:
■ Define a superclass Book with attributes like Title and PublicationYear.
■ Define a subclass Author with additional attributes like Name and Bio.
■ Create a method DisplayInfo() to show details of the book and its author.
○ Goal: Practice single inheritance by extending the base class and adding more specific details in the subclass.*/


using System;

public class Book
{
	public string Title;
	public int PublicationYear;

	public virtual void DisplayInfo()
	{
		Console.WriteLine("Title: " + Title);
		Console.WriteLine("Publication Year: " + PublicationYear);
	}
}

public class Author : Book
{
	public string Name;
	public string Bio;

	public override void DisplayInfo()
	{
		base.DisplayInfo();
		Console.WriteLine("Author Name: " + Name);
		Console.WriteLine("Author Bio: " + Bio);
	}
}
