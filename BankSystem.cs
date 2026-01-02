/*Banking System
Description: Create a banking system with different account types:
● Define an abstract class BankAccount with fields like accountNumber, holderName,and balance.
● Add methods like Deposit(double amount), Withdraw(double amount), and an abstract method CalculateInterest().
● Implement subclasses SavingsAccount and CurrentAccount with unique interest calculations.
● Create an interface ILoanable with methods ApplyForLoan() and CalculateLoanEligibility().
● Use encapsulation to secure account details and restrict unauthorized access.
● Demonstrate polymorphism by processing different account types and calculating interest dynamically.*/


using System;

public interface ILoanable
{
	void ApplyForLoan();
	void CalculateLoanEligibility();
}

public abstract class BankAccount
{
	private string accountNumber;
	private string holderName;
	protected double balance;

	protected BankAccount(string accountNumber, string holderName, double balance)
	{
		this.accountNumber = accountNumber;
		this.holderName = holderName;
		this.balance = balance;
	}

	public void Deposit(double amount)
	{
		balance += amount;
		Console.WriteLine($"Deposited: {amount}");
	}

	public void Withdraw(double amount)
	{
		if (amount <= balance)
		{
			balance -= amount;
			Console.WriteLine($"Withdrawn: {amount}");
		}
		else
		{
			Console.WriteLine("Insufficient Balance");
		}
	}

	public abstract void CalculateInterest();

	public void DisplayDetails()
	{
		Console.WriteLine($"Account No: {accountNumber}");
		Console.WriteLine($"Holder Name: {holderName}");
		Console.WriteLine($"Balance: {balance}");
	}
}


public class SavingsAccount : BankAccount, ILoanable
{
	private const double InterestRate = 0.04;

	public SavingsAccount(string accNo, string name, double bal)
		: base(accNo, name, bal) { }

	public override void CalculateInterest()
	{
		double interest = balance * InterestRate;
		balance += interest;
		Console.WriteLine($"Savings Interest Added: {interest}");
	}

	public void ApplyForLoan()
	{
		Console.WriteLine("Savings Account Loan Applied");
	}

	public void CalculateLoanEligibility()
	{
		Console.WriteLine($"Loan Eligibility: {balance * 3}");
	}
}


public class CurrentAccount : BankAccount
{
	private const double InterestRate = 0.02;

	public CurrentAccount(string accNo, string name, double bal)
		: base(accNo, name, bal) { }

	public override void CalculateInterest()
	{
		double interest = balance * InterestRate;
		balance += interest;
		Console.WriteLine($"Current Interest Added: {interest}");
	}
}
