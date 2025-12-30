/* University Management System
● Create a Student class with :
	o rollNumber (public)
	o name(protected)
	o CGPA(private)
● Implement methods to:
	o Access and modify CGPA using public methods.
	o Create a subclass PostgraduateStudent to demonstrate the use of protected
	members.*/


using System;

class Student
{
	// Public member
	public int rollNumber;

	// Protected member
	protected string name;

	// Private member
	private double cgpa;

	// Constructor
	public Student(int rollNumber, string name, double cgpa)
	{
		this.rollNumber = rollNumber;
		this.name = name;
		this.cgpa = cgpa;
	}

	// Public method to get CGPA
	public double GetCGPA()
	{
		return cgpa;
	}

	// Public method to set CGPA
	public void SetCGPA(double cgpa)
	{
		if (cgpa >= 0 && cgpa <= 10)
		{
			this.cgpa = cgpa;
		}
		else
		{
			Console.WriteLine("Invalid CGPA!");
		}
	}
}

// Subclass demonstrating protected access
class PostgraduateStudent : Student
{
	public string specialization;

	public PostgraduateStudent(int rollNumber, string name, double cgpa, string specialization)
		: base(rollNumber, name, cgpa)
	{
		this.specialization = specialization;
	}

	// Method accessing protected member
	public void DisplayDetails()
	{
		Console.WriteLine("Roll Number: " + rollNumber);
		Console.WriteLine("Name: " + name); // Protected member accessible
		Console.WriteLine("Specialization: " + specialization);
		Console.WriteLine("CGPA: " + GetCGPA());
	}
}

