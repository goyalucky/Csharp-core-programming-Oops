/*University with Faculties and Departments (Composition and Aggregation)
Description: Create a University with multiple Faculty members and Department objects.Model it so that the University and its Departments are in 
a composition relationship(deleting a university deletes all departments), and the Faculty members are in an aggregation relationship 
(faculty can exist outside of any specific department).
Tasks:
● Define a University class with Department and Faculty classes.
● Demonstrate how deleting a University also deletes its Departments.
● Show that Faculty members can exist independently of a Department.
Goal: Understand the differences between composition and aggregation in modeling complex hierarchical relationships.*/

using System;
using System.Collections.Generic;

class University
{
	public string UniversityName { get; private set; }

	private List<Department> departments; // Composition
	private List<Faculty> faculties;       // Aggregation

	public University(string universityName)
	{
		UniversityName = universityName;
		departments = new List<Department>();
		faculties = new List<Faculty>();
	}

	// Composition: University creates Departments
	public void AddDepartment(string departmentName)
	{
		departments.Add(new Department(departmentName));
	}

	// Aggregation: Faculty passed from outside
	public void AddFaculty(Faculty faculty)
	{
		faculties.Add(faculty);
	}

	public void AssignFacultyToDepartment(string deptName, Faculty faculty)
	{
		foreach (var dept in departments)
		{
			if (dept.DepartmentName == deptName)
			{
				dept.AssignFaculty(faculty);
				return;
			}
		}
	}

	public void DisplayUniversity()
	{
		Console.WriteLine($"University: {UniversityName}");
		foreach (var dept in departments)
		{
			dept.DisplayFaculties();
		}
	}
}
