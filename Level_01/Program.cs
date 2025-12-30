using System;

class Program
{
	static void Main(string[] args)
	{

		Manager mgr = new Manager(1001, "IT", 75000, "Senior Manager");
		mgr.DisplayDetails();
		// Modifying salary using public method
		mgr.UpdateSalary(85000);
		Console.WriteLine("Updated Salary: " + mgr.GetSalary());


		SavingsAccount sa = new SavingsAccount("ACC12345", "Prashant Goyal", 5000, 4.5);
		sa.DisplayAccountDetails();
		sa.Deposit(2000);
		sa.Withdraw(1500);
		Console.WriteLine("Updated Balance: " + sa.GetBalance());

		EBook ebook = new EBook("978-0131101630", "C# Programming", "John Smith", "PDF");
		ebook.DisplayDetails();
		// Modifying author using public setter
		ebook.SetAuthor("Robert Martin");
		Console.WriteLine("Updated Author: " + ebook.GetAuthor());


		PostgraduateStudent pg = new PostgraduateStudent(101, "Lucky Goyal", 8.9, "AI & ML");
		pg.DisplayDetails();
		// Modifying CGPA using public method
		pg.SetCGPA(9.2);
		Console.WriteLine("Updated CGPA: " + pg.GetCGPA());
	}
}
