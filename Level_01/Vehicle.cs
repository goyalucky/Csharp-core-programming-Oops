/* Vehicle Registration System
Create a Vehicle class with the following features:
● static:
	o A static variable RegistrationFee common for all vehicles.
	o A static method UpdateRegistrationFee() to modify the fee.
● this:
	o Use this to initialize OwnerName, VehicleType, and RegistrationNumber in the constructor.
● readonly:
	o Use a readonly variable RegistrationNumber to uniquely identify each vehicle.
● is operator:
	o Check if an object belongs to the Vehicle class before displaying its registration details.*/


using System;

class Vehicle
{
    // static variable (shared by all vehicles)
    public static int RegistrationFee = 0;

    // readonly variable
    public readonly int RegistrationNumber;

    // instance variables
    public string OwnerName;
    public string VehicleType;

    // constructor using 'this' keyword
    public Vehicle(int RegistrationNumber, string OwnerName, string VehicleType)
    {
        this.RegistrationNumber = RegistrationNumber;
        this.OwnerName = OwnerName;
        this.VehicleType = VehicleType;
    }

    // static method
    public static void UpdateRegistrationFee(int newFees)
    {
        if (newFees < 0 || newFees > 5000)
        {
            throw new ArgumentException("Registration fee must be between 0 and 5000");
        }
        RegistrationFee = newFees;
    }

    // method using 'is' operator
    public void DisplayVehicleDetails(object obj)
    {
        if (obj is Vehicle)
        {
            Vehicle v = (Vehicle)obj;
            Console.WriteLine("Owner Name: " + v.OwnerName);
            Console.WriteLine("Vehicle Type: " + v.VehicleType);
            Console.WriteLine("Registration Number: " + v.RegistrationNumber);
            Console.WriteLine("Registration Fee: " + RegistrationFee);
        }
        else
        {
            Console.WriteLine("Invalid object. Not a Vehicle instance.");
        }
    }
}
