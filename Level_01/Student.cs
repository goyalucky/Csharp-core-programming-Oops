/* University Student Management
Create a Student class to manage student data with the following features:
● static:
	o A static variable UniversityName shared across all students.
	o A static method DisplayTotalStudents() to show the number of students enrolled.
● this:
	o Use this in the constructor to initialize Name, RollNumber, and Grade.
● readonly:
	o Use a readonly variable RollNumber for each student that cannot be changed.
● is operator:
	o Check if a given object is an instance of the Student class before performing operations like displaying or updating grades.
*/

using System;

class Student
{
	public static string UniversityName = "GLA university";
	private static int totalStudents = 0;
	public readonly int RollNumber;
	public string Name;
	public string Grade;
	public Student(string Name, int RollNumber, string Grade)
	{
		this.Name = Name;
		this.RollNumber = RollNumber;
		this.Grade = Grade;
		totalStudents++;
	}
	public static void DisplayTotalStudents()
	{
		Console.WriteLine("Total no of Students in University: " + totalStudents);
	}
	public void DisplayStudentDetails(object obj)
	{
		if (obj is Student)
		{
			Student stu = (Student)obj;
			Console.WriteLine("University Name: " + UniversityName);
			Console.WriteLine("Student Name: " + stu.Name);
			Console.WriteLine("Roll Number: " + stu.RollNumber);
			Console.WriteLine("Grade: " + stu.Grade);
		}
		else
		{
			Console.WriteLine("Not a Student object");
		}
	}
}