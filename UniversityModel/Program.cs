using System;

class Program
{
	static void Main(string[] args)
	{
		Faculty f1 = new Faculty(1, "Dr. Sharma");
		Faculty f2 = new Faculty(2, "Dr. Verma");

		University uni = new University("GLA University");

		uni.AddDepartment("Computer Science");
		uni.AddDepartment("Mechanical");

		uni.AddFaculty(f1);
		uni.AddFaculty(f2);

		uni.AssignFacultyToDepartment("Computer Science", f1);

		uni.DisplayUniversity();

		uni = null;
		GC.Collect();

		Console.WriteLine("\nUniversity deleted.");
		Console.WriteLine($"Faculty still exists: {f2.Name}");
	}
}
