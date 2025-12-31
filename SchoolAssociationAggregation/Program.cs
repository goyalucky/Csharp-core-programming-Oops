using System;

class Program
{
	static void Main(string[] args)
	{
		School school = new School("Kanha Makhan Public School");

		Student s1 = new Student(1, "Prashant");
		Student s2 = new Student(2, "lucky");

		Course math = new Course("Mathematics");
		Course cs = new Course("Computer Science");

		school.AddStudent(s1);
		school.AddStudent(s2);

		s1.EnrollCourse(math);
		s1.EnrollCourse(cs);

		s2.EnrollCourse(cs);

		school.DisplayStudents();

		s1.ViewCourses();
		s2.ViewCourses();

		math.ViewStudents();
		cs.ViewStudents();
	}
}
