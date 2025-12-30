/*Employee Records
? Develop an Employee class with :
	o employeeID (public)
	o department(protected)
	o salary(private)
? Implement methods to:
	o Modify salary using a public method.
	o Create a subclass Manager to access employeeID and department.*/


using System;

class Employee
{
	// Public member
	public int employeeID;

	// Protected member
	protected string department;

	// Private member
	private double salary;

	// Constructor
	public Employee(int employeeID, string department, double salary)
	{
		this.employeeID = employeeID;
		this.department = department;
		this.salary = salary;
	}

	// Public method to modify salary
	public void UpdateSalary(double amount)
	{
		if (amount > 0)
		{
			salary = amount;
		}
		else
		{
			Console.WriteLine("Invalid salary amount");
		}
	}

	// Public method to access salary
	public double GetSalary()
	{
		return salary;
	}
}

// Subclass demonstrating access
class Manager : Employee
{
	public string level;

	public Manager(int employeeID, string department, double salary, string level)
		: base(employeeID, department, salary)
	{
		this.level = level;
	}

	// Accessing public and protected members
	public void DisplayDetails()
	{
		Console.WriteLine("Employee ID: " + employeeID);   // Public
		Console.WriteLine("Department: " + department);    // Protected
		Console.WriteLine("Salary: " + GetSalary());       // Private via method
		Console.WriteLine("Manager Level: " + level);
	}
}
