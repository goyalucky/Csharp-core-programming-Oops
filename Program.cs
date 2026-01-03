using System;

class Program
{
	static void Main()
	{
		Student student = new Student("lucky Goyal", 811, 78);
		University university = new University();

		university.EnrollStudent(student);

		using (AcademicEngine engine = new AcademicEngine())
		{
			engine.EvaluateStudent(student);
			Console.WriteLine(student.GetStudentDetails());
		}

	}
}
