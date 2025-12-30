using System;

class Program
{
	static void Main(string[] args)
	{
		// Creating Vehicle object
		Vehicle v1 = new Vehicle("Prashant Goyal", "Car", 5000);

		Console.WriteLine("Initial Vehicle Details:");
		v1.DisplayVehicleDetails();

		// Updating static registration fee
		Vehicle.UpdateRegistrationFee(6500);

		Console.WriteLine("\nAfter Updating Registration Fee:");
		v1.DisplayVehicleDetails();

		Console.WriteLine("\nCurrent Registration Fee: " + Vehicle.GetRegistrationFee());

		// Update static institute name
		Course.UpdateInstituteName("GLA University");

		// Create Course objects
		Course c1 = new Course("C# Programming", 40, 5000);
		Course c2 = new Course("Data Structures", 60, 8000);

		// Call instance method
		c1.DisplayCourseDetails();
		Console.WriteLine();

		c2.DisplayCourseDetails();
		Console.WriteLine();

		// Call static getter
		Console.WriteLine("Institute (from static method): " + Course.GetInstituteName());



		// Creating Product objects
		Product p1 = new Product("Laptop", 55000);
		Product p2 = new Product("Mobile", 25000);

		// Calling instance method
		p1.DisplayProductDetails();
		Console.WriteLine();

		p2.DisplayProductDetails();
		Console.WriteLine();

		// Calling static method
		Product.DisplayTotalProducts();
		Console.ReadLine();
	}
}