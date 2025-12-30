/*Employee Management System
Design an Employee class with the following features:
● static:
	o A static variable CompanyName shared by all employees.
	o A static method DisplayTotalEmployees() to show the total number of employees.
● this:
	o Use this to initialize Name, Id, and Designation in the constructor.
● readonly:
	o Use a readonly variable Id for the employee ID, which cannot be modified after assignment.
● is operator:
	o Check if a given object is an instance of the Employee class before printing the employee details.*/


using System;

class Employee
{
	public static string CompanyName = "Access Meditech";
	private static int totalEmployee = 0;

	public readonly int employeeID;
	public string Name;
	public string Designation;

	public Employee(string Name, int Id, string Designation)
	{
		this.Name = Name;
		this.employeeID = Id;
		this.Designation = Designation;
		totalEmployee++;
	}

	public static void DisplayTotalEmployees()
	{
		Console.WriteLine("Total no of Employees in Company: " + totalEmployee);
	}
	public void DisplayEmployeeDetails(object obj)
	{
		if (obj is Employee)
		{
			Employee emp = (Employee)obj;
			Console.WriteLine("Company Name: " + CompanyName);
			Console.WriteLine("Employee Name: " + emp.Name);
			Console.WriteLine("Employee ID: " + emp.employeeID);
			Console.WriteLine("Designation: " + emp.Designation);
		}
		else
		{
			Console.WriteLine("Not an Employee object");
		}
	}
}