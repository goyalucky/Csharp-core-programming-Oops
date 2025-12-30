/* Car Rental System
o Create a CarRental class with attributes customerName, carModel, and rentalDays.
o Add constructors to initialize the rental details and calculate total cost. */


using System;

class CarRental
{
	public string CarModel;
	public int RentalDays;
	public double DailyRate;
	// Parameterized Constructor
	public CarRental(string carModel, int rentalDays, double dailyRate)
	{
		CarModel = carModel;
		RentalDays = rentalDays;
		DailyRate = dailyRate;
	}
	// Method to calculate total rental cost
	public double CalculateTotalCost()
	{
		return RentalDays * DailyRate;
	}
	// Display Rental Details
	public void DisplayRentalDetails()
	{
		Console.WriteLine(
			$"Car Model: {CarModel}, Rental Days: {RentalDays}, Daily Rate: {DailyRate}, Total Cost: {CalculateTotalCost()}"
		);
	}
}