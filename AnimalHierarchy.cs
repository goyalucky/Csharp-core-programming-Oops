/* Animal Hierarchy
Description:Create a hierarchy where Animal is the superclass, and Dog, Cat, and Bird are subclasses.Each subclass has a unique behavior.
Tasks:
1.Define a superclass Animal:
	o Add two attributes: Name(string) and Age(integer).
	o Add a method MakeSound() that provides a generic sound message (e.g.,"Animal makes a sound").
2. Define subclasses Dog, Cat, and Bird:
	o Each subclass should override the MakeSound() method to provide its unique behavior (e.g., "Dog barks", "Cat meows", "Bird chirps").
3. Goal:
	o Learn basic inheritance, method overriding, and polymorphism by calling MakeSound() on instances of different subclasses.*/


using System;

public class Animal
{
	public string Name;
	public int Age;

	public virtual void MakeSound()
	{
		System.Console.WriteLine("Animal makes a sound");
	}
}

public class Dog : Animal
{
	public override void MakeSound()
	{
		System.Console.WriteLine("Dog barks");
	}
}

public class Cat : Animal
{
	public override void MakeSound()
	{
		System.Console.WriteLine("Cat meows");
	}
}

public class Bird : Animal
{
	public override void MakeSound()
	{
		System.Console.WriteLine("Bird chirps");
	}
}
