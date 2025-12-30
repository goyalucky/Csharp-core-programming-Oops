using System;
using System.Runtime.InteropServices;

class  Program
{
    static void Main(string[] args)
    {
		CarRental car = new CarRental("Toyota Camry", 5, 40.0);
		car.DisplayRentalDetails();
		Console.WriteLine();


		LibraryBook book3 = new LibraryBook("Clean Code", "Robert C. Martin", 499);
		book3.Display();
		book3.BorrowBook();   // First borrow
		book3.BorrowBook();   // Try again
		Console.WriteLine();
		book3.Display();


		// Original booking
		HotelBooking booking1 = new HotelBooking("Prashant", 205, 3);
		booking1.DisplayBooking();

		Console.WriteLine();

		// Copy booking
		HotelBooking booking2 = new HotelBooking(booking1);
		booking2.DisplayBooking();

		// Original object
		Person p1 = new Person("Prashant", 21);
		Console.WriteLine("Original Person:");
		p1.Display();

		Console.WriteLine();

		// Cloned object using copy constructor
		Person p2 = new Person(p1);
		Console.WriteLine("Copied Person:");
		p2.Display();


		// Using default radius
		Circle c1 = new Circle();
		Console.WriteLine($"Radius: {c1.Radius}");
		Console.WriteLine($"Area: {c1.GetArea():F2}");
		Console.WriteLine();

		// Using user-provided radius
		Circle c2 = new Circle(10);
		Console.WriteLine($"Radius: {c2.Radius}");
		Console.WriteLine($"Area: {c2.GetArea():F2}");


		//Calling parametrized constructor
		Book book2 = new Book("The Alchemist", "Paulo Coelho", 350);
		Console.WriteLine("Book 2:");
		Console.WriteLine($"Title: {book2.Title}, Author: {book2.Author}, Price: {book2.Price}");

		//calling default constructor
		Book book1 = new Book();
		Console.WriteLine("Book 1:");
		Console.WriteLine($"Title: {book1.Title}, Author: {book1.Author}, Price: {book1.Price}");
		Console.WriteLine();

	}
}