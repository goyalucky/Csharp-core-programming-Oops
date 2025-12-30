/*Online Course Management
? Design a Course class with :
	o Instance Variables: courseName, duration, fee.
	o Class Variable: instituteName(common for all courses).
? Implement the following methods:
	o An instance method DisplayCourseDetails() to display course details.
	o A class method UpdateInstituteName() to modify the institute name for all courses.*/


using System;

class Course
{
	private string courseName;
	private double duration;
	private double fee;
	private static string instituteName = "Unknown Institute";

	public Course(string courseName, double duration, double fee)
	{
		this.courseName = courseName;
		this.duration = duration;
		this.fee = fee;
	}

	public void DisplayCourseDetails()
	{
		Console.WriteLine("Institute Name: " + instituteName);
		Console.WriteLine("Course Name: " + courseName);
		Console.WriteLine("Duration (hours): " + duration);
		Console.WriteLine("Fee: " + fee.ToString("C"));
	}

	public static void UpdateInstituteName(string newName)
	{
		if (string.IsNullOrWhiteSpace(newName))
		{
			throw new ArgumentException("Institute name cannot be null or empty.", nameof(newName));
		}
		instituteName = newName;
	}

	public static string GetInstituteName()
	{
		return instituteName;
	}
}