/* Program to Compute Area of a Circle
Problem Statement: Write a program to create a Circle class with an attribute radius. Add
methods to calculate and display the area and circumference of the circle.*/


using System;

class Circle
{
	public int radius;
	public Circle(int radius)
	{
		this.radius = radius;
	}
	public double CalculateArea()
	{
		return Math.PI * radius * radius;
	}
	public double CalculateCircumference()
	{
		return 2 * Math.PI * radius;
	}
}