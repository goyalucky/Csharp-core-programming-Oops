using System;

class Program
{
	static void Main(string[] args)
	{
		
		Book b1 = new Book("Clean Code", "rishabh tiwari");
		Book b2 = new Book("The FullStack Programmer", "Lucky Goyal");
		Book b3 = new Book("Design Patterns", "Erich Gamma");

		Library cityLibrary = new Library("City Library");
		Library universityLibrary = new Library("University Library");

		
		cityLibrary.AddBook(b1);
		cityLibrary.AddBook(b2);

		universityLibrary.AddBook(b2); 
		universityLibrary.AddBook(b3);

		cityLibrary.DisplayBooks();
		universityLibrary.DisplayBooks();
	}
}
