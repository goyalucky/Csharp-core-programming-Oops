/*Employee Management System
Description:Create an Employee hierarchy for different employee types such as Manager, Developer, and Intern.
Tasks:
1.Define a base class Employee :
	o Add three attributes: Name(string), Id(integer), and Salary(double).
	o Add a method DisplayDetails() to display the details of an employee.
2. Define subclasses Manager, Developer, and Intern:
	o Manager: Add an additional attribute TeamSize (integer).
	o Developer: Add an additional attribute ProgrammingLanguage (string).
	o Intern: Add an additional attribute InternshipDuration (string).
3. Goal:
	o Practice inheritance by creating subclasses with specific attributes and overriding superclass methods (e.g., DisplayDetails()) 
	to display details specific to each type of employee*/


using System;

public class Employee
{
	public string Name;
	public int Id;
	public double Salary;

	public virtual void DisplayDetails()
	{
		Console.WriteLine($"Name: {Name}, Id: {Id}, Salary: {Salary}");
	}
}

public class Manager : Employee
{
	public int TeamSize;

	public override void DisplayDetails()
	{
		base.DisplayDetails();
		Console.WriteLine("Team Size: " + TeamSize);
	}
}

public class Developer : Employee
{
	public string ProgrammingLanguage;

	public override void DisplayDetails()
	{
		base.DisplayDetails();
		Console.WriteLine("Programming Language: " + ProgrammingLanguage);
	}
}

public class Intern : Employee
{
	public string InternshipDuration;

	public override void DisplayDetails()
	{
		base.DisplayDetails();
		Console.WriteLine("Internship Duration: " + InternshipDuration);
	}
}
