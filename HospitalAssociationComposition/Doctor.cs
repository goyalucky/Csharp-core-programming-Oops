/* Hospital, Doctors, and Patients (Association and Communication)
Description: Model a Hospital where Doctor and Patient objects interact through consultations. A doctor can see multiple patients, and each 
patient can consult multiple doctors.
Tasks:
● Define a Hospital class containing Doctor and Patient classes.
● Create a method Consult() in the Doctor class to show communication, which would display the consultation between a doctor and a patient.
● Model an association between doctors and patients to show that doctors and patients can have multiple relationships.
Goal: Practice creating an association with communication between objects by modeling doctor-patient consultations.*/


using System;

// Doctor class
class Doctor
{
	public string Name { get; set; }

	public Doctor(string name)
	{
		Name = name;
	}

	// Composition method
	public void Consult(Patient patient)
	{
		Console.WriteLine($"Dr. {Name} is consulting patient {patient.Name}");
	}
}