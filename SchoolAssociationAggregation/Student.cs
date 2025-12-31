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

class Student
{
	public int StudentId { get; private set; }
	public string Name { get; private set; }
	private List<Course> courses;

	public Student(int id, string name)
	{
		StudentId = id;
		Name = name;
		courses = new List<Course>();
	}

	public void EnrollCourse(Course course)
	{
		if (!courses.Contains(course))
		{
			courses.Add(course);
			course.AddStudent(this);
		}
	}

	public void ViewCourses()
	{
		Console.WriteLine($"\nCourses enrolled by {Name}:");
		foreach (var course in courses)
		{
			Console.WriteLine($" - {course.CourseName}");
		}
	}
}
