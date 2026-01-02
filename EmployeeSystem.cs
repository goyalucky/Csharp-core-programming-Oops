/*Employee Management System
Description: Build an employee management system with the following requirements:
● Use an abstract class Employee with fields like employeeId, name, and baseSalary.
● Provide an abstract method CalculateSalary() and a concrete method DisplayDetails().
● Create two subclasses: FullTimeEmployee and PartTimeEmployee, implementing CalculateSalary() based on work hours or fixed salary.
● Use encapsulation to restrict direct access to fields and provide properties for access.
● Create an interface IDepartment with methods like AssignDepartment() and GetDepartmentDetails().
● Ensure polymorphism by processing a list of employees and displaying their details using the Employee reference.*/


using System;

public interface IDepartment
{
	void AssignDepartment(string department);
	string GetDepartmentDetails();
}

public abstract class Employee
{
	// Encapsulation
	private int employeeId;
	private string name;
	private double baseSalary;
	protected string department;

	public int EmployeeId
	{
		get { return employeeId; }
		set { employeeId = value; }
	}

	public string Name
	{
		get { return name; }
		set { name = value; }
	}

	public double BaseSalary
	{
		get { return baseSalary; }
		set { baseSalary = value; }
	}

	// Abstract method
	public abstract double CalculateSalary();

	// Concrete method
	public void DisplayDetails()
	{
		Console.WriteLine(
			$"ID: {EmployeeId}, Name: {Name}, Salary: {CalculateSalary()}, Dept: {department}");
	}
}

public class FullTimeEmployee : Employee, IDepartment
{
	public override double CalculateSalary()
	{
		return BaseSalary;
	}

	public void AssignDepartment(string department)
	{
		this.department = department;
	}

	public string GetDepartmentDetails()
	{
		return department;
	}
}

public class PartTimeEmployee : Employee, IDepartment
{
	public int WorkHours;
	public double HourlyRate;

	public override double CalculateSalary()
	{
		return WorkHours * HourlyRate;
	}

	public void AssignDepartment(string department)
	{
		this.department = department;
	}

	public string GetDepartmentDetails()
	{
		return department;
	}
}
