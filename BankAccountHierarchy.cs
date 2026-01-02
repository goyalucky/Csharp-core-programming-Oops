/*Bank Account Types
○ Description: Model a banking system with different account types using hierarchical inheritance. BankAccount is the superclass, 
with SavingsAccount, CheckingAccount, and FixedDepositAccount as subclasses.
○ Tasks:
■ Define a base class BankAccount with attributes like AccountNumber and Balance.
■ Define subclasses SavingsAccount, CheckingAccount, and FixedDepositAccount, each with unique attributes like interestRate for 
SavingsAccount and WithdrawalLimit for CheckingAccount.
■ Implement a method DisplayAccountType() in each subclass to specify the account type.
○ Goal: Explore hierarchical inheritance, demonstrating how each subclass can have unique attributes while inheriting from a shared superclass.*/


using System;

public class BankAccount
{
	public int AccountNumber;
	public double Balance;

	public virtual void DisplayAccountType()
	{
		Console.WriteLine("Bank Account");
	}
}

public class SavingsAccount : BankAccount
{
	public double InterestRate;

	public override void DisplayAccountType()
	{
		Console.WriteLine("Savings Account - Interest Rate: " + InterestRate + "%");
	}
}

public class CheckingAccount : BankAccount
{
	public double WithdrawalLimit;

	public override void DisplayAccountType()
	{
		Console.WriteLine("Checking Account - Withdrawal Limit: " + WithdrawalLimit);
	}
}

public class FixedDepositAccount : BankAccount
{
	public int TenureMonths;

	public override void DisplayAccountType()
	{
		Console.WriteLine("Fixed Deposit Account - Tenure: " + TenureMonths + " months");
	}
}
