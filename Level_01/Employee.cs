/* Program to Display Employee Details
Problem Statement: Write a program to create an Employee class with attributes name, id,
and salary. Add a method to display the details.*/


using System;

class Employee
{
	public string Name;
	public int Id;
	public int Salary;
	public Employee(string name,int id, int salary)
	{
		this.Name = name;
		this.Id = id;
		this.Salary = salary;
	}
	public void DisplayDetails()
	{
		Console.WriteLine("Employee Details:");
		Console.WriteLine("Name: " + Name);
		Console.WriteLine("ID: " + Id);
		Console.WriteLine("Salary: " + Salary);
	}
}