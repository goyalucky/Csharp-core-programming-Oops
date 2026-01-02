/*Hospital Patient Management
Description: Design a system to manage patients in a hospital.
● Abstract Class:
	o Create an abstract class Patient with fields: patientId, name, and age.
	o Add an abstract method CalculateBill().
	o Implement a concrete method GetPatientDetails().
● Subclasses:
	o Extend Patient into InPatient and OutPatient.
	o Implement CalculateBill() differently for each subclass.
● Interface:
	o Implement an interface IMedicalRecord.
	o Define methods AddRecord() and ViewRecords().
● Encapsulation:
	o Protect sensitive patient data like diagnosis and medical history.
● Polymorphism:
	o Use a Patient reference to handle different patient types dynamically.
	o Display billing details based on polymorphic behavior.
*/

using System;

public interface IMedicalRecord
{
	void AddRecord();
	void ViewRecords();
}

public abstract class Patient
{
	private int patientId;
	private string name;
	private int age;
	private string diagnosis;

	protected Patient(int patientId, string name, int age)
	{
		this.patientId = patientId;
		this.name = name;
		this.age = age;
	}

	public abstract double CalculateBill();

	public void AddDiagnosis(string diagnosis)
	{
		this.diagnosis = diagnosis;
	}

	public void GetPatientDetails()
	{
		Console.WriteLine($"Patient ID: {patientId}");
		Console.WriteLine($"Name: {name}");
		Console.WriteLine($"Age: {age}");
	}
}

public class InPatient : Patient, IMedicalRecord
{
	private int daysAdmitted;
	private double dailyCharge;

	public InPatient(int id, string name, int age, int days, double charge)
		: base(id, name, age)
	{
		daysAdmitted = days;
		dailyCharge = charge;
	}

	public override double CalculateBill()
	{
		return daysAdmitted * dailyCharge;
	}

	public void AddRecord()
	{
		Console.WriteLine("In-Patient medical record added");
	}

	public void ViewRecords()
	{
		Console.WriteLine("Viewing In-Patient medical history");
	}
}

public class OutPatient : Patient
{
	private double consultationFee;

	public OutPatient(int id, string name, int age, double fee)
		: base(id, name, age)
	{
		consultationFee = fee;
	}
	public override double CalculateBill()
	{
		return consultationFee;
	}
}
