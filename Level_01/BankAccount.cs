/* Bank Account Management
● Create a BankAccount class with :
	o accountNumber (public)
	o accountHolder(protected)
	o balance(private)
● Implement methods to:
	o Access and modify balance using public methods.
	o Create a subclass SavingsAccount to demonstrate access to accountNumber
	and accountHolder.*/


using System;

class BankAccount
{
	// Public member
	public string accountNumber;

	// Protected member
	protected string accountHolder;

	// Private member
	private double balance;

	// Constructor
	public BankAccount(string accountNumber, string accountHolder, double balance)
	{
		this.accountNumber = accountNumber;
		this.accountHolder = accountHolder;
		this.balance = balance;
	}

	// Public method to get balance
	public double GetBalance()
	{
		return balance;
	}

	// Public method to deposit money
	public void Deposit(double amount)
	{
		if (amount > 0)
		{
			balance += amount;
		}
		else
		{
			Console.WriteLine("Invalid deposit amount");
		}
	}

	// Public method to withdraw money
	public void Withdraw(double amount)
	{
		if (amount > 0 && amount <= balance)
		{
			balance -= amount;
		}
		else
		{
			Console.WriteLine("Insufficient balance or invalid amount");
		}
	}
}

// Subclass
class SavingsAccount : BankAccount
{
	public double interestRate;

	public SavingsAccount(string accountNumber, string accountHolder, double balance, double interestRate)
		: base(accountNumber, accountHolder, balance)
	{
		this.interestRate = interestRate;
	}

	// Method demonstrating access to public & protected members
	public void DisplayAccountDetails()
	{
		Console.WriteLine("Account Number: " + accountNumber);   // Public
		Console.WriteLine("Account Holder: " + accountHolder);   // Protected
		Console.WriteLine("Balance: " + GetBalance());           // Private via method
		Console.WriteLine("Interest Rate: " + interestRate + "%");
	}
}

// Main Class
class Program
{
	static void Main()
	{
		SavingsAccount sa = new SavingsAccount("ACC12345", "Prashant Goyal", 5000, 4.5);

		sa.DisplayAccountDetails();

		sa.Deposit(2000);
		sa.Withdraw(1500);

		Console.WriteLine("Updated Balance: " + sa.GetBalance());
	}
}
