/*School and Students with Courses (Association and Aggregation)
Description: Model a School with multiple Student objects, where each student can enroll in
multiple courses, and each course can have multiple students.
Tasks:
● Define School, Student, and Course classes.
● Model an association between Student and Course to show that students can enroll in multiple courses.
● Model an aggregation relationship between School and Student.
● Demonstrate how a student can view the courses they are enrolled in and how a course can show its enrolled students.*/


using System;
using System.Collections.Generic;

class School
{
	public string SchoolName { get; private set; }
	private List<Student> students;

	public School(string schoolName)
	{
		SchoolName = schoolName;
		students = new List<Student>();
	}

	public void AddStudent(Student student)
	{
		students.Add(student);
	}

	public void DisplayStudents()
	{
		Console.WriteLine($"\nStudents in {SchoolName}:");
		foreach (var student in students)
		{
			Console.WriteLine($" - {student.Name}");
		}
	}
}
