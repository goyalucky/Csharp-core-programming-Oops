/*Vehicle Registration
? Create a Vehicle class to manage vehicle details:
	o Instance Variables: ownerName, vehicleType.
	o Class Variable: registrationFee(fixed for all vehicles).
? Implement the following methods:
	o An instance method DisplayVehicleDetails() to display owner and vehicle details.
	o A class method UpdateRegistrationFee() to change the registration fee*/.


using System;

class Vehicle
{
	private stringg ownerName;
	private string vehicleType;
	private static int registrationFee;

	// Parameterized Constructor
	public Vehicle(string ownerName, string vehicleType, int regFee)
	{
		this.ownerName = ownerName;
		this.vehicleType = vehicleType;
		registrationFee = regFee;
	}

	// Instance Method
	public void DisplayVehicleDetails()
	{
		Console.WriteLine("Owner Name: " + ownerName);
		Console.WriteLine("Vehicle Type: " + vehicleType);
		Console.WriteLine("Registration Fee: " + registrationFee);
	}

	// Static Method to update fee
	public static void UpdateRegistrationFee(int newUpdatedFee)
	{
		if (newUpdatedFee <= 0)
		{
			throw new ArgumentException("Registration fee must be greater than 0");
		}

		registrationFee = newUpdatedFee;
	}

	// Static Getter
	public static int GetRegistrationFee()
	{
		return registrationFee;
	}
}
