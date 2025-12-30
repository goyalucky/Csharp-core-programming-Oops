/* Circle Class
o Write a Circle class with a radius attribute.
o Use constructor chaining to initialize radius with both default and
user-provided values.*/


using System;

class Circle
{
	public double Radius;

	// Default Constructor
	public Circle() : this(5.0)   // Constructor chaining
	{
		// Calls parameterized constructor
	}

	// Parameterized Constructor
	public Circle(double radius)
	{
		Radius = radius;
	}

	// Method to calculate area
	public double GetArea()
	{
		return Math.PI * Radius * Radius;
	}
}
