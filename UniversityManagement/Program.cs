using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		Student s1 = new Student("Amit");
		Student s2 = new Student("Riya");

		Professor p1 = new Professor("Dr. Sharma");

		Course c1 = new Course("Artificial Intelligence");
		s1.EnrollCourse(c1);
		s2.EnrollCourse(c1);

		p1.AssignProfessor(c1);

		c1.DisplayCourseDetails();
	}
}
