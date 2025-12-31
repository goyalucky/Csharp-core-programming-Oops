/*Company and Departments (Composition)
Description: A Company has several Department objects, and each department contains Employee objects. Model this using composition, where 
deleting a Company should also delete all departments and employees.
Tasks:
● Define a Company class that contains multiple Department objects.
● Define an Employee class within each Department.
● Show the composition relationship by ensuring that when a Company object is
deleted, all associated Department and Employee objects are also removed.
Goal: Understand composition by implementing a relationship where Department and Employee objects cannot exist without a Company.*/


using System.Collections.Generic;

class Department
{
	public string DepartmentName { get; private set; }
	private List<Employee> employees;

	public Department(string departmentName)
	{
		DepartmentName = departmentName;
		employees = new List<Employee>();
	}

	public void AddEmployee(int id, string name)
	{
		employees.Add(new Employee(id, name));
	}

	public void DisplayEmployees()
	{
		foreach (var emp in employees)
		{
			System.Console.WriteLine($"   Employee ID: {emp.EmployeeId}, Name: {emp.Name}");
		}
	}
}
