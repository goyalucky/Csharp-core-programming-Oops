/*School System with Different Roles
○ Description: Create a hierarchy for a school system where Person is the superclass, and Teacher, Student, and Staff are subclasses.
○ Tasks:
■ Define a superclass Person with common attributes like Name and Age.
■ Define subclasses Teacher, Student, and Staff with specific attributes (e.g., Subject for Teacher and Grade for Student).
■ Each subclass should have a method like DisplayRole() that describes the role.
○ Goal: Demonstrate hierarchical inheritance by modeling different roles in a school, each with shared and unique characteristics.*/


using System;

public class Person
{
	public string Name;
	public int Age;

	public virtual void DisplayRole()
	{
		Console.WriteLine("Person");
	}
}

public class Teacher : Person
{
	public string Subject;

	public override void DisplayRole()
	{
		Console.WriteLine($"Teacher - Subject: {Subject}");
	}
}

public class Student : Person
{
	public string Grade;

	public override void DisplayRole()
	{
		Console.WriteLine($"Student - Grade: {Grade}");
	}
}

public class Staff : Person
{
	public string Department;

	public override void DisplayRole()
	{
		Console.WriteLine($"Staff - Department: {Department}");
	}
}
