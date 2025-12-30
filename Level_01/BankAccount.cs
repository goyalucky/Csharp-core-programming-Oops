/* Bank Account System
Create a BankAccount class with the following features:
● static:
	o A static variable bankName shared across all accounts.
	o A static method GetTotalAccounts() to display the total number of accounts.
● this:
	o Use this to resolve ambiguity in the constructor when initializing
	AccountHolderName and AccountNumber.
● readonly:
	o Use a readonly variable AccountNumber to ensure it cannot be changed once
	assigned.
● is operator:
	o Check if an account object is an instance of the BankAccount class before
	displaying its details.*/



using System;

class BankAccount
{
	// static variable (shared across all objects)
	public static string BankName = "State Bank of India";
	private static int totalAccounts = 0;

	// readonly variable (cannot be changed once assigned)
	public readonly int AccountNumber;

	// instance variable
	public string AccountHolderName;

	// constructor using 'this' keyword
	public BankAccount(string AccountHolderName, int AccountNumber)
	{
		this.AccountHolderName = AccountHolderName;
		this.AccountNumber = AccountNumber;
		totalAccounts++;
	}

	// static method
	public static void GetTotalAccounts()
	{
		Console.WriteLine("Total Accounts: " + totalAccounts);
	}

	// display method using 'is' operator
	public void DisplayDetails(object obj)
	{
		if (obj is BankAccount)
		{
			BankAccount acc = (BankAccount)obj;
			Console.WriteLine("Bank Name: " + BankName);
			Console.WriteLine("Account Holder: " + acc.AccountHolderName);
			Console.WriteLine("Account Number: " + acc.AccountNumber);
		}
		else
		{
			Console.WriteLine("Not a BankAccount object");
		}
	}
}
