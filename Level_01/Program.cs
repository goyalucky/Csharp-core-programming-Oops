using System;

class Program
{
	static void Main(string[] args)
	{
		Book book = new Book("Harry Potter", "F. Scott Fitzgerald",450);
		book.DisplayDetails();

		Circle circle = new Circle(7);
		Console.WriteLine("Area of Circle: " + circle.CalculateArea());
		Console.WriteLine("Circumference of Circle: " + circle.CalculateCircumference());

		Employee emp = new Employee("Alice", 38, 50000);
		emp.DisplayDetails();
	}
}