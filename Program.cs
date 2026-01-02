using System;

class Program
{
	static void Main()
	{
		ElectricVehicle ev = new ElectricVehicle
		{
			Model = "Tesla",
			MaxSpeed = 200
		};
		PetrolVehicle pv = new PetrolVehicle
		{
			Model = "Suzuki",
			MaxSpeed = 180
		};
		ev.Charge();
		pv.Refuel();


		Worker w1 = new Chef { Name = "Rishabh", Id = 1 };
		Worker w2 = new Waiter { Name = "lucky", Id = 2 };
		w1.PerformDuties();
		w2.PerformDuties();


		Person[] people =
	   {
			new Teacher { Name = "Kiran Sir", Age = 40, Subject = "Math" },
			new Student { Name = "lucky", Age = 16, Grade = "10th" },
			new Staff { Name = "Bridzlabz", Age = 35, Department = "Accounts" }
		};
		foreach (Person p in people)
		{
			p.DisplayRole();   
		}


		BankAccount[] accounts =
		{
			new SavingsAccount { AccountNumber = 101, Balance = 50000, InterestRate = 4.5 },
			new CheckingAccount { AccountNumber = 102, Balance = 30000, WithdrawalLimit = 10000 },
			new FixedDepositAccount { AccountNumber = 103, Balance = 100000, TenureMonths = 24 }
		};
		foreach (BankAccount acc in accounts)
		{
			acc.DisplayAccountType();  
		}


		Course course = new PaidOnlineCourse
		{
			CourseName = "Dotnet",
			Duration = 40,
			Platform = "Byju's",
			IsRecorded = true,
			Fee = 5000,
			Discount = 20
		};
		course.DisplayInfo();


		Order o1 = new Order
		{
			OrderId = 1,
			OrderDate = "01-01-2026"
		};
		Order o2 = new ShippedOrder
		{
			OrderId = 2,
			OrderDate = "02-01-2026",
			TrackingNumber = "TRK123"
		};
		Order o3 = new DeliveredOrder
		{
			OrderId = 3,
			OrderDate = "03-01-2026",
			TrackingNumber = "TRK456",
			DeliveryDate = "05-01-2026"
		};
		Console.WriteLine(o1.GetOrderStatus());
		Console.WriteLine(o2.GetOrderStatus());
		Console.WriteLine(o3.GetOrderStatus());


		Device dev = new Thermostat
		{
			DeviceId = 123,
			Status = "5 Star",
			TemperatureSetting = 20
		};
		dev.DisplayStatus();   // Polymorphism



		Book book = new Author
		{
			Title = "Clean Code",
			PublicationYear = 2008,
			Name = "lucky goyal",
			Bio = "Software Engineer and Author"
		};
		book.DisplayInfo();   // Polymorphism


		Vehicle[] vehicles =
	   {
			new Car { MaxSpeed = 180, FuelType = "Petrol", SeatCapacity = 5 },
			new Truck { MaxSpeed = 120, FuelType = "Diesel", PayloadCapacity = 2000 },
			new Motorcycle { MaxSpeed = 150, FuelType = "Petrol", HasSidecar = false }
		};
		foreach (Vehicle v in vehicles)
		{
			v.DisplayInfo();   // Polymorphism
			Console.WriteLine();
		}


		Employee e1 = new Manager
		{
			Name = "Amit",
			Id = 101,
			Salary = 80000,
			TeamSize = 5
		};
		Employee e2 = new Developer
		{
			Name = "Riya",
			Id = 102,
			Salary = 60000,
			ProgrammingLanguage = "C#"
		};
		Employee e3 = new Intern
		{
			Name = "Rahul",
			Id = 103,
			Salary = 15000,
			InternshipDuration = "3 Months"
		};
		e1.DisplayDetails();
		e2.DisplayDetails();
		e3.DisplayDetails();


		Animal[] animals =
		{
			new Dog(),
			new Cat(),
			new Bird()
		};
		foreach (Animal a in animals)
		{
			a.MakeSound(); 
		}
	}
}