/*Company and Departments (Composition)
Description: A Company has several Department objects, and each department contains Employee objects. Model this using composition, where 
deleting a Company should also delete all departments and employees.
Tasks:
● Define a Company class that contains multiple Department objects.
● Define an Employee class within each Department.
● Show the composition relationship by ensuring that when a Company object is
deleted, all associated Department and Employee objects are also removed.
Goal: Understand composition by implementing a relationship where Department and Employee objects cannot exist without a Company.*/



using System;
using System.Collections.Generic;

class Company
{
	public string CompanyName { get; private set; }
	private List<Department> departments;

	public Company(string companyName)
	{
		CompanyName = companyName;
		departments = new List<Department>();
	}

	public void AddDepartment(string departmentName)
	{
		departments.Add(new Department(departmentName));
	}

	public void AddEmployeeToDepartment(string departmentName, int empId, string empName)
	{
		foreach (var dept in departments)
		{
			if (dept.DepartmentName == departmentName)
			{
				dept.AddEmployee(empId, empName);
				return;
			}
		}
	}

	public void DisplayCompanyStructure()
	{
		Console.WriteLine($"Company: {CompanyName}");
		foreach (var dept in departments)
		{
			Console.WriteLine($" Department: {dept.DepartmentName}");
			dept.DisplayEmployees();
		}
	}
}
