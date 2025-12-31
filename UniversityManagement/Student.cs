/* University Management System
Description: Model a university system with Student, Professor, and Course classes. Students
enroll in courses, and professors teach courses. Ensure students and professors can
communicate through methods like EnrollCourse() and AssignProfessor().
Goal: Use association and aggregation to create a university system that emphasizes
relationships and interactions among students, professors, and courses. */


using System;

// Student class
class Student
{
	public string Name { get; set; }

	public Student(string name)
	{
		Name = name;
	}

	// Communication method
	public void EnrollCourse(Course course)
	{
		course.AddStudent(this);
	}
}