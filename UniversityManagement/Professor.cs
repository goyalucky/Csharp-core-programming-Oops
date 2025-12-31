using System;

//Professor class
class Professor
{
	public string Name { get; set; }

	public Professor(string name)
	{
		Name = name;
	}

	// Communication method
	public void AssignProfessor(Course course)
	{
		course.AssignProfessor(this);
	}
}