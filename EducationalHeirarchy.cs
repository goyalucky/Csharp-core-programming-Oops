/*Educational Course Hierarchy
○ Description: Model a course system where Course is the base class, OnlineCourse is a subclass, and PaidOnlineCourse extends OnlineCourse.
○ Tasks:
■ Define a superclass Course with attributes like CourseName and Duration.
■ Define OnlineCourse to add attributes such as Platform and IsRecorded.
■ Define PaidOnlineCourse to add Fee and Discount.
○ Goal: Demonstrate how each level of inheritance builds on the previous, adding complexity to the system.*/


using System;

public class Course
{
	public string CourseName;
	public int Duration;

	public virtual void DisplayInfo()
	{
		Console.WriteLine("Course Name:" + CourseName + "Duration" + Duration);
	}
}

public class OnlineCourse : Course
{
	public string Platform;
	public bool isRecorded;

	public override void DisplayInfo()
	{
		base.DisplayInfo();
		Console.WriteLine("Platform:" + Platform + "is Recorded" + isRecorded);
	}
}

public class PaidOnlineCourse : Course
{
	public int Fee;
	public int Discount;

	public override void DisplayInfo()
	{
		base.DisplayInfo();
		Console.WriteLine("Fee:" + Fee + "Discount" + Discount);
	}
}
