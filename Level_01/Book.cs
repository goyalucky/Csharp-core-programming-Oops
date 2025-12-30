/* Program to Handle Book Details
Problem Statement: Write a program to create a Book class with attributes title, author, and
price. Add a method to display the book details.*/


using System;

class Book
{
	public string Title;
	public string Author;
	public int price;
	public Book(string title, string author, int price)
	{
		this.Title = title;
		this.Author = author;
		this.price = price;
	}
	public void DisplayDetails()
	{
		Console.WriteLine("Book Details:");
		Console.WriteLine("Title: " + Title);
		Console.WriteLine("Author: " + Author);
		Console.WriteLine("Price: " + price);
	}
}