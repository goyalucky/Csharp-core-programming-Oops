using System;
using System.Collections.Generic;


// Main class
class Program
{
	static void Main()
	{
		Hospital hospital = new Hospital();

		Doctor d1 = new Doctor("Sharma");
		Doctor d2 = new Doctor("Mehta");

		Patient p1 = new Patient("Amit");
		Patient p2 = new Patient("Riya");

		hospital.Doctors.Add(d1);
		hospital.Doctors.Add(d2);

		hospital.Patients.Add(p1);
		hospital.Patients.Add(p2);

		d1.Consult(p1);
		d1.Consult(p2);
		d2.Consult(p1);
	}
}
