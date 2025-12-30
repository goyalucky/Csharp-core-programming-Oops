/* Hospital Management System
Create a Patient class with the following features:
● static:
	o A static variable HospitalName shared among all patients.
	o A static method GetTotalPatients() to count the total patients admitted.
● this:
	o Use this to initialize Name, Age, and Ailment in the constructor.
● readonly:
	o Use a readonly variable PatientID to uniquely identify each patient.
● is operator:
	o Check if an object is an instance of the Patient class before displaying its details.*/



using System;

class Patient
{
	public static string HospitalName = "City Hospital";
	private static int totalPatients = 0;
	
	public readonly int PatientId;
	public string Name;
	public int Age;
	public string Ailment;

	public Patient(int Id, string Name,int Age, string Ailment)
	{
		this.PatientId = Id;
		this.Name = Name;
		this.Age = Age;
		this.Ailment = Ailment;
		totalPatients++;
	}

	public static void GetTotalPatients()
	{
		Console.WriteLine("Total no of Patients in Hospital" + totalPatients);
	}
	public void DisplayPatientDetails(object obj)
	{
		if (obj is Patient)
		{
			Patient pat = (Patient)obj;
			Console.WriteLine("Hospital Name: " + HospitalName);
			Console.WriteLine("Patient Name: " + pat.Name);
			Console.WriteLine("Patient ID: " + pat.PatientId);
			Console.WriteLine("Patient Age: " + pat.Age);
			Console.WriteLine("Patient Ailment: " + pat.Ailment);
		}
		else
		{
			Console.WriteLine("Not a Patient object");
		}
	}
}