/* University Management System
Description: Model a university system with Student, Professor, and Course classes. Students enroll in courses, and professors teach courses. 
Ensure students and professors can communicate through methods like EnrollCourse() and AssignProfessor().
Goal: Use association and aggregation to create a university system that emphasizes relationships and interactions among students,
professors, and courses.*/


using System;
using System.Collections.Generic;

// Course class
class Course
{
	public string CourseName { get; set; }
	public Professor AssignedProfessor { get; private set; }
	private List<Student> students = new List<Student>();

	public Course(string courseName)
	{
		CourseName = courseName;
	}

	public void AddStudent(Student student)
	{
		students.Add(student);
		Console.WriteLine($"{student.Name} enrolled in {CourseName}");
	}

	public void AssignProfessor(Professor professor)
	{
		AssignedProfessor = professor;
		Console.WriteLine($"{professor.Name} assigned to {CourseName}");
	}

	public void DisplayCourseDetails()
	{
		Console.WriteLine($"\nCourse: {CourseName}");
		Console.WriteLine($"Professor: {AssignedProfessor?.Name}");
		Console.WriteLine("Students:");
		foreach (var s in students)
		{
			Console.WriteLine($"- {s.Name}");
		}
	}
}