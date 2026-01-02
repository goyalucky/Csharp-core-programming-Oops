using System;

public class Person
{
	public string Name;
	public int Id;
}

public interface Worker
{
	void PerformDuties();
}

public class Chef : Person, Worker
{
	public void PerformDuties()
	{
		Console.WriteLine("Chef cooks food");
	}
}

public class Waiter : Person, Worker
{
	public void PerformDuties()
	{
		Console.WriteLine("Waiter serves food to customers");
	}
}
