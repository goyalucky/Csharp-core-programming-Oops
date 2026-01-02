using System;
using System.Collections.Generic;

class Program
{
	static void Main()
	{
		List<Vehicle> rides = new List<Vehicle>
		{
			new Car(1, "Rahul", 15),
			new Bike(2, "Amit", 8),
			new Auto(3, "Suresh", 10)
		};


		double distance = 10; // in km
		foreach (Vehicle vehicle in rides)
		{
			vehicle.GetVehicleDetails();
			Console.WriteLine($"Fare for {distance} km: Rs.{vehicle.CalculateFare(distance)}");
			Console.WriteLine();
		}

		IGPS gps = new Car(4, "Prashant", 18);
		gps.GetCurrentLocation();
		gps.UpdateLocation();


		List<Patient> patients = new List<Patient>
		{
			new InPatient(101, "Prashant", 21, 5, 2000),
			new OutPatient(102, "GLAIAN", 22, 800)
		};
		foreach (Patient patient in patients)
		{
			patient.GetPatientDetails();
			Console.WriteLine($"Total Bill: ₹{patient.CalculateBill()}"); // Polymorphism
			Console.WriteLine();
		}
		IMedicalRecord record = new InPatient(103, "Lucky", 25, 3, 1800);
		record.AddRecord();
		record.ViewRecords();


		List<FoodItem> order = new List<FoodItem>
		{
			new VegItem("Paneer Butter Masala", 250, 2),
			new NonVegItem("Chicken Biryani", 350, 1)
		};
		foreach (FoodItem item in order)
		{
			item.GetItemDetails();
			Console.WriteLine($"Total Price: ₹{item.CalculateTotalPrice()}"); // Polymorphism
			Console.WriteLine();
		}
		IDiscountable discountItem = new VegItem("Veg Burger", 120, 3);
		discountItem.GetDiscountDetails();
		discountItem.ApplyDiscount();


		List<LibraryItem> items = new List<LibraryItem>
		{
			new Book(1, "Clean Code", "Robert C. Martin"),
			new Magazine(2, "Time Magazine", "Time Editors"),
			new DVD(3, "Inception", "Christopher Nolan")
		};
		foreach (LibraryItem item in items)
		{
			item.GetItemDetails();
			Console.WriteLine($"Loan Duration: {item.GetLoanDuration()} days"); // Polymorphism
			Console.WriteLine();
		}
		IReservable reservableItem = new Book(4, "Atomic Habits", "James Clear");
		reservableItem.CheckAvailability();
		reservableItem.ReserveItem();


		List<BankAccount> accounts = new List<BankAccount>
		{
			new SavingsAccount("SA101", "Prashant", 50000),
			new CurrentAccount("CA201", "GLAIAN", 120000)
		};
		foreach (BankAccount account in accounts)
		{
			account.Deposit(5000);
			account.CalculateInterest();   // Polymorphism
			account.DisplayDetails();
			Console.WriteLine();
		}
		ILoanable loanAccount = new SavingsAccount("SA301", "Lucky", 80000);
		loanAccount.ApplyForLoan();
		loanAccount.CalculateLoanEligibility();



		List<Vehicle> vehicles = new List<Vehicle>();
		Car car = new Car();
		car.SetVehicleNumber("CAR101");
		car.SetRentalRate(2000);

		Bike bike = new Bike();
		bike.SetVehicleNumber("BIKE202");
		bike.SetRentalRate(800);

		Truck truck = new Truck();
		truck.SetVehicleNumber("TRK303");
		truck.SetRentalRate(3000);

		vehicles.Add(car);
		vehicles.Add(bike);
		vehicles.Add(truck);
		foreach (Vehicle v in vehicles)
		{
			double rentalCost = v.CalculateRentalCost(3);
			double insurance = 0;

			if (v is IInsurable insurable)
				insurance = insurable.CalculateInsurance();

			Console.WriteLine(
				$"{v.GetType()} Rental: {rentalCost}, Insurance: {insurance}");
		}



		List<Product> products = new List<Product>();
		Electronics e = new Electronics();
		e.SetProductId(1);
		e.SetName("Laptop");
		e.SetPrice(60000);

		Clothing c = new Clothing();
		c.SetProductId(2);
		c.SetName("Jacket");
		c.SetPrice(4000);

		Groceries g = new Groceries();
		g.SetProductId(3);
		g.SetName("Rice");
		g.SetPrice(1000);
		products.Add(e);
		products.Add(c);
		products.Add(g);
		foreach (Product p in products)
		{
			double tax = 0;
			if (p is ITaxable taxable)
				tax = taxable.CalculateTax();
			double finalPrice = p.GetFinalPrice(tax);
			Console.WriteLine($"{p.GetName()} Final Price: {finalPrice}");
		}



		List<Employee> employees = new List<Employee>();
		FullTimeEmployee fte = new FullTimeEmployee
		{
			EmployeeId = 101,
			Name = "Lucky",
			BaseSalary = 50000
		};
		fte.AssignDepartment("HR");
		PartTimeEmployee pte = new PartTimeEmployee
		{
			EmployeeId = 102,
			Name = "Khushi",
			WorkHours = 80,
			HourlyRate = 300
		};
		pte.AssignDepartment("Computer Science");
		employees.Add(fte);
		employees.Add(pte);
		foreach (Employee emp in employees)
		{
			emp.DisplayDetails();   // Polymorphism
		}
	}
}
