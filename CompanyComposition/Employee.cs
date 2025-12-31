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

class Employee
{
	public int EmployeeId { get; private set; }
	public string Name { get; private set; }

	public Employee(int id, string name)
	{
		EmployeeId = id;
		Name = name;
	}
}
