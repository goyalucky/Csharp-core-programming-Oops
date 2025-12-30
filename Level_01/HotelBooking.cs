/*Hotel Booking System
o Create a HotelBooking class with attributes guestName, roomType, and nights.
o Use default, parameterized, and copy constructors to initialize bookings. */


using System;

class HotelBooking
{
	public string GuestName;
	public int RoomNumber;
	public int Nights;

	// Parameterized Constructor
	public HotelBooking(string guestName, int roomNumber, int nights)
	{
		GuestName = guestName;
		RoomNumber = roomNumber;
		Nights = nights;
	}

	// Default Constructor
	public HotelBooking()
	{
		GuestName = "John Doe";
		RoomNumber = 101;
		Nights = 1;
	}

	// Copy Constructor
	public HotelBooking(HotelBooking other)
	{
		GuestName = other.GuestName;
		RoomNumber = other.RoomNumber;
		Nights = other.Nights;
	}

	// Display Booking Details
	public void DisplayBooking()
	{
		Console.WriteLine(
			$"Guest Name: {GuestName}, Room Number: {RoomNumber}, Nights: {Nights}"
		);
	}
}
