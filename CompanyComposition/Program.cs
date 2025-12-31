using System;

class Program
{
	static void Main(string[] args)
	{
		Company company = new Company("Access Meditech Pvt. Ltd");

		company.AddDepartment("IT");
		company.AddDepartment("HR");

		company.AddEmployeeToDepartment("IT", 101, "Prashant");
		company.AddEmployeeToDepartment("IT", 102, "Aman");
		company.AddEmployeeToDepartment("HR", 201, "Riya");

		company.DisplayCompanyStructure();

		company = null;
		GC.Collect();

		Console.WriteLine("\nCompany deleted. Departments and Employees no longer exist.");
	}
}
