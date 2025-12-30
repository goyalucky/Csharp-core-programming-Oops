/*Person Class(Copy Constructor)
o Create a Person class with a copy constructor that clones another person's
attributes.*/


using System;

class Person
{
	public string Name;
	public int Age;

	// Parameterized Constructor
	public Person(string name, int age)
	{
		Name = name;
		Age = age;
	}

	// Copy Constructor
	public Person(Person other)
	{
		Name = other.Name;
		Age = other.Age;
	}

	// Display Method
	public void Display()
	{
		Console.WriteLine($"Name: {Name}, Age: {Age}");
	}
}
