/* Library and Books (Aggregation)
Description: Create a Library class that contains multiple Book objects. Model the relationship such that a library can have many books, 
but a book can exist independently (outside of a specific library).
Tasks:
● Define a Library class with a List<Book> collection.
● Define a Book class with attributes such as Title and Author.
● Demonstrate the aggregation relationship by creating books and adding them to different libraries.
Goal: Understand aggregation by modeling a real-world relationship where the Library aggregates Book objects.*/


using System;

class Book
{
	public string Title { get; set; }
	public string Author { get; set; }

	public Book(string title, string author)
	{
		Title = title;
		Author = author;
	}

	public void DisplayBook()
	{
		Console.WriteLine($"Title: {Title}, Author: {Author}");
	}
}
