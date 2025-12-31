/* Library and Books (Aggregation)
Description: Create a Library class that contains multiple Book objects. Model the relationship such that a library can have many books, 
but a book can exist independently (outside of a specific library).
Tasks:
● Define a Library class with a List<Book> collection.
● Define a Book class with attributes such as Title and Author.
● Demonstrate the aggregation relationship by creating books and adding them to different libraries.
Goal: Understand aggregation by modeling a real-world relationship where the Library aggregates Book objects.*/


using System;
using System.Collections.Generic;

class Library
{
	public string LibraryName { get; set; }
	public List<Book> Books { get; set; }

	public Library(string libraryName)
	{
		LibraryName = libraryName;
		Books = new List<Book>();
	}

	public void AddBook(Book book)
	{
		Books.Add(book);
	}

	public void DisplayBooks()
	{
		Console.WriteLine($"\nLibrary: {LibraryName}");
		foreach (Book book in Books)
		{
			book.DisplayBook();
		}
	}
}
