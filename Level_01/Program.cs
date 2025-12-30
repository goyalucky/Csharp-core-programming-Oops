using System;

class program
{
	static void Main(string[] args)
	{
		Patient pat1 = new Patient(123,"Anoop",21, "Asthma");
		Patient pat2 = new Patient(000,"Sparsh",22, "Cancer");
		pat1.DisplayPatientDetails((pat1));
		Patient.GetTotalPatients();


		Vehicle v1 = new Vehicle(1234,"luckygoyal","Bike");
		Vehicle v2 = new Vehicle(1222, "rishabhtiwari", "Scooter");
		Vehicle.UpdateRegistrationFee(100);
		v1.DisplayVehicleDetails(v1);
		v2.DisplayVehicleDetails(v2);


		Student st1 = new Student("Lucky", 36, "A");
		Student st2 = new Student("rishabh", 38, "A+");
		st1.DisplayStudentDetails((st1));
		Student.DisplayTotalStudents();

		Product p1 = new Product("Laptop", 65000, 2, 101);
		Product p2 = new Product("Mouse", 1200, 5, 102);
		Product.UpdateDiscount(10);
		p1.ProcessProductDetails(p1);
		p2.ProcessProductDetails(p2);

		Employee emp1 = new Employee("Lucky", 101, "Full Stack Developer");
		Employee emp2 = new Employee("Goyal", 102, "Ai Engineer");
		emp1.DisplayEmployeeDetails((emp1));
		Employee.DisplayTotalEmployees();

		Book book1 = new Book("Clean Code", "Robert C. Martin", "978-0132350884");
		Book.DisplayLibraryName();
		book1.DisplayBookDetails(book1);

		BankAccount acc1 = new BankAccount("Prashant", 101);
		BankAccount acc2 = new BankAccount("Aman", 102);
		acc1.DisplayDetails(acc1);
		BankAccount.GetTotalAccounts();
	}
}